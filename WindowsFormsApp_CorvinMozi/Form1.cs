using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_CorvinMozi
{
    public partial class Form1 : Form
    {
        Mozi CorvinMozi = new Mozi("CorvinMozi.csv");
        Image[] kepek = new Image[] { Image.FromFile("ures.png"), Image.FromFile("gyerek.png"), Image.FromFile("felnott.png") };
        int terem = 0;
        readonly int jegyKepMerete = 30;
        public Form1()
        {
            InitializeComponent();
        }
        void TeremUpdate()
        {
            this.Text = CorvinMozi.termek[terem].Nev + " terem";
            pictureBox_teremKep.Image = CorvinMozi.termek[terem].Nevadokep;
            panel_jegyek.Controls.Clear();

            for (int i = 0; i < CorvinMozi.termek[terem].Sorok; i++)
            {
                for (int j = 0; j < CorvinMozi.termek[terem].Szekek; j++)
                {
                    PictureBox button = new PictureBox();
                    button.SetBounds(j * jegyKepMerete, i * jegyKepMerete, jegyKepMerete, jegyKepMerete);
                    button.Padding = new Padding(3);
                    switch (CorvinMozi.termek[terem].Ulesek[i, j])
                    {
                        case 'F':
                            button.Image = kepek[2];
                            break;
                        case 'D':
                            button.Image = kepek[1];
                            break;
                        default:
                            button.Image = kepek[0];
                            break;
                    }
                    button.SizeMode = PictureBoxSizeMode.StretchImage;

                    int x = i;
                    int y = j;
                    button.Click += (e, o) =>
                    {
                        switch (CorvinMozi.termek[terem].Ulesek[x, y])
                        {
                            case 'F':
                                CorvinMozi.termek[terem].Ulesek[x, y] = '0';
                                break;
                            case 'D':
                                CorvinMozi.termek[terem].Ulesek[x, y] = 'F';
                                break;
                            default:
                                CorvinMozi.termek[terem].Ulesek[x, y] = 'D';
                                break;
                        }
                        TeremUpdate();
                    };
                    panel_jegyek.Controls.Add(button);
                }
            }
            if (terem == 0)
            {
                button_left.Visible = false;
                button_right.Visible = true;
            }
            else if (terem == CorvinMozi.termek.Count - 1)
            {
                button_left.Visible = true;
                button_right.Visible = false;
            }
            else
            {
                button_left.Visible = true;
                button_right.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TeremUpdate();
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            terem--;
            if (terem <= 0)
            {
                terem = CorvinMozi.termek.Count - 1;
            }
            TeremUpdate();
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            terem++;
            if (terem >= CorvinMozi.termek.Count)
            {
                terem = 0;
            }
            TeremUpdate();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            CorvinMozi.Save();
        }
    }
}
