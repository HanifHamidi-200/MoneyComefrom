using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranscendenceDatabase
{
   
    class cAimsLeaves
    {
        private String mhCOLUMN;
        private int mnID;
        private String msText;
        private String msDescription;

        public void fSet(String hCOLUMN, int nID,String sText,String sDescription)
        {
            mhCOLUMN = hCOLUMN;
            mnID = nID;
            msText = sText;
            msDescription = sDescription;
        }

        public String fGetCOLUMN()
        {
            return mhCOLUMN;
        }
        public int fGetID()
        {
            return mnID;
        }
        public String fGetText()
        {
            return msText;
        }
        public String fGetDescription()
        {
            return msDescription;
        }
    }
}
