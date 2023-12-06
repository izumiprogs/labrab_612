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

namespace WpfApp3
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

        void BtnOK_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(Rezult_a.Text);
            int b = Convert.ToInt32(Rezult_b.Text);
            int c = Convert.ToInt32(Rezult_c.Text);
            int s = 0;
            if ((a < b) && (a < c)) s = b + c;
            if ((b < a) && (b < c)) s = a + c;
            if ((c < a) && (c < b)) s = a + b;
            TextBlockAnswer.Text = $"{s} ";
        }
    }
    }
}
