using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouraniZdi
{
    public partial class formHlavni : Form
    {
        //grafika pro kreslení
        Graphics mobjGrafika;

        //kulicka
        clsKulicka mobjKulicka;

        //balonky
        clsBalonek [] mobjBalonek;
        int cnPocetBalonku = 5;

        

        //------------------------------------------
        // konstruktor
        //------------------------------------------
        public formHlavni()
        {
            InitializeComponent();
        }

        //------------------------------------------
        // nahrání formu do paměti
        //------------------------------------------
        private void formHlavni_Load(object sender, EventArgs e)
        {
            //připojení objektu grafiky na picturebox
            mobjGrafika=pbPlatno.CreateGraphics();

            //vytvořit kuličku
            mobjKulicka=new clsKulicka(mobjGrafika, 100, 100);

            //vytvořit pole
            mobjBalonek = new clsBalonek[cnPocetBalonku];

            //vytvořit balonky
            for (int i = 0; i < cnPocetBalonku; i++)
            {
                mobjBalonek[i] = new clsBalonek(mobjGrafika, 10, 10);
            }
            
            //nastavení timeru
            tmrVykresli.Interval = 10;
            tmrVykresli.Start();
        }
        //------------------------------------------
        // elapsed timer
        //------------------------------------------
        private void tmrVykresli_Tick(object sender, EventArgs e)
        {
            //vykreselní kuličky
            mobjKulicka.PosunAVykresli();

            //vykreslení balonků
                       
            foreach (clsBalonek objBalonek in mobjBalonek)
            {
                objBalonek.VykresliSe();
            }
        }
    }
}
