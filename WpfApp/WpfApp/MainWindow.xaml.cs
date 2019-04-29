using System;
using System.Collections.Generic;
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

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Student student = new Student
            {
                Name = "Vasya",
                Surname = "Pupkin",
                DateBirth = DateTime.Now.AddYears(-22),
                AverageMark=5.5,
                Course=2
            };
            InitializeComponent();
            Student.Text = $" Name: {student.Name}, \n Surname: {student.Surname}, \n Date of Birth: {student.DateBirth}, \n Average Mark: {student.AverageMark}, \n Course: {student.Course}";
        }
    }
}
