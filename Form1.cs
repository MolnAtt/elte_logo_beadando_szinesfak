using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		void FELADAT()
		{

			using (new Vastagság(5))
			{
				for (int i = 0; i <= 0; i++)
				{
					Metszett(i, 100);
					jobbralopvaoldalaz(120);
				}
				Metszett(7, 100);
			}



		}

        private void jobbralopvaoldalaz(double ennyit)
        {
            using (new Rajzol(false))
            {
				using (new Átmenetileg(Jobbra, 90))
				{
					Előre(ennyit);
				}
            }
        }

        Color milyen_szin_legyen(int i) => i <= 1 ? Color.ForestGreen : (i == 2 ? Color.DarkGreen : Color.RosyBrown);
        void Fa(int szint, double méret)
        {
			if (szint > 0)
			{
				using (new Vastagság(2+szint / 2))
				{
					using (new Szín(milyen_szin_legyen(szint)))
					{
						Előre(méret);
						using (new Átmenetileg(Balra, 30))
							Fa(szint - 1, .5 * méret);
						using (new Átmenetileg(Jobbra, 30))
							Fa(szint - 1, .5 * méret);
						Fa(szint - 1, .66 * méret);
						Hátra(méret);
					}
				}
			}
		}

        void Metszett(int szint, double méret)
        {
			if (szint > 0)
			{
				using (new Vastagság(2+szint / 2))
				{
					using (new Szín(milyen_szin_legyen(szint)))
					{
						Előre(méret);
                        if (Irány <= 180-30)
							using (new Átmenetileg(Balra, 30))
								Metszett(szint - 1, .5 * méret);
						if (Irány >= 30)
							using (new Átmenetileg(Jobbra, 30))
								Metszett(szint - 1, .5 * méret);
						Metszett(szint - 1, .66 * méret);
						Hátra(méret);
					}
				}
			}
		}

        

	}
}
