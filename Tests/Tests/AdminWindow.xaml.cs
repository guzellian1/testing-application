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
using System.Windows.Shapes;

namespace Tests
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {

        Users user = new Users();

        public AdminWindow(Users newUser)
        {
            user = newUser;
            InitializeComponent();
            frame.Navigate(new QuestionEditPage());
        }

        private void EnterToQuestion(object sender, RoutedEventArgs e)
        {
            //this.frame.Navigate(typeof(QuestionEditPage));
            frame.Navigate(new QuestionEditPage());
        }
    }
}
