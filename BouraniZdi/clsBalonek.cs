using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouraniZdi
{

    internal class clsBalonek
    {
        //grafika pro kreslení
        Graphics mobjGrafika;

        // proměnné pro balonky
        int mintSouradniceX, mintSouradniceY;
        const int cnVelikost = 50;


        //------------------------------------------
        // konstruktor
        //------------------------------------------
        public clsBalonek(Graphics objGrafika, int intX, int intY)
        {
            //init balonku
            mobjGrafika = objGrafika;
            mintSouradniceX = intX;
            mintSouradniceY = intY;
        }

        //------------------------------------------
        // vykresli se
        //------------------------------------------
        public void VykresliSe()
        {
            mobjGrafika.DrawEllipse(Pens.Green, mintSouradniceX, mintSouradniceY, cnVelikost, cnVelikost);
        }
    }
}
