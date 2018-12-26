using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;

namespace DBA_Sys
{
    class CopyTestBuild
    {
        public static void CopyBuild(string copyNumber)
        {
            string sourcePath = @"\\pubg-pds\dist\" + copyNumber;

            string destinationPath = @"C:\TestBuild\" + copyNumber;

            FileSystem.CopyDirectory(sourcePath, destinationPath, UIOption.AllDialogs);

        }

    }
}
