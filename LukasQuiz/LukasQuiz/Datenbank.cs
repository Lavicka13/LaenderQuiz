using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LukasQuiz
{
    public class Datenbank
    {
        MySqlConnection conn = null;
        MySqlCommand com;

        private void Oeffnen()
        {
            try
            {
                conn = new MySqlConnection("SERVER=localhost;UID=root;PASSWORD='';DATABASE=quizdb");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Schliessen()
        {
            if (conn != null)
                conn.Close();
        }
        public void saveSpieler(Spieler s)
        {
            try
            {
                Oeffnen();
                com = conn.CreateCommand();

                com.CommandText = "INSERT INTO Spieler " +
                                    "VALUES (NULL, '" +
                                    s.Name1 + "');";
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen();
            }
        }

        public void saveErgebnis(Ergebnis ergebnis)
        {
            try
            {
                Oeffnen(); // Methode zum Öffnen der Datenbankverbindung
                com = conn.CreateCommand();

                // SQL-Query für Einfügen des Scores in die Tabelle Ergebnis
                com.CommandText = "INSERT INTO Ergebnis (SpielerID, Pkt, Datum) " +
                                    "VALUES (@SpielerID, @Pkt, @Datum);";
                com.Parameters.AddWithValue("@SpielerID", ergebnis.SpielerID);
                com.Parameters.AddWithValue("@Pkt", ergebnis.Pkt1);
                com.Parameters.AddWithValue("@Datum", ergebnis.Datum1);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen(); // Methode zum Schließen der Datenbankverbindung
            }
        }

        public List<Spieler> getSpieler()
        {
            List<Spieler> liSpieler = new List<Spieler>();

            try
            {
                Oeffnen();
                com = conn.CreateCommand();
                com.CommandText = "SELECT * FROM Spieler;";

                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liSpieler.Add(
                        new Spieler(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1)
                            )
                        );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen();
            }
            return liSpieler;
        }

        public List<Laender> getLaender()
        {
            List<Laender> liLaender = new List<Laender>();

            try
            {
                Oeffnen();
                com = conn.CreateCommand();
                com.CommandText = "SELECT * FROM laender;"; 

                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liLaender.Add(
                    new Laender(
                    reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                    reader.IsDBNull(1) ? "" : reader.GetString(1),
                    reader.IsDBNull(2) ? "" : reader.GetString(2),
                    reader.IsDBNull(3) ? -1 : reader.GetInt32(3),
                    reader.IsDBNull(4) ? "" : reader.GetString(4)
                    )
                  );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen();
            }

            return liLaender;
        }

        public List<Ergebnis> getErgebnis()
        {
            List<Ergebnis> liErgebnis = new List<Ergebnis>();

            try
            {
                Oeffnen();
                com = conn.CreateCommand();
                com.CommandText = "SELECT e.ErgebnisId, e.Pkt, e.Datum, s.Name FROM Ergebnis e JOIN Spieler s ON e.SpielerID = s.SpielerID ORDER BY e.Pkt DESC;";

                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liErgebnis.Add(
                        new Ergebnis(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                            reader.IsDBNull(1) ? -1 : reader.GetInt32(1),
                            reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2),
                            reader.IsDBNull(3) ? "" : reader.GetString(3)
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen();
            }

            return liErgebnis;
        }

        public List<Kontinente> getKontinente()
        {
            List<Kontinente> liKontinente = new List<Kontinente>();

            try
            {
                Oeffnen();
                com = conn.CreateCommand();
                com.CommandText = "SELECT * FROM Kontinente;";

                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liKontinente.Add(
                        new Kontinente(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1)
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen();
            }

            return liKontinente;
        }
    }       
    }
 
