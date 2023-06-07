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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
namespace lift
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>



    public partial class MainWindow : Window
    {
        private int currentfloor = 9;
        private double speed = 0.5;
        int brokenFloor;



        public MainWindow()
        {
            Random rnd = new Random();
            InitializeComponent();
            brokenFloor = rnd.Next(1, 10);
        }

        private int UserControl1_floorchange(string flor)
        {
            int targetFloor = Int32.Parse(flor);
            DoubleAnimation LiftAnim = new DoubleAnimation();
            LiftAnim.From = Canvas.GetTop(image);
            LiftAnim.By = (targetFloor - currentfloor) * 37 * (-1);
            LiftAnim.Duration = TimeSpan.FromSeconds(Math.Abs(targetFloor - currentfloor) * speed);
            image.BeginAnimation(TopProperty, LiftAnim);
            currentfloor = targetFloor;

            if (brokenFloor == targetFloor)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
