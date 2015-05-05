using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

        string fullPathName;
        public string FullPathName
        {
            get { return fullPathName; }
        }

        List<string> imports;
        public List<string> Imports
        {
            get { return imports; }
        }

        string _namespace;
        public string Namespace
        {
            get { return _namespace; }
        }

        string classTextInNamespace;
        public string ClassTextInNamespace
        {
            get { return classTextInNamespace; }
        }

        bool hasMainMethod;
        public bool HasMainMethod
        {
            get { return hasMainMethod; }
        }

        public FileInfo(string fullPathName)
        {
            string[] pathComponents = fullPathName.Split('\\');
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
            this.fullPathName = fullPathName;

            string textFromFile = System.IO.File.ReadAllText(@fullPathName);

            ParseImports(textFromFile);
            ParseNamespace(textFromFile);
            ParseAllClassesInNamespace(textFromFile);

            FindMainMethodAndSetProperty(textFromFile);
        }

        private void FindMainMethodAndSetProperty(string textFromFile)
        {
            string pattern = @"Main\(string\s*\[\s*\]\s+\w+\)\s*\{";
            Match match = Regex.Match(textFromFile, pattern);

            hasMainMethod = match.Equals(Match.Empty) ? false : true;
        }

        private void ParseAllClassesInNamespace(string textFromFile)
        {
            string pattern = @"namespace\s+\w+\s+\{(?<allClasses>[\w\W]+)\}";
            Match match = Regex.Match(textFromFile, pattern);

            classTextInNamespace = match.Groups["allClasses"].Value;
        }

        private void ParseNamespace(string textFromFile)
        {
            string pattern = @"namespace\s+(?<namespace>\w+)";
            Match match = Regex.Match(textFromFile, pattern);

            _namespace = match.Groups["namespace"].Value;
        }

        private void ParseImports(string textFromFile)
        {
            imports = new List<string>();
            string pattern = @"using\s+(?<import>[\w\.]+);";

            foreach (Match match in Regex.Matches(textFromFile, pattern))
            {
                imports.Add(match.Groups["import"].Value);
            }
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
            {
                throw new ArgumentException("Object is not a FileInfo");
            }
        }
    }
}
