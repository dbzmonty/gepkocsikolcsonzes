using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepkocsikolcsonzes
{
    public class Fajlkezeles
    {
        public List<Auto> Beolvasas()
        {
			List<Auto> autok = new List<Auto>();

			try
			{
				using (StreamReader sr = new StreamReader("jarmu.txt"))
				{
					while (sr.Peek() >= 0)
					{
						string str;
						string[] strArray;
						str = sr.ReadLine();
						strArray = str.Split(';');
												
						int fogyasztas = -1;
						bool ervenyesFogyasztas = int.TryParse(strArray[1], out fogyasztas);
						if (!ervenyesFogyasztas) continue;

						Auto currentAuto = new Auto();
						currentAuto.Rendszam = strArray[0];
						currentAuto.Fogyasztas = strArray[1];
						currentAuto.Marka = strArray[2];
                        
                        autok.Add(currentAuto);
                    }
				}

                return autok;
            }
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return autok;
            }
        }

		public void Kiiras(string Nev, string Marka, string Rendszam, string Fogyasztas, DateTime Datum, int Idotartam)
		{
			FileStream stream = null;

			try
			{
				stream = new FileStream("berles.txt", FileMode.Append);

				using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
				{
					writer.WriteLine("Bérlő neve: " + Nev);
					writer.WriteLine("Autó márkája: " + Marka);
					writer.WriteLine("Autó rendszáma: " + Rendszam);
					writer.WriteLine("Autó fogyasztása: {0} liter / 100km", Fogyasztas.ToString());
					writer.WriteLine("Bérlés dátuma: " + Datum.ToString("yyyy.MM.dd"));
					writer.WriteLine("Bérlés időtartama: {0} nap", Idotartam.ToString());
					writer.WriteLine("------------------------");

				}
			}
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
			finally
			{
                if (stream != null) stream.Dispose();
            }
		}
    }
}
