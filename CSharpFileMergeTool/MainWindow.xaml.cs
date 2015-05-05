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
        ObservableCollection<string> imports = new ObservableCollection<string>();
        public ObservableCollection<string> Imports
        {
            get { return imports; }
            set { imports = value; }
        }

        ObservableCollection<FileInfo> fileList = new ObservableCollection<FileInfo>();
        public ObservableCollection<FileInfo> FileList
        {
            get { return fileList; }
            set { fileList = value; }
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

            e.Handled = true;
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
    }
}
