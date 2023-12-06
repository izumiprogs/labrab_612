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

namespace _227_Belozerov612
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

            int a = Convert.ToInt32(Rezult_a.Text);
            int b = Convert.ToInt32(Rezult_b.Text);
            int c = Convert.ToInt32(Rezult_c.Text);
            int[] nums = new int[3];
            nums[0] = a; nums[1] = b; nums[2] = c;
            int count1 = 0, count2 = 0;
            for (int i = 0; i < 3; i++)
                if (nums[i] < 0) count2++;
                else count1++;
            TextBlockAnswer.Text = $"положительных {count1}, отрицательных{count2} ";
        }

    }
}
