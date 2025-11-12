using Black_Jack.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack.Servicios
{


    public class CartasService()
    {
        ArrayList CC = new ArrayList();
        ArrayList CD = new ArrayList();
        ArrayList CT = new ArrayList();
        ArrayList CP = new ArrayList();
        public void GenerarCartas()
        {
            for (int i = 1; i < 14; i++)
            {
                if (i > 9)
                {
                    Cartas carta = new Cartas(i,10, "♥");
                    CC.Add(carta);
                }
                else
                {
                    Cartas carta = new Cartas(i,i, "♥");
                    CC.Add(carta);
                }
            }

            for (int i = 1; i < 14; i++)
            {
                if (i > 9)
                {
                    Cartas carta = new Cartas(i,10, "♦");
                    CD.Add(carta);
                }
                else
                {
                    Cartas carta = new Cartas(i, i, "♦");
                    CD.Add(carta);
                }
            }

            for (int i = 1; i < 14; i++)
            {
                if (i > 9)
                {
                    Cartas carta = new Cartas(i, 10, "♣");
                    CT.Add(carta);
                }
                else
                {
                    Cartas carta = new Cartas(i, i, "♣");
                    CT.Add(carta);
                }
            }

            for (int i = 1; i < 14; i++)
            {
                if (i > 9)
                {
                    Cartas carta = new Cartas(i, 10, "♠");
                    CP.Add(carta);
                }
                else
                {
                    Cartas carta = new Cartas(i, i, "♠");
                    CP.Add(carta);
                }
            }
        }

        public Cartas SacarCarta()
        {
            Random Rvalor = new Random();
            Random Rpalo = new Random();
           

            int palo = int.Parse(Rpalo.Next(1, 5).ToString());
            int valor = int.Parse(Rvalor.Next(0, 13).ToString());

            switch (palo)
            {
                case 1:
                    Cartas carta = (Cartas)CC[valor];
                    return carta; 
                case 2:
                    Cartas carta2 = (Cartas)CD[valor];
                    return carta2;
                case 3:
                    Cartas carta3 = (Cartas)CT[valor];
                    return carta3;
                case 4:
                    Cartas carta4 = (Cartas)CP[valor];
                    return carta4;
            }

            return null;
        }
    }
}
