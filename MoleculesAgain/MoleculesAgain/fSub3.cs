using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoleculesAgain
{
    public partial class fSub3 : Form
    {
        private List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Bcol1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Bcol2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Bcol3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Bcol4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Bcol5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Bcol6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Bcol7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Bcol8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Brotate1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Brotate2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Brotate3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Brotate4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Brotate5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Brotate6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Brotate7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Brotate8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private int nNumber;

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F ballmolecule.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F casings.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F correspondingcastings1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F correspondingcastings2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F field1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F field2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F spark_clothes.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F spark_equipment.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F spark_food.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F spark_machines.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            
            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                case 5:
                    _pic2 = picture5;
                    break;
                case 6:
                    _pic2 = picture6;
                    break;
                case 7:
                    _pic2 = picture7;
                    break;
                case 8:
                    _pic2 = picture8;
                    break;
                case 9:
                    _pic2 = picture9;
                    break;
                case 10:
                    _pic2 = picture10;
                    break;
                default:
                    _pic2 = picture11;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private void fStick(int nBoard,int nCol, int nRow, int nType, int nRotate)
        {
            if (nBoard == 1)
            {
                switch (nCol)
                {
                    case 1:
                        _col1[nRow - 1] = nType;
                        _rotate1[nRow - 1] = nRotate;
                        break;
                    case 2:
                        _col2[nRow - 1] = nType;
                        _rotate2[nRow - 1] = nRotate;
                        break;
                    case 3:
                        _col3[nRow - 1] = nType;
                        _rotate3[nRow - 1] = nRotate;
                        break;
                    case 4:
                        _col4[nRow - 1] = nType;
                        _rotate4[nRow - 1] = nRotate;
                        break;
                    case 5:
                        _col5[nRow - 1] = nType;
                        _rotate5[nRow - 1] = nRotate;
                        break;
                    case 6:
                        _col6[nRow - 1] = nType;
                        _rotate6[nRow - 1] = nRotate;
                        break;
                    case 7:
                        _col7[nRow - 1] = nType;
                        _rotate7[nRow - 1] = nRotate;
                        break;
                    default:
                        _col8[nRow - 1] = nType;
                        _rotate8[nRow - 1] = nRotate;
                        break;
                }
            }
            else
            {
                switch (nCol)
                {
                    case 1:
                        _Bcol1[nRow - 1] = nType;
                        _Brotate1[nRow - 1] = nRotate;
                        break;
                    case 2:
                        _Bcol2[nRow - 1] = nType;
                        _Brotate2[nRow - 1] = nRotate;
                        break;
                    case 3:
                        _Bcol3[nRow - 1] = nType;
                        _Brotate3[nRow - 1] = nRotate;
                        break;
                    case 4:
                        _Bcol4[nRow - 1] = nType;
                        _Brotate4[nRow - 1] = nRotate;
                        break;
                    case 5:
                        _Bcol5[nRow - 1] = nType;
                        _Brotate5[nRow - 1] = nRotate;
                        break;
                    case 6:
                        _Bcol6[nRow - 1] = nType;
                        _Brotate6[nRow - 1] = nRotate;
                        break;
                    case 7:
                        _Bcol7[nRow - 1] = nType;
                        _Brotate7[nRow - 1] = nRotate;
                        break;
                    default:
                        _Bcol8[nRow - 1] = nType;
                        _Brotate8[nRow - 1] = nRotate;
                        break;
                }
            }
        }
             

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    nNumber = rnd1.Next(1, 10);
                    if (nNumber <= 5)
                    {
                        fStick(1, i, j, 5, rnd1.Next(1, 5));
                    }
                    else
                    {
                        fStick(1, i, j, 6, rnd1.Next(1, 5));
                    }
                }
            }

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                         fStick(2, i, j, 2, rnd1.Next(1, 5));
                     }
            }
        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate;

            nType = _col1[0];
            nRotate = _rotate1[0];
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = _col1[1];
            nRotate = _rotate1[1];
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = _col1[2];
            nRotate = _rotate1[2];
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = _col1[3];
            nRotate = _rotate1[3];
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = _col1[4];
            nRotate = _rotate1[4];
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = _col1[5];
            nRotate = _rotate1[5];
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = _col1[6];
            nRotate = _rotate1[6];
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = _col1[7];
            nRotate = _rotate1[7];
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;

            nType = _col2[0];
            nRotate = _rotate2[0];
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = _col2[1];
            nRotate = _rotate2[1];
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = _col2[2];
            nRotate = _rotate2[2];
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = _col2[3];
            nRotate = _rotate2[3];
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = _col2[4];
            nRotate = _rotate2[4];
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = _col2[5];
            nRotate = _rotate2[5];
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = _col2[6];
            nRotate = _rotate2[6];
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = _col2[7];
            nRotate = _rotate2[7];
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;

            nType = _col3[0];
            nRotate = _rotate3[0];
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = _col3[1];
            nRotate = _rotate3[1];
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = _col3[2];
            nRotate = _rotate3[2];
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = _col3[3];
            nRotate = _rotate3[3];
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = _col3[4];
            nRotate = _rotate3[4];
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = _col3[5];
            nRotate = _rotate3[5];
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = _col3[6];
            nRotate = _rotate3[6];
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = _col3[7];
            nRotate = _rotate3[7];
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;

            nType = _col4[0];
            nRotate = _rotate4[0];
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = _col4[1];
            nRotate = _rotate4[1];
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = _col4[2];
            nRotate = _rotate4[2];
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = _col4[3];
            nRotate = _rotate4[3];
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = _col4[4];
            nRotate = _rotate4[4];
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = _col4[5];
            nRotate = _rotate4[5];
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = _col4[6];
            nRotate = _rotate4[6];
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = _col4[7];
            nRotate = _rotate4[7];
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;

            nType = _col5[0];
            nRotate = _rotate5[0];
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = _col5[1];
            nRotate = _rotate5[1];
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = _col5[2];
            nRotate = _rotate5[2];
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = _col5[3];
            nRotate = _rotate5[3];
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = _col5[4];
            nRotate = _rotate5[4];
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = _col5[5];
            nRotate = _rotate5[5];
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = _col5[6];
            nRotate = _rotate5[6];
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = _col5[7];
            nRotate = _rotate5[7];
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;

            nType = _col6[0];
            nRotate = _rotate6[0];
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = _col6[1];
            nRotate = _rotate6[1];
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = _col6[2];
            nRotate = _rotate6[2];
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = _col6[3];
            nRotate = _rotate6[3];
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = _col6[4];
            nRotate = _rotate6[4];
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = _col6[5];
            nRotate = _rotate6[5];
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;
            nType = _col6[6];
            nRotate = _rotate6[6];
            fPeek(nType, nRotate, ref _pic);
            pic67.Image = _pic.Image;
            nType = _col6[7];
            nRotate = _rotate6[7];
            fPeek(nType, nRotate, ref _pic);
            pic68.Image = _pic.Image;

            nType = _col7[0];
            nRotate = _rotate7[0];
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = _col7[1];
            nRotate = _rotate7[1];
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = _col7[2];
            nRotate = _rotate7[2];
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = _col7[3];
            nRotate = _rotate7[3];
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;
            nType = _col7[4];
            nRotate = _rotate7[4];
            fPeek(nType, nRotate, ref _pic);
            pic75.Image = _pic.Image;
            nType = _col7[5];
            nRotate = _rotate7[5];
            fPeek(nType, nRotate, ref _pic);
            pic76.Image = _pic.Image;
            nType = _col7[6];
            nRotate = _rotate7[6];
            fPeek(nType, nRotate, ref _pic);
            pic77.Image = _pic.Image;
            nType = _col7[7];
            nRotate = _rotate7[7];
            fPeek(nType, nRotate, ref _pic);
            pic78.Image = _pic.Image;

            nType = _col8[0];
            nRotate = _rotate8[0];
            fPeek(nType, nRotate, ref _pic);
            pic81.Image = _pic.Image;
            nType = _col8[1];
            nRotate = _rotate8[1];
            fPeek(nType, nRotate, ref _pic);
            pic82.Image = _pic.Image;
            nType = _col8[2];
            nRotate = _rotate8[2];
            fPeek(nType, nRotate, ref _pic);
            pic83.Image = _pic.Image;
            nType = _col8[3];
            nRotate = _rotate8[3];
            fPeek(nType, nRotate, ref _pic);
            pic84.Image = _pic.Image;
            nType = _col8[4];
            nRotate = _rotate8[4];
            fPeek(nType, nRotate, ref _pic);
            pic85.Image = _pic.Image;
            nType = _col8[5];
            nRotate = _rotate8[5];
            fPeek(nType, nRotate, ref _pic);
            pic86.Image = _pic.Image;
            nType = _col8[6];
            nRotate = _rotate8[6];
            fPeek(nType, nRotate, ref _pic);
            pic87.Image = _pic.Image;
            nType = _col8[7];
            nRotate = _rotate8[7];
            fPeek(nType, nRotate, ref _pic);
            pic88.Image = _pic.Image;

            //B

            nType = _Bcol1[0];
            nRotate = _Brotate1[0];
            fPeek(nType, nRotate, ref _pic);
            picb11.Image = _pic.Image;
            nType = _Bcol1[1];
            nRotate = _Brotate1[1];
            fPeek(nType, nRotate, ref _pic);
            picb12.Image = _pic.Image;
            nType = _Bcol1[2];
            nRotate = _Brotate1[2];
            fPeek(nType, nRotate, ref _pic);
            picb13.Image = _pic.Image;
            nType = _Bcol1[3];
            nRotate = _Brotate1[3];
            fPeek(nType, nRotate, ref _pic);
            picb14.Image = _pic.Image;
            nType = _Bcol1[4];
            nRotate = _Brotate1[4];
            fPeek(nType, nRotate, ref _pic);
            picb15.Image = _pic.Image;
            nType = _Bcol1[5];
            nRotate = _Brotate1[5];
            fPeek(nType, nRotate, ref _pic);
            picb16.Image = _pic.Image;
            nType = _Bcol1[6];
            nRotate = _Brotate1[6];
            fPeek(nType, nRotate, ref _pic);
            picb17.Image = _pic.Image;
            nType = _Bcol1[7];
            nRotate = _Brotate1[7];
            fPeek(nType, nRotate, ref _pic);
            picb18.Image = _pic.Image;

            nType = _Bcol2[0];
            nRotate = _Brotate2[0];
            fPeek(nType, nRotate, ref _pic);
            picb21.Image = _pic.Image;
            nType = _Bcol2[1];
            nRotate = _Brotate2[1];
            fPeek(nType, nRotate, ref _pic);
            picb22.Image = _pic.Image;
            nType = _Bcol2[2];
            nRotate = _Brotate2[2];
            fPeek(nType, nRotate, ref _pic);
            picb23.Image = _pic.Image;
            nType = _Bcol2[3];
            nRotate = _Brotate2[3];
            fPeek(nType, nRotate, ref _pic);
            picb24.Image = _pic.Image;
            nType = _Bcol2[4];
            nRotate = _Brotate2[4];
            fPeek(nType, nRotate, ref _pic);
            picb25.Image = _pic.Image;
            nType = _Bcol2[5];
            nRotate = _Brotate2[5];
            fPeek(nType, nRotate, ref _pic);
            picb26.Image = _pic.Image;
            nType = _Bcol2[6];
            nRotate = _Brotate2[6];
            fPeek(nType, nRotate, ref _pic);
            picb27.Image = _pic.Image;
            nType = _Bcol2[7];
            nRotate = _Brotate2[7];
            fPeek(nType, nRotate, ref _pic);
            picb28.Image = _pic.Image;

            nType = _Bcol3[0];
            nRotate = _Brotate3[0];
            fPeek(nType, nRotate, ref _pic);
            picb31.Image = _pic.Image;
            nType = _Bcol3[1];
            nRotate = _Brotate3[1];
            fPeek(nType, nRotate, ref _pic);
            picb32.Image = _pic.Image;
            nType = _Bcol3[2];
            nRotate = _Brotate3[2];
            fPeek(nType, nRotate, ref _pic);
            picb33.Image = _pic.Image;
            nType = _Bcol3[3];
            nRotate = _Brotate3[3];
            fPeek(nType, nRotate, ref _pic);
            picb34.Image = _pic.Image;
            nType = _Bcol3[4];
            nRotate = _Brotate3[4];
            fPeek(nType, nRotate, ref _pic);
            picb35.Image = _pic.Image;
            nType = _Bcol3[5];
            nRotate = _Brotate3[5];
            fPeek(nType, nRotate, ref _pic);
            picb36.Image = _pic.Image;
            nType = _Bcol3[6];
            nRotate = _Brotate3[6];
            fPeek(nType, nRotate, ref _pic);
            picb37.Image = _pic.Image;
            nType = _Bcol3[7];
            nRotate = _Brotate3[7];
            fPeek(nType, nRotate, ref _pic);
            picb38.Image = _pic.Image;

            nType = _Bcol4[0];
            nRotate = _Brotate4[0];
            fPeek(nType, nRotate, ref _pic);
            picb41.Image = _pic.Image;
            nType = _Bcol4[1];
            nRotate = _Brotate4[1];
            fPeek(nType, nRotate, ref _pic);
            picb42.Image = _pic.Image;
            nType = _Bcol4[2];
            nRotate = _Brotate4[2];
            fPeek(nType, nRotate, ref _pic);
            picb43.Image = _pic.Image;
            nType = _Bcol4[3];
            nRotate = _Brotate4[3];
            fPeek(nType, nRotate, ref _pic);
            picb44.Image = _pic.Image;
            nType = _Bcol4[4];
            nRotate = _Brotate4[4];
            fPeek(nType, nRotate, ref _pic);
            picb45.Image = _pic.Image;
            nType = _Bcol4[5];
            nRotate = _Brotate4[5];
            fPeek(nType, nRotate, ref _pic);
            picb46.Image = _pic.Image;
            nType = _Bcol4[6];
            nRotate = _Brotate4[6];
            fPeek(nType, nRotate, ref _pic);
            picb47.Image = _pic.Image;
            nType = _Bcol4[7];
            nRotate = _Brotate4[7];
            fPeek(nType, nRotate, ref _pic);
            picb48.Image = _pic.Image;

            nType = _Bcol5[0];
            nRotate = _Brotate5[0];
            fPeek(nType, nRotate, ref _pic);
            picb51.Image = _pic.Image;
            nType = _Bcol5[1];
            nRotate = _Brotate5[1];
            fPeek(nType, nRotate, ref _pic);
            picb52.Image = _pic.Image;
            nType = _Bcol5[2];
            nRotate = _Brotate5[2];
            fPeek(nType, nRotate, ref _pic);
            picb53.Image = _pic.Image;
            nType = _Bcol5[3];
            nRotate = _Brotate5[3];
            fPeek(nType, nRotate, ref _pic);
            picb54.Image = _pic.Image;
            nType = _Bcol5[4];
            nRotate = _Brotate5[4];
            fPeek(nType, nRotate, ref _pic);
            picb55.Image = _pic.Image;
            nType = _Bcol5[5];
            nRotate = _Brotate5[5];
            fPeek(nType, nRotate, ref _pic);
            picb56.Image = _pic.Image;
            nType = _Bcol5[6];
            nRotate = _Brotate5[6];
            fPeek(nType, nRotate, ref _pic);
            picb57.Image = _pic.Image;
            nType = _Bcol5[7];
            nRotate = _Brotate5[7];
            fPeek(nType, nRotate, ref _pic);
            picb58.Image = _pic.Image;

            nType = _Bcol6[0];
            nRotate = _Brotate6[0];
            fPeek(nType, nRotate, ref _pic);
            picb61.Image = _pic.Image;
            nType = _Bcol6[1];
            nRotate = _Brotate6[1];
            fPeek(nType, nRotate, ref _pic);
            picb62.Image = _pic.Image;
            nType = _Bcol6[2];
            nRotate = _Brotate6[2];
            fPeek(nType, nRotate, ref _pic);
            picb63.Image = _pic.Image;
            nType = _Bcol6[3];
            nRotate = _Brotate6[3];
            fPeek(nType, nRotate, ref _pic);
            picb64.Image = _pic.Image;
            nType = _Bcol6[4];
            nRotate = _Brotate6[4];
            fPeek(nType, nRotate, ref _pic);
            picb65.Image = _pic.Image;
            nType = _Bcol6[5];
            nRotate = _Brotate6[5];
            fPeek(nType, nRotate, ref _pic);
            picb66.Image = _pic.Image;
            nType = _Bcol6[6];
            nRotate = _Brotate6[6];
            fPeek(nType, nRotate, ref _pic);
            picb67.Image = _pic.Image;
            nType = _Bcol6[7];
            nRotate = _Brotate6[7];
            fPeek(nType, nRotate, ref _pic);
            picb68.Image = _pic.Image;

            nType = _Bcol7[0];
            nRotate = _Brotate7[0];
            fPeek(nType, nRotate, ref _pic);
            picb71.Image = _pic.Image;
            nType = _Bcol7[1];
            nRotate = _Brotate7[1];
            fPeek(nType, nRotate, ref _pic);
            picb72.Image = _pic.Image;
            nType = _Bcol7[2];
            nRotate = _Brotate7[2];
            fPeek(nType, nRotate, ref _pic);
            picb73.Image = _pic.Image;
            nType = _Bcol7[3];
            nRotate = _Brotate7[3];
            fPeek(nType, nRotate, ref _pic);
            picb74.Image = _pic.Image;
            nType = _Bcol7[4];
            nRotate = _Brotate7[4];
            fPeek(nType, nRotate, ref _pic);
            picb75.Image = _pic.Image;
            nType = _Bcol7[5];
            nRotate = _Brotate7[5];
            fPeek(nType, nRotate, ref _pic);
            picb76.Image = _pic.Image;
            nType = _Bcol7[6];
            nRotate = _Brotate7[6];
            fPeek(nType, nRotate, ref _pic);
            picb77.Image = _pic.Image;
            nType = _Bcol7[7];
            nRotate = _Brotate7[7];
            fPeek(nType, nRotate, ref _pic);
            picb78.Image = _pic.Image;

            nType = _Bcol8[0];
            nRotate = _Brotate8[0];
            fPeek(nType, nRotate, ref _pic);
            picb81.Image = _pic.Image;
            nType = _Bcol8[1];
            nRotate = _Brotate8[1];
            fPeek(nType, nRotate, ref _pic);
            picb82.Image = _pic.Image;
            nType = _Bcol8[2];
            nRotate = _Brotate8[2];
            fPeek(nType, nRotate, ref _pic);
            picb83.Image = _pic.Image;
            nType = _Bcol8[3];
            nRotate = _Brotate8[3];
            fPeek(nType, nRotate, ref _pic);
            picb84.Image = _pic.Image;
            nType = _Bcol8[4];
            nRotate = _Brotate8[4];
            fPeek(nType, nRotate, ref _pic);
            picb85.Image = _pic.Image;
            nType = _Bcol8[5];
            nRotate = _Brotate8[5];
            fPeek(nType, nRotate, ref _pic);
            picb86.Image = _pic.Image;
            nType = _Bcol8[6];
            nRotate = _Brotate8[6];
            fPeek(nType, nRotate, ref _pic);
            picb87.Image = _pic.Image;
            nType = _Bcol8[7];
            nRotate = _Brotate8[7];
            fPeek(nType, nRotate, ref _pic);
            picb88.Image = _pic.Image;

        }

        public fSub3()
        {
            InitializeComponent();
        }

        private void fSub3_Load(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();

        }
    }
}
