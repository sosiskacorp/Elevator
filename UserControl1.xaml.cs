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
using System.Windows.Threading;
namespace lift
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public delegate int myHandler(string floor);
        public event myHandler floorchange;
       

        public UserControl1()
        {
            InitializeComponent();
            watchout.Visibility = Visibility.Hidden;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int isWarining;
            isWarining = floorchange.Invoke((sender as Button).Content.ToString());
            if (isWarining == 1) watchout.Visibility = Visibility.Visible;
            else watchout.Visibility = Visibility.Hidden;
        }
    }

}
