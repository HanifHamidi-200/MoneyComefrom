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

namespace OrderedArrays
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<String> _state = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _business = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _sector = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _techrevision = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private int mnCount;

        private void fUpdateItem(int nItem, String sText)
        {
            switch (nItem)
            {
                case 1:
                    lbl1.Content = sText;
                    break;
                case 2:
                    lbl2.Content = sText;
                    break;
                case 3:
                    lbl3.Content = sText;
                    break;
                case 4:
                    lbl4.Content = sText;
                    break;
                case 5:
                    lbl5.Content = sText;
                    break;
                case 6:
                    lbl6.Content = sText;
                    break;
                case 7:
                    lbl7.Content = sText;
                    break;
                case 8:
                    lbl8.Content = sText;
                    break;
                case 9:
                    lbl9.Content = sText;
                    break;
                case 10:
                    lbl10.Content = sText;
                    break;
                case 11:
                    lbl11.Content = sText;
                    break;
                case 12:
                    lbl12.Content = sText;
                    break;
                case 13:
                    lbl13.Content = sText;
                    break;
                case 14:
                    lbl14.Content = sText;
                    break;
                case 15:
                    lbl15.Content = sText;
                    break;
                case 16:
                    lbl16.Content = sText;
                    break;
                case 17:
                    lbl17.Content = sText;
                    break;
                case 18:
                    lbl18.Content = sText;
                    break;
                case 19:
                    lbl19.Content = sText;
                    break;
                case 20:
                    lbl20.Content = sText;
                    break;
            }
        }
        private void fUpdateDisplay()
        {
            String sText;

            for(int i = 1; i <= 20; i++)
            {
                sText = "[" + Convert.ToString(i) + "]";
                sText = sText + " State: " + _state[i - 1];
                sText = sText + " Business: " + _business[i - 1];
                sText = sText + " Sector: " + _sector[i - 1];
                sText = sText + " TechRevision: " + _techrevision[i - 1];
                fUpdateItem(i, sText);
            }

        }

        private void fGet()
        {
            String sName = "save.txt";
            int nCount = 0;
            String sLine;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {
                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    mnCount = Convert.ToInt32(sLine);
                    sLine = sr.ReadLine();
                    for (int i = 1; i <= mnCount; i++)
                    {
                        sLine = sr.ReadLine();
                        _state[i - 1] = sLine;
                        sLine = sr.ReadLine();
                        _business[i - 1] = sLine;
                        sLine = sr.ReadLine();
                        _sector[i - 1] = sLine;
                        sLine = sr.ReadLine();
                        _techrevision[i - 1] = sLine;
                    }
                 }
            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
                fReset();
            }

        }

        private void fReset()
        {
            mnCount = 0;
            for (int i = 1; i <= 20; i++)
            {
                _state[i - 1] = null;
                _business[i - 1] = null;
                _sector[i - 1] = null;
                _techrevision[i - 1] = null;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            fGet();
            fUpdateDisplay();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            mnCount += 1;
            if (mnCount > 20)
            {
                MessageBox.Show("Error!");
                return;
            }
            _state[mnCount - 1] = txtState.Text;
            _business[mnCount - 1] = txtBusiness.Text;
            _sector[mnCount - 1] = txtSector.Text;
            _techrevision[mnCount - 1] = txtTechRevision.Text;
            fUpdateDisplay();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            String sText = null;

            String sName = "save.txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
            {
                sText = Convert.ToString(mnCount);
                file.WriteLine(sText);
                file.WriteLine("LIST");
                for (int i = 1; i <= mnCount; i++)
                {
                    sText = _state[i-1];
                    file.WriteLine(sText);
                    sText = _business[i - 1];
                    file.WriteLine(sText);
                    sText = _sector[i - 1];
                    file.WriteLine(sText);
                    sText = _techrevision[i - 1];
                    file.WriteLine(sText);
                }
                    }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            fReset();
        }

        private void pic1_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
