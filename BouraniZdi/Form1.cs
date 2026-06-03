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

        // proměnné pro kuličku
        int mintSouradniceX, mintSouradniceY;
        int mintPosunX, mintPosunY;
        const int cnVelikost=20;

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
            mobjKulicka=new clsKulicka();

            //init kulicky
            mintSouradniceX = mintSouradniceY = 100;
            mintPosunX = mintPosunY = 3;

            //nastavení timeru
            tmrVykresli.Interval = 10;
            tmrVykresli.Start();
        }
        //------------------------------------------
        // elapsed timer
        //------------------------------------------
        private void tmrVykresli_Tick(object sender, EventArgs e)
        {
            // vymazat kuličku
            mobjGrafika.FillEllipse(Brushes.White, mintSouradniceX, mintSouradniceY, cnVelikost, cnVelikost);

            //posunout kuličku
            mintSouradniceX = mintSouradniceX + mintPosunX;
            mintSouradniceY = mintSouradniceY + mintPosunY;

            //test kolize Y
            if ((mintSouradniceY + cnVelikost > pbPlatno.Height) ||
                    (mintSouradniceY < 0))
                mintPosunY=mintPosunY * (-1);

            //test kolize X
            if ((mintSouradniceX + cnVelikost > pbPlatno.Width) ||
                    (mintSouradniceX < 0)) 
                mintPosunX = mintPosunX * (-1);


            // vykreslit kuličku
            mobjGrafika.FillEllipse(Brushes.Blue, mintSouradniceX, mintSouradniceY, cnVelikost, cnVelikost);

        }
    }
}
