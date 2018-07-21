using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace level234
{
    public partial class Form1 : Form
    {
        private int mnLength = 5;
        private String msRowA,msRowB;
        private int mnSide, mnNumber;
        private int nNumber;
        
        private void fReset()
        {
            Random rnd1 = new Random();
            nNumber = rnd1.Next(1, 10);
            String sLetter;

            if (lstProgress.Items.Count > 0)
            {
                do
                {
                    lstProgress.Items.RemoveAt(0);
                } while (lstProgress.Items.Count > 0);
            }

            msRowA = null;
            msRowB = null;
            for (int i = 1; i <= mnLength; i++)
            {
                sLetter = Convert.ToString(i);
                if (sLetter.Length == 1)
                {
                    sLetter = sLetter + " ";
                }
                msRowA = msRowA + sLetter;
                msRowB = msRowB + sLetter;
            }

            mnNumber = rnd1.Next(1, mnLength + 1);
            if (nNumber <= 5)
            {
                mnSide = 1;
                if (mnNumber == 1)
                {
                    msRowA = msRowA.Substring(2, mnLength - 2);
                }
                else
                {
                    msRowA=msRowA.Substring(0,(mnNumber*2)-2)+msRowA.Substring(mnNumber*2,( mnLength - mnNumber)*2);
                }
            }
            else
            {
                mnSide = 2;
                if (mnNumber == 1)
                {
                    msRowB = msRowB.Substring(2, mnLength - 2);
                }
                else
                {
                    msRowB = msRowB.Substring(0, (mnNumber * 2) - 2) + msRowB.Substring(mnNumber*2, (mnLength - mnNumber) * 2);
                }
            }
            fPrint();
        }

        private void fPrint()
        {
            String sText = null;

            if (mnSide == 1)
            {
                sText = Convert.ToString(mnNumber) + "A";
            }
            else
            {
                sText = Convert.ToString(mnNumber) + "B";
            }
            lstProgress.Items.Add(sText);
        }

        private void fPrintOpposite()
        {
            String sText = null;

            if (mnSide == 1)
            {
                sText = Convert.ToString(mnNumber) + "A (OPP)";
            }
            else
            {
                sText = Convert.ToString(mnNumber) + "B (OPP)";
            }
            lstProgress.Items.Add(sText);
        }

        private void fPrintCancel()
        {
            String sText = "OPP - CANCEL";
            lstProgress.Items.Add(sText);
        }

        private bool fPresent(String sNumber,int nSide,ref int nPos)
        {
            int nLength;
            String sLeft;
            String sCompare;

            if (nSide == 1)
            {
                sLeft = msRowA;
            }
            else
            {
                sLeft = msRowB;
            }
            nLength = sLeft.Length / 2;
            for (int i = 1; i <= nLength; i++)
            {
                sCompare = sLeft.Substring(i * 2 - 2, 2);
                if (sCompare == sNumber)
                {
                    nPos = i;
                    return true;
                }
            }

            return false;
        }

        private void fGo()
        {
            Random rnd1 = new Random();
            String sLeft;
            int nLength,nPos=0;
            String sLetter;
            nNumber = rnd1.Next(1, 10);
            String sTwo;
            bool bPresent = false;

            if (nNumber <= 2)
            {
                sTwo = Convert.ToString(mnNumber);
                if (sTwo.Length == 1)
                {
                    sTwo = sTwo + " ";
                }
                if (mnSide == 1)
                {
                    bPresent = fPresent(sTwo, 2,ref nPos);
                }
                else
                {
                    bPresent = fPresent(sTwo, 1,ref nPos);
                }
                if (bPresent)
                {
                    if (mnSide == 1)
                    {
                        mnSide = 2;
                        nLength = msRowB.Length / 2;
                    }
                    else
                    {
                        mnSide = 1;
                        nLength = msRowA.Length / 2;
                    }

                    if (mnSide == 1)
                    {
                        if (nPos == 1)
                        {
                            msRowA = msRowA.Substring(2, nLength - 2);
                        }
                        else
                        {
                            msRowA = msRowA.Substring(0, (nPos *2)-2) + msRowA.Substring(nPos*2, (nLength - nPos)*2);
                        }
                    }
                    else
                    {
                        if (nPos == 1)
                        {
                            msRowB = msRowB.Substring(2, nLength - 2);
                        }
                        else
                        {
                            msRowB = msRowB.Substring(0, (nPos*2) - 2) + msRowB.Substring(nPos * 2, (nLength - nPos) * 2);
                        }
                    }
                    fPrintOpposite();
                }
            }
            else
            {


                if (mnSide == 1)
                {
                    sLeft = msRowA;
                }
                else
                {
                    sLeft = msRowB;
                }
                nLength = sLeft.Length/2;
                nPos = rnd1.Next(1, nLength + 1);
                sLetter = sLeft.Substring(nPos - 1, 1);
                mnNumber = Convert.ToInt32(sLetter);
                fPrint();

                if (mnSide == 1)
                {
                    if (nPos == 1)
                    {
                        msRowA = msRowA.Substring(2, nLength - 2);
                    }
                    else
                    {
                        msRowA = msRowA.Substring(0,( nPos*2) - 2) + msRowA.Substring(nPos * 2, (nLength - nPos) * 2);
                    }
                }
                else
                {
                    if (nPos == 1)
                    {
                        msRowB = msRowB.Substring(2, nLength - 2);
                    }
                    else
                    {
                        msRowB = msRowB.Substring(0,( nPos *2)- 2) + msRowB.Substring(nPos * 2, (nLength - nPos) * 2);
                    }
                }
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            fGo();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
