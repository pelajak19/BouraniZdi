using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouraniZdi
{
    internal class clsKulicka
    {
        //grafika pro kreslení
        Graphics mobjGrafika;

        // proměnné pro kuličku
        int mintSouradniceX, mintSouradniceY;
        int mintPosunX, mintPosunY;
        const int cnVelikost = 20;

        // načtení souřadnice X
        public int intX
        {
            get { return mintSouradniceX; }
        }

        // načtení souřadnice Y
        public int intY
        {
            get { return mintSouradniceY; }
        }

        //------------------------------------------
        // konstruktor
        //------------------------------------------
        public clsKulicka(Graphics objGrafika, int intX, int intY) 
        {
            //init kulicky
            mobjGrafika = objGrafika;
            mintSouradniceX = intX;
            mintSouradniceY = intY;
            mintPosunX = mintPosunY = 3;
        }

        //------------------------------------------
        // posunutí a vykreselní kuličky
        //------------------------------------------
        public void PosunAVykresli()
        {
            // vymazat kuličku
            mobjGrafika.FillEllipse(Brushes.White, mintSouradniceX, mintSouradniceY, cnVelikost, cnVelikost);

            //posunout kuličku
            mintSouradniceX = mintSouradniceX + mintPosunX;
            mintSouradniceY = mintSouradniceY + mintPosunY;

            //test kolize Y
            if ((mintSouradniceY + cnVelikost > mobjGrafika.VisibleClipBounds.Height) ||
                    (mintSouradniceY < 0))
                mintPosunY = mintPosunY * (-1);

            //test kolize X
            if ((mintSouradniceX + cnVelikost > mobjGrafika.VisibleClipBounds.Width) ||
                    (mintSouradniceX < 0))
                mintPosunX = mintPosunX * (-1);


            // vykreslit kuličku
            mobjGrafika.FillEllipse(Brushes.Teal, mintSouradniceX, mintSouradniceY, cnVelikost, cnVelikost);
        }
    }
}
