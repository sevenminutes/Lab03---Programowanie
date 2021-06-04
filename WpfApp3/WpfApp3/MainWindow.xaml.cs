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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Suma_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(t1.Text); 
            int b = int.Parse(t2.Text);

            int c = a + b;


            t3.Text = $" Suma { a} + {b} =  {c}";
        }

        private void Różnica_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(t1.Text);
            int b = int.Parse(t2.Text);

            int c = a - b;


            t3.Text = $" różnica { a} - {b} =  {c}";
        }

        private void Iloczyn_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(t1.Text);
            int b = int.Parse(t2.Text);

            int c = a * b;


            t3.Text = $" Iloczyn {a} * {b} =  {c}";
        }

        private void iloraz_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(t1.Text);
            int b = int.Parse(t2.Text);

            int c = a / b;

            if (a == 0 || b == 0)
            {
                MessageBox.Show("Nie dziel przez zero! ");
                t3.Text = "Nie dziel przez zero!";

            }
            else
            {
                t3.Text = $" Iloraz to  to : { a} / {b} =  {c}";
            }


        }
    }
    }

