using Pracownicy.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pracownicy.Controller
{
	public class PrzekazPracownikaDoBazy
    {
        public bool ZapiszDoBazy(ModelPracownicy Pracownik)
        {
			try
			{
				var connect = new Connect();
				var connection = connect.ConnectToDatabase();

				using (var command = new SqlCommand()) //korekta na danych w bazie
				{
					string zapytanie = "INSERT INTO Pracownicy VALUES (@imie, @nazwisko, @wiek);"; // te nazwy nie musza byc takie jak kolumny w tabeli
					command.CommandType = CommandType.Text;
					command.Connection = connection;
					command.CommandText = zapytanie;

					command.Parameters.AddWithValue("@imie", Pracownik.imie);
					command.Parameters.AddWithValue("@nazwisko", Pracownik.nazwisko);
					command.Parameters.AddWithValue("@wiek", Pracownik.wiek);

					command.ExecuteNonQuery();
					command.Parameters.Clear();
				}

				connection.Close();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		public bool ZapiszEtat(ModelPracownicy Pracownik)
		{
			try
			{
				var connect = new Connect();
				var connection = connect.ConnectToDatabase();

				using (var command = new SqlCommand()) //korekta na danych w bazie
				{
					string zapytanie = "INSERT INTO Etaty VALUES (@etat);"; // te nazwy nie musza byc takie jak kolumny w tabeli
					command.CommandType = CommandType.Text;
					command.Connection = connection;
					command.CommandText = zapytanie;

					command.Parameters.AddWithValue("@etat", Pracownik.etat);

					command.ExecuteNonQuery();
					command.Parameters.Clear();
				}

				connection.Close();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		public bool AktualizujDane(ModelPracownicy Pracownik)
		{
			try
			{
				var connect = new Connect();
				var connection = connect.ConnectToDatabase();

				using (var command = new SqlCommand()) //korekta na danych w bazie
				{
					string zapytanie = "UPDATE Etaty SET nazwaetatu = @etat;"; // te nazwy nie musza byc takie jak kolumny w tabeli
					command.CommandType = CommandType.Text;
					command.Connection = connection;
					command.CommandText = zapytanie;

					command.Parameters.AddWithValue("@etat", Pracownik.etat);

					command.ExecuteNonQuery();
					command.Parameters.Clear();
				}

				connection.Close();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

	}
}
