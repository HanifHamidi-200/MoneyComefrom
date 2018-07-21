using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranscendenceDatabase
{
    public partial class fSub1 : Form
    {
        private List<cAimsLeaves> _db1 = new List<cAimsLeaves> { null, null, null, null, null, null, null, null, null, null };
        private int mnCount, mnItem;

        private void fUpdateDisplay()
        {
                String hCOLUMN;
                int nID;
            String sText;
            String sDescription;
            String sText2 = null;

            if (lstDatabase.Items.Count > 0)
            {
                do
                {
                    lstDatabase.Items.RemoveAt(0);
                } while (lstDatabase.Items.Count > 0);
            }

            for (int i = 1; i <= mnCount; i++)
            {
                hCOLUMN = _db1[i - 1].fGetCOLUMN();
                nID = _db1[i - 1].fGetID();
                sText = _db1[i - 1].fGetText();
                sDescription = _db1[i - 1].fGetDescription();
                sText2 = "COLUMN=" + hCOLUMN + " ID=" + Convert.ToString(nID) + " Text=" + sText + " Description=" + sDescription;
                lstDatabase.Items.Add(sText2);
            }
        }
        public fSub1()
        {
            InitializeComponent();
            mnCount = 0;
            mnItem = 0;
            fUpdateDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mnItem += 1;
            _db1[mnItem-1].fSet(txt1.Text, Convert.ToInt32(txt2.Text), txt3.Text, txt4.Text);
            fUpdateDisplay();
        }
    }
}
