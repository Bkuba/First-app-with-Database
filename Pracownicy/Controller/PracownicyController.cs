using Pracownicy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownicy.Controller
{
    public class PracownicyController
    {
        // metoda ktora pobiera dane z teksboxow i laduje je do nowego obiektu
        public ModelPracownicy GetDataFromTextBox(TextBox _imie, TextBox _nazwisko, TextBox _wiek)
        {
            ModelPracownicy nowyPracownik = new ModelPracownicy();
            nowyPracownik.imie = _imie.Text;
            nowyPracownik.nazwisko = _nazwisko.Text;
            nowyPracownik.wiek = Convert.ToInt32(_wiek.Text);

            return nowyPracownik;
        }

        public bool DodajPracownika(ModelPracownicy obiektPracownika)
        {
            var nowyPracownik = new PrzekazPracownikaDoBazy();
            var sprawdzCzyDodanyDoBazy = nowyPracownik.ZapiszDoBazy(obiektPracownika);
            // LUB
            //PrzekazPracownikaDoBazy nowyPracownik = new PrzekazPracownikaDoBazy();
            //bool sprawdzCzyDodanyDoBazy = nowyPracownik.ZapiszDoBazy(obiektPracownika);

            MessageBox.Show(sprawdzCzyDodanyDoBazy ? "ok" : "nie ok");
            return sprawdzCzyDodanyDoBazy;
        }

        public ModelPracownicy GetDataFromComboBox(ComboBox _etat)
        {
            ModelPracownicy nowyEtat = new ModelPracownicy();
            nowyEtat.etat = _etat.GetItemText(_etat.SelectedItem);

            return nowyEtat;
        }

        public bool DodajEtat(ModelPracownicy obiektEtat)
        {
            PrzekazPracownikaDoBazy nowyEtat = new PrzekazPracownikaDoBazy();
            var sprawdzCzyDodanoEtat = nowyEtat.ZapiszEtat(obiektEtat);

            MessageBox.Show(sprawdzCzyDodanoEtat ? "OK" : "NIE OK");
            return sprawdzCzyDodanoEtat;
        }

        public ModelPracownicy UpdateFromComboBox(ComboBox _etat)
        {
            ModelPracownicy zaktualizowanyEtat = new ModelPracownicy();
            zaktualizowanyEtat.etat = _etat.GetItemText(_etat.SelectedItem);

            return zaktualizowanyEtat;
        }

        public bool AktualizujEtat(ModelPracownicy obiektEtat)
        {
            var zaktualizowanyEtat = new PrzekazPracownikaDoBazy();
            var czyZaktualizowano = zaktualizowanyEtat.AktualizujDane(obiektEtat);

            MessageBox.Show(czyZaktualizowano ? "OK" : "NIE OK");
            return czyZaktualizowano;
        }

    }
}
