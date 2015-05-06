
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        List<Student> students = new List<Student>();
        int studentIndex = 0;
        bool currentlyDisplayingStudent = false;

        public event PropertyChangedEventHandler PropertyChanged;

        bool btnCreateStudentIsEnabled = false;
        public bool BtnCreateStudentIsEnabled
        {
            get { return btnCreateStudentIsEnabled; }
            set
            {
                btnCreateStudentIsEnabled = value;
                OnPropertyChanged("BtnCreateStudentIsEnabled");
            }
        }

        bool btnPreviousIsEnabled = false;
        public bool BtnPreviousIsEnabled
        {
            get { return btnPreviousIsEnabled; }
            set
            {
                btnPreviousIsEnabled = value;
                OnPropertyChanged("BtnPreviousIsEnabled");
            }
        }

        bool btnNextIsEnabled = false;
        public bool BtnNextIsEnabled
        {
            get { return btnNextIsEnabled; }
            set
            {
                btnNextIsEnabled = value;
                OnPropertyChanged("BtnNextIsEnabled");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        ////////////////////////
        // Grading Criteria 1 //
        ////////////////////////
        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            CreateStudentFromTextBoxes();
            ClearAllTextBoxes();
            SetBtnPreviousAndNextEnabled(true);
        }

        private void SetBtnPreviousAndNextEnabled(bool isEnabled)
        {
            BtnPreviousIsEnabled = isEnabled;
            BtnNextIsEnabled = isEnabled;
        }

        private void CreateStudentFromTextBoxes()
        {
            ////////////////////////
            // Grading Criteria 2 //
            ////////////////////////
            Student student = new Student();
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.City = txtCity.Text;

            ////////////////////////
            // Grading Criteria 4 //
            ////////////////////////
            students.Add(student);
        }

        private void ClearAllTextBoxes()
        {
            ////////////////////////
            // Grading Criteria 3 //
            ////////////////////////
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            
            BtnCreateStudentIsEnabled = false;
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (currentlyDisplayingStudent) setStudentIndexAsPrevious();

            ////////////////////////
            // Grading Criteria 6 //
            ////////////////////////
            DisplayCurrentStudent();
        }

        private void setStudentIndexAsPrevious()
        {
            studentIndex = (studentIndex == 0) ? students.Count - 1 : studentIndex - 1;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (currentlyDisplayingStudent) setStudentIndexAsNext();

            ////////////////////////
            // Grading Criteria 5 //
            ////////////////////////
            DisplayCurrentStudent();
        }

        private void setStudentIndexAsNext()
        {
            studentIndex = (studentIndex == students.Count - 1) ? 0 : studentIndex + 1;
        }

        private void DisplayCurrentStudent()
        {
            Student student = students[studentIndex];

            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtCity.Text = student.City;

            currentlyDisplayingStudent = true;
            BtnCreateStudentIsEnabled = false;
        }

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private void txtAnyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtCity.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "")
                BtnCreateStudentIsEnabled = false;
            else
                BtnCreateStudentIsEnabled = true;

            currentlyDisplayingStudent = false;
        }
    }
}
