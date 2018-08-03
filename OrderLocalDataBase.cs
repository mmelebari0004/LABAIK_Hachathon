using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Hachathon2;
using Xamarin.Forms;

[assembly: Dependency(typeof(CommentLocalDataBase))]

namespace Hachathon2
{
    public class CommentLocalDataBase: ICampaignLocalDatabase
    {
        public string GetLocalFilePath(string fileName)
        {
            string docFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, fileName);

        }
    }
}