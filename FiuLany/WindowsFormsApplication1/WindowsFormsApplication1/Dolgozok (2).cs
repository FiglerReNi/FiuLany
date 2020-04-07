using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Dolgozok : Form
    {
        List<Emberek> emberek = new List<Emberek>();
        List<Emberek> lanyok = new List<Emberek>();
        List<Emberek> fiuk = new List<Emberek>();
        public Dolgozok()
        {   
            InitializeComponent();
            string[] beolvas = File.ReadAllLines("emberek.txt", Encoding.Default);
            for (int i = 1; i < beolvas.Length; i++)
            {
                string[] sor = beolvas[i].Split(';');
                string nev = beolvas[i].Split(';')[0];
                int kor = int.Parse(beolvas[i].Split(';')[1]);
                string neme = beolvas[i].Split(';')[2];
                int munka;
                if (sor.Length > 3)
                {
                    munka = int.Parse(beolvas[i].Split(';')[3]);
                }
                else
                {
                    munka = 0;
                }
                emberek.Add(new Emberek(nev, kor, neme, munka));
                if (beolvas[i].Split(';')[2] == "L")
                {
                     lany.Items.Add(beolvas[i].Split(';')[0]);
                     lanyok.Add(new Emberek(nev, kor, neme, munka));
                }
                else
                {
                    fiu.Items.Add(beolvas[i].Split(';')[0]);
                    fiuk.Add(new Emberek(nev, kor, neme, munka));
                }
            }
        }

        private void lany_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Emberek ember in emberek)
            {
                if(ember.Nev == lany.SelectedItem.ToString())
                {
                    adatkor.Text = ember.Kor.ToString();
                    if(ember.Munka > 0)
                    {
                        adatmiota.Text = ember.Munka.ToString() + " éve";
                    }
                    else
                    {
                        adatmiota.Text = "Nem dolgozott még.";
                    }

                }
            }
        }

        private void fiu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Emberek ember in emberek)
            {
                if (ember.Nev == fiu.SelectedItem.ToString())
                {
                    adatkor.Text = ember.Kor.ToString();
                    if (ember.Munka > 0)
                    {
                        adatmiota.Text = ember.Munka.ToString() + " éve";
                    }
                    else
                    {
                        adatmiota.Text = "Nem dolgozott még.";
                    }

                }
            }
        }
        private void osszlany_CheckedChanged(object sender, EventArgs e)
        {
            osszlegidos.Text = legidosebb(lanyok).ToString();
            osszkor.Text = osszes(lanyok).ToString();
            osszhateve.Text = miota(lanyok);


        }
        private void osszfiu_CheckedChanged(object sender, EventArgs e)
        {
            osszlegidos.Text = legidosebb(fiuk).ToString();
            osszkor.Text = osszes(fiuk).ToString();
            osszhateve.Text = miota(fiuk);

        }
        private void ment_Click(object sender, EventArgs e)
        {
            string kiir = "";
            if (mind.Checked)
            {
                string llany = legidosebb(lanyok).ToString();
                string olany = osszes(lanyok).ToString();
                string mlany = miota(lanyok).ToString();
                string lfiu = legidosebb(fiuk).ToString();
                string ofiu = osszes(fiuk).ToString();
                string mfiu = miota(fiuk).ToString();
                kiir += "Lanyok: " + Environment.NewLine +  "legidősebb: " + llany + Environment.NewLine + "összes kor: " + olany + Environment.NewLine + "hat éve dolgozó: " + mlany + Environment.NewLine + "Fiuk: " + Environment.NewLine + "legidősebb: " + lfiu + Environment.NewLine + "összes kor: " + ofiu + Environment.NewLine + "hat éve dolgozó: " + mfiu;
              File.WriteAllText("dolgozok.txt", kiir);
            }
            else
            {
                if (osszlany.Checked)
                {
                    kiir += "Lanyok: " + Environment.NewLine;
                }
                else
                {
                    kiir += "Fiuk: " + Environment.NewLine;
                }
               kiir += "legidősebb: " + osszlegidos.Text + Environment.NewLine + "összes kor: " + osszkor.Text + Environment.NewLine + "hat éve dolgozó: " + osszhateve.Text;
                File.WriteAllText("dolgozok.txt", kiir);
            }
          
        }
        private int legidosebb(List<Emberek> ember)
        {
            int max = ember[0].Kor;
            for (int i = 0; i < ember.Count; i++)
            {
                if (ember[i].Kor > max)
                {
                    max = ember[i].Kor;
                }
            }
            return max;
        }
        private int osszes(List<Emberek> ember)
        {
            int ossz = 0;
            for (int i = 0; i < ember.Count; i++)
            {
                ossz = ossz + ember[i].Kor;
            }
            return ossz;
        }
        private string miota(List<Emberek> ember)
        {
            int index = -1;
            for (int i = 0; i < ember.Count; i++)
            {               
                if (ember[i].Munka >= 6)
                {
                    index = i;
                }
            }
            if (index >= 0)
            {
                return ember[index].Nev;
            }
            else
            {
                return "nincs";
            }
        }
      
    }
}
