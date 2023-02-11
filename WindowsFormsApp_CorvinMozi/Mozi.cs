using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp_CorvinMozi
{
    internal class Mozi
    {
        public List<Terem> termek = new List<Terem>();
        public Mozi(string forras)
        {
            try
            {
                using (StreamReader sr = new StreamReader(forras))
                {
                    while (!sr.EndOfStream)
                    {
                        string nev = sr.ReadLine();
                        Image nevadokep = Image.FromFile(nev.Split()[0] + ".jpg");
                        string[] sor = sr.ReadLine().Split(';');
                        int sorok = int.Parse(sor[0]);
                        int szekek = int.Parse(sor[1]);
                        char[,] ulesek = new char[sorok, szekek];
                        string line = "";
                        while ((line = sr.ReadLine()) != "" && line != null)
                        {
                            sor = line.Split(';');
                            ulesek[int.Parse(sor[0]) - 1, int.Parse(sor[1]) - 1] = sor[2][0];
                        }
                        termek.Add(new Terem(nev, sorok, szekek, ulesek, nevadokep));
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message + "\n\nA program leáll!");
                Environment.Exit(0);
            }
        }
        public void Save()
        {
            string saveName = "CorvinMozi.csv";
            string output = "backup_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";
            try
            {
                File.Copy(saveName, output, true);
                using (StreamWriter sw = new StreamWriter(saveName))
                {
                    foreach (Terem item in termek)
                    {
                        sw.WriteLine(item.Nev);
                        sw.WriteLine(string.Join(";", item.Sorok, item.Szekek));
                        for (int i = 0; i < item.Ulesek.GetLength(0); i++)
                        {
                            for (int j = 0; j < item.Ulesek.GetLength(1); j++)
                            {
                                if (item.Ulesek[i, j] != '\0')
                                {
                                    sw.WriteLine(string.Join(";", i + 1, j + 1, item.Ulesek[i, j]));
                                }
                            }
                        }
                        sw.WriteLine();
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message + "\nA mentés sikertelen!");
                return;
            }
            MessageBox.Show("Az adatok mentése sikeres!");
        }
    }
}
