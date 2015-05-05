using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharpFileMergeTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<FileInfo> fileList = new ObservableCollection<FileInfo>();
        public ObservableCollection<FileInfo> FileList
        {
            get { return fileList; }
            set { fileList = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            // fileNamesListView.ItemsSource = fileList;
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

            e.Handled = true;
        }

        private void AddFileInfoIfNotFoundInList(FileInfo fileInfo)
        {
            if (!fileList.Any(file => file.FullPathName.Equals(fileInfo.FullPathName)))
            {
                fileList.Add(fileInfo);
            }
        }
    }

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
