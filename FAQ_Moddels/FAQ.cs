using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAQ_Moddels
{
    public class FAQ
    {
        private string eersteVraag;
        private string tweedevraag;
        private string derdeVraag;
        private string vierdeVraag;
        private string vijfdeVraag;
        private string zesdeVraag;
        private string zevendeVraag;

        public string ZevendeVraag
        {
            get { return zevendeVraag; }
            set { zevendeVraag = value; }
        }


        public string ZesdeVraag
        {
            get { return zesdeVraag; }
            set { zesdeVraag = value; }
        }


        public string VijfdeVraag
        {
            get { return vijfdeVraag; }
            set { vijfdeVraag = value; }
        }


        public string VierdeVraag
        {
            get { return vierdeVraag; }
            set { vierdeVraag = value; }
        }


        public string DerdeVraag
        {
            get { return derdeVraag; }
            set { derdeVraag = value; }
        }


        public string TWeedeVraag
        {
            get { return tweedevraag; }
            set { tweedevraag = value; }
        }


        public string EersteVraag
        {
            get { return eersteVraag; }
            set { eersteVraag = value; }
        }

    }
}
