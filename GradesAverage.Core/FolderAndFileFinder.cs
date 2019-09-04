using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GradesAverage.Core
{
    public static class FolderAndFileFinder
    {
        public const string  FolderName = "UserData";

        public const string Ending = ".xml";


        public static void UserDataFile()
        {
            if (!Directory.Exists("UsersData"))
            {
                Directory.CreateDirectory("UsersData");
            }
        }

        public static bool ExistUserData(string i_UserName)
        {
           return File.Exists($@"{FolderName}\{i_UserName}{Ending}");
        }

        public static void Username()
        {

        }
    }
}
