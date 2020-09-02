using Pracownicy.Controller;
using Pracownicy.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PracownicyController pc = new PracownicyController();
            var nastepnyPracownik = pc.GetDataFromTextBox(tbImie, tbNazwisko, tbWiek);
            bool dodaj = pc.DodajPracownika(nastepnyPracownik);

            //LUB
            //PracownicyController stworzenieNowegoPracownika = new PracownicyController();
            //ModelPracownicy nastepnyPracownik = stworzenieNowegoPracownika.GetDataFromTextBox(tbImie, tbNazwisko, tbWiek);
            //bool sprawdzCzyDodany = stworzenieNowegoPracownika.DodajPracownika(nastepnyPracownik);

            MessageBox.Show(dodaj ? "OK" : "NIE OK");
        }

        private void btdodajEtat_Click(object sender, EventArgs e)
        {
            PracownicyController pc = new PracownicyController();
            var nowyEtat = pc.GetDataFromComboBox(cbEtaty);

            bool czyDodano = pc.DodajEtat(nowyEtat);
            MessageBox.Show(czyDodano ? "OK" : "NIE OK");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                PracownicyController pc = new PracownicyController();
                var nastepnyPracownik = pc.GetDataFromTextBox(tbImie, tbNazwisko, tbWiek);
                bool dodaj = pc.DodajPracownika(nastepnyPracownik);

                //LUB
                //PracownicyController stworzenieNowegoPracownika = new PracownicyController();
                //ModelPracownicy nastepnyPracownik = stworzenieNowegoPracownika.GetDataFromTextBox(tbImie, tbNazwisko, tbWiek);
                //bool sprawdzCzyDodany = stworzenieNowegoPracownika.DodajPracownika(nastepnyPracownik);

                MessageBox.Show(dodaj ? "OK" : "NIE OK");
            }
            else
            {
                MessageBox.Show("Nie zaznaczyles checkboxa");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PracownicyController pc = new PracownicyController();
            var updatedEtat = pc.UpdateFromComboBox(comboBox1);

            bool czyZaktualizowane = pc.AktualizujEtat(updatedEtat);
            MessageBox.Show(czyZaktualizowane ? "OK" : "NIE OK");
        }
        //public static string txtbImietext
        //{
        //    get { return txtbImietext; }
        //    set { txtbImietext = value; }
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm2; 
            frm2 = new Form2();
            frm2.Show(this);
            string text = tbNazwisko.Text;
            frm2.ModifyTextBoxValue = text;

        }

        private void tbImie_TextChanged(object sender, EventArgs e)
        {
            //txtbImietext = tbImie.Text;
        }
    }
}
