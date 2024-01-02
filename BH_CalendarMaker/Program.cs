using BH_CalendarMaker.Login;
using BH_CalendarMaker.Main;
using BH_CalendarMaker.Properties;
using BH_Core.Config;
using BH_Core.Helper;
using BH_Core.Util;
using BH_Library.Utils;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BH_CalendarMaker
{
    static class Program
    {
        [DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern Boolean AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateFile(
            string lpFileName,
            uint dwDesiredAccess,
            uint dwShareMode,
            uint lpSecurityAttributes,
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes,
            uint hTemplateFile);

        private const int MY_CODE_PAGE = 949;
        private const uint GENERIC_WRITE = 0x40000000;
        private const uint FILE_SHARE_WRITE = 0x2;
        private const uint OPEN_EXISTING = 0x3;

        [DllImport("User32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern IntPtr SetForegroundWindow(IntPtr hWnd);

        [DllImport("User32.dll")]
        private static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_SHOWNORMAL = 1;

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ShowConsoleWindow();
            bool createdNew;
            Config.RunMutex = new Mutex(true, Application.ProductName, out createdNew);
            if (createdNew)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //관리자권한획득
                SelfElevatedProcess(args);
                bool Isexit = true;
                Console.WriteLine("프로그램을 시작합니다...");
                RunTimeChecker.IsRunTime = true;
                bool AutoLogin = true;
                while (Isexit)
                {
                    Isexit = false;
                    Config.IsExitPossible = true;
                    IconHelper.DefaultIcon = Resources.Main;
                    frmLogin _login = new frmLogin(AutoLogin);
                    if (_login.ShowDialog() == DialogResult.OK)
                    {
                        Console.WriteLine("로그인 완료");
                        Isexit = true;
                       

                        Application.Run(new frmMain());
                        Isexit = !Config.IsExitPossible;
                        AutoLogin = false;
                    }
                }

                if (Config.RunMutex != null)
                {
                    Config.RunMutex.ReleaseMutex();
                    Config.RunMutex = null;
                }
            }
            else
            {
                //폼의 핸들을 찾는다.
                IntPtr ptr2 = FindWindow(null, Application.ProductName);

                //폼을 Show
                SetForegroundWindow(ptr2);
                string paramName = "starttag";
                string paramValue = paramName.GetQueryStringParameters();
                if (paramValue == "showMain")
                    ShowWindow(ptr2, 5);
                else
                    ShowWindow(ptr2, SW_SHOWNORMAL);
            }
        }

        private static void ShowConsoleWindow()
        {
            bool OpenConsole = false;
#if DEBUG
            OpenConsole = true;
#else
            if (File.Exists(Application.StartupPath + @"\CTest.dat"))
                OpenConsole = true;
#endif
            if (OpenConsole)
            {
                if (!AllocConsole())
                    MessageBox.Show("Console Window Load Failed");
                else
                {
                    IntPtr stdHandle = CreateFile("CONOUT$", GENERIC_WRITE, FILE_SHARE_WRITE, 0, OPEN_EXISTING, 0, 0);
                    SafeFileHandle safeFileHandle = new SafeFileHandle(stdHandle, true);
                    FileStream fileStream = new FileStream(safeFileHandle, FileAccess.Write);
                    Encoding encoding = System.Text.Encoding.GetEncoding(MY_CODE_PAGE);
                    StreamWriter standardOutput = new StreamWriter(fileStream, encoding);
                    standardOutput.AutoFlush = true;
                    Console.SetOut(standardOutput);
                    Console.Write("This will show up in the Console window.");
                }
            }
        }
 

        //관리자 권한으로 실행
        private static void SelfElevatedProcess(string[] args)
        {
            //vista 미만일때는 패스
            if (Environment.OSVersion.Version.Major < 6)
            {
                Console.WriteLine("관리자 권한으로 실행안함");
                return;
            }
            Console.WriteLine("관리자 권한으로 실행준비...");

            if (!IsRunAsAdmin())
            {
                Console.WriteLine("관리자 권한이 없으므로 관리자 권한으로 실행");
                // Launch itself as administrator
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.WorkingDirectory = Environment.CurrentDirectory;
                proc.FileName = Application.ExecutablePath;

                Console.WriteLine("관리자권한으로 실행 -- 관리자권한으로 실행할 프로세스 : " + proc.FileName);

                string argument = string.Empty;
                if (args != null)
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                        if (argument == string.Empty)
                        {
                            argument = args[i];
                        }
                        else
                        {
                            argument += " " + args[i];
                        }
                    }
                }
                proc.Arguments = argument;
                proc.Verb = "runas";

                try
                {
                    Process.Start(proc);
                    Console.WriteLine("관리자 권한으로 실행...");
                    Application.Exit(); // Quit itself

#if !DEBUG
                    Environment.Exit(0);
#endif
                }
                catch (Exception ex)
                {
                    // The user refused to allow privileges elevation.
                    // Do nothing and return directly ...
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static bool IsRunAsAdmin()
        {
            bool isAdmin = false;
            try
            {
                WindowsIdentity id = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(id);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch
            {
            }
            return isAdmin;
        }
    } 
}
