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

namespace Assets
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int mnItem;
        private List<int> _initdata = new List<int> { 0, 0, 0 };

        private void fReset()
        {
            Random rnd1 = new Random();

            mnItem = 1;
            for (int i = 1; i <= 3; i++)
            {
                _initdata[i - 1] = rnd1.Next(6, 201);
            }

            txtEdit.Text = null;
            lbl1.Content = Convert.ToString(_initdata[0]) + " cows";
            lbl2.Content = Convert.ToString(_initdata[1]) + " sheep";
            lbl3.Content = Convert.ToString(_initdata[2]) + " cows";

        }
        private void fUpdateDisplay()
        {
            switch (mnItem)
            {
                case 1:
                    lbl1.Content = txtEdit.Text;
                    break;
                case 2:
                    lbl2.Content = txtEdit.Text;
                    break;
                default:
                    lbl3.Content = txtEdit.Text;
                    break;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            fReset();
          }

        private void lbl1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mnItem = 1;
            txtEdit.Text = (String)lbl1.Content;
        }

        private void lbl2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mnItem = 2;
            txtEdit.Text = (String)lbl2.Content;
        }

        private void lbl3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mnItem = 3;
            txtEdit.Text = (String)lbl3.Content;
        }

        private void btnEdit_MouseUp(object sender, MouseButtonEventArgs e)
        {
          }

        private void pic1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            fReset();
        }

        private void btnEdit_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fUpdateDisplay();
            txtEdit.Text = null;

        }
    }
}
