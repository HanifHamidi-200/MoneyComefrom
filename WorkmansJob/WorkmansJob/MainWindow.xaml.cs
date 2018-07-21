using System;
using System.Collections.Generic;
using System.IO;
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

namespace WorkmansJob
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<String> _data = new List<string> { null, null, null, null, null, null };

        private void fUpdateDisplay()
        {
            lblName1.Content = "NAME: " + _data[0];
            lblAge1.Content = "AGE: " + _data[1];
            lblContact1.Content = "CONTACT: " + _data[2];
            lblExpertisesector1.Content = "EXPERTISESECTOR: " + _data[3];
            lblQualifications1.Content = "QUALIFICATION: " + _data[4];
            lblBusiness1.Content = "BUSINESS: " + _data[5];

        }
        private void fSync()
        {
            txtName.Text = _data[0];
            txtAge.Text = _data[1];
            txtContact.Text = _data[2];
            txtExpertiseSector.Text = _data[3];
            txtQualifications.Text = _data[4];
            txtBusiness.Text = _data[5];

        }
        private void fReset()
        {
            for (int i = 1; i <= 6; i++)
            {
                _data[i - 1] = null;
            }
            txtName.Text = null;
            txtAge.Text = null;
            txtContact.Text = null;
            txtExpertiseSector.Text = null;
            txtQualifications.Text = null;
            txtBusiness.Text = null;
            fUpdateDisplay();
        }

        
        public MainWindow()
        {
            InitializeComponent();
            fReset();
            fSync();
        }

        private void btnCommit_Click(object sender, RoutedEventArgs e)
        {
            String sText = null;
            String sName = "save.txt";

            _data[0] = txtName.Text;
            _data[1] = txtAge.Text;
            _data[2] = txtContact.Text;
            _data[3] = txtExpertiseSector.Text;
            _data[4] = txtQualifications.Text;
            _data[5] = txtBusiness.Text;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
            {
                file.WriteLine("LIST");
                for (int i = 1; i <= 6; i++)
                {
                    sText = _data[i - 1];
                    file.WriteLine(sText);
                }
            }
            fUpdateDisplay();
        }

        private void btnGet_Click(object sender, RoutedEventArgs e)
        {
            String sName = "save.txt";
            String sLine;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {
                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    for (int i = 1; i <= 6; i++)
                    {
                        sLine = sr.ReadLine();
                        _data[i - 1] = sLine;
                    }
                    fUpdateDisplay();
                    fSync();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
                fReset();
                fSync();
            }

        }

        private void pic1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            fReset();
            fSync();
        }
    }
}
