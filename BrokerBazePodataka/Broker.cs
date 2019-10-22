using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrokerBazePodataka
{
    public class Broker
    {
        private SqlConnection connection;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = VezbeSaBazamaPS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public List<Proizvodjac> vratiSveProizvodjace()
        {
            List<Proizvodjac> proizvodjaci = new List<Proizvodjac>();
            connection.Open();

            SqlDataReader reader = null;

            SqlCommand command = connection.CreateCommand();

            try
            {
                command.CommandText = "SELECT * FROM Proizvodjac";

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Proizvodjac p = new Proizvodjac()
                    {
                        IDProizvodjaca = (int)reader["id"],
                        NazivProizvodjaca = (string)reader["Naziv"]
                    };
                    proizvodjaci.Add(p);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Greska u bazi: " + e.Message + " " + e.StackTrace);
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
                connection.Close();
            }

            return proizvodjaci;        
        }

        public int VratiNoviIdProizvoda()
        {

            connection.Open();


            object maxValue;
            try
            {
                SqlCommand command = connection.CreateCommand();

                command.CommandText = "SELECT MAX(Id) from Proizvod";


                maxValue = command.ExecuteScalar();
                

            }
            catch (Exception e)
            {
                MessageBox.Show("Problem u bazi: " + e.Message);
                maxValue = -1;
            }
            finally
            {
                connection.Close();
            }
            

            if (maxValue is DBNull)
            {
                return 1;
            }
            return (int)maxValue + 1;
        }

        public bool SacuvajProizvod(Proizvod p)
        {
            try
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = $"INSERT INTO Proizvod VALUES({p.ID}, '{p.Ime}', {p.Cena}, {p.Proizvodjac.IDProizvodjaca})";

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Problem u bazi: " + e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }

    }
}
