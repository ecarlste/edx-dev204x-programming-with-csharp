using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace CSharpFileMergeTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string mergedFileText = "testing text";
        public string MergedFileText
        {
            get { return mergedFileText; }
            set
            {
                mergedFileText = value;
                OnPropertyChanged("MergedFileText");
            }
        }

        ObservableCollection<string> imports = new ObservableCollection<string>();
        public ObservableCollection<string> Imports
        {
            get { return imports; }
        }

        ObservableCollection<FileInfo> fileList = new ObservableCollection<FileInfo>();
        public ObservableCollection<FileInfo> FileList
        {
            get { return fileList; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void fileNamesTextBlock_Drop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            ListView listView = sender as ListView;

            foreach (string fileName in fileNames)
            {
                FileInfo fileInfo = new FileInfo(fileName);
                
                AddFileInfoIfNotFoundInList(fileInfo);
            }

            RebuildMergedFileText();

            e.Handled = true;
        }

        private void RebuildMergedFileText()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(Environment.NewLine);

            foreach (string import in imports)
            {
                stringBuilder.Append("using " + import + ";" + Environment.NewLine);
            }

            stringBuilder.Append(Environment.NewLine + "namespace " + fileList[0].Namespace +
                Environment.NewLine + "{" + Environment.NewLine);

            foreach (FileInfo file in fileList)
            {
                int lineLength = 80;
                string commentLine = new String('/', lineLength) + Environment.NewLine;
                string fileNamePrefix = "//  Code from: " + file.Name;
                string fileNameSuffix = new String(' ', lineLength - fileNamePrefix.Length - 2) + "//" + Environment.NewLine;

                stringBuilder.Append(Environment.NewLine + commentLine + fileNamePrefix +
                    fileNameSuffix + commentLine);

                stringBuilder.Append(file.ClassTextInNamespace);
            }

            stringBuilder.Append("}" + Environment.NewLine);

            MergedFileText = stringBuilder.ToString();
        }

        private void AddFileInfoIfNotFoundInList(FileInfo fileInfo)
        {
            if (!fileList.Any(file => file.FullPathName.Equals(fileInfo.FullPathName)))
            {
                fileList.Add(fileInfo);
                AddImportsFromFileInfo(fileInfo);
            }
        }

        private void AddImportsFromFileInfo(FileInfo fileInfo)
        {
            List<string> updatedImports = new List<string>(fileInfo.Imports.Union(imports));
            updatedImports.Sort();

            imports = new ObservableCollection<string>(updatedImports);
        }

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
