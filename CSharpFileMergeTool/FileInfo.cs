using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFileMergeTool
{
    public class FileInfo : IComparable
    {
        string path;
        public string Path
        {
            get { return path; }
        }

        string name;
        public string Name
        {
            get { return name; }
        }

        public string FullPathName
        {
            get { return path + name; }
        }

        public FileInfo(string pathName)
        {
            string[] pathComponents = pathName.Split('\\');
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < pathComponents.Length - 1; i++)
            {
                if (i > 0)
                {
                    sb.Append('\\');
                }
                sb.Append(pathComponents[i]);
            }

            path = sb.ToString();
            name = pathComponents[pathComponents.Length - 1];
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            FileInfo otherFileInfo = obj as FileInfo;
            if (otherFileInfo != null)
            {
                if (name.Equals(otherFileInfo.Name))
                {
                    return FullPathName.CompareTo(otherFileInfo.FullPathName);
                }
                else
                {
                    return name.CompareTo(otherFileInfo.Name);
                }
            }
            else
                throw new ArgumentException("Object is not a FileInfo");
        }
    }
}
