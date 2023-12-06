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
using static System.Math;

namespace _227_Ярослав
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void Button_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(Rezult_a.Text);
            double b = Convert.ToDouble(Rezult_b.Text);
            double x = Convert.ToDouble(Rezult_c.Text);
            double y = 0;
            if (x > PI) { y = 1 - Exp(-a * x) * Sin(a * x + b); }
            else if (x < -PI) { y = 1 - (Exp(-a * x) + Exp(-b * x)); }
            else { y = 1 - Exp(-a * x) * (a * x + b); }
            TextBlockAnswer.Text = $"{y} ";

        }
    }
