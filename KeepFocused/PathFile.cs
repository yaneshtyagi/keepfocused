using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeepFocused
{    

    public class PathFile
    {
        private string pathFolder;
        private string fileName;

        public string getPathFolder()
        {
            return pathFolder;
        }
        public void setPathFolder(string f)
        {
            pathFolder = f;
        }

        public string getFileName()
        {
            return fileName;
        }
        public void setFileName(string f)
        {
            fileName = f;
        }
    }
}
