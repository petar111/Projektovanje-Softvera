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

    /// <summary>
    ///     Class Broker represents logic of manipulating relations in database trough oo model,
    ///     or said in different manner, connection between these two models.
    ///     
    /// </summary>
    public class Broker
    {

        private SqlConnection connection;

        /// <summary>
        /// Makes an instance of Broker class. Also makes the instance of connection field. Has fixed connection string currently.
        /// </summary>
        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = VezbeSaBazamaPS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


        /// <summary>
        ///     Returns all suppliers from Proizvodjac relation using SqlClient classes.
        /// 
        /// </summary>
        /// <returns>
        ///     All suppliers from Proizvodjac relation.
        /// </returns>
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


        /// <summary>
        ///     Returns new id for relation Proizvod. Error may occur, then, it will return -1.
        /// </summary>
        /// <returns>
        ///     New Id for relation Proizvod. -1 if error occurs.
        /// </returns>
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


        /// <summary>
        ///     Inserts new row in relation Proizvod.
        /// </summary>
        /// <param name="p">
        ///     Contents of new row. Reference to an object that represents relation in oo.
        /// </param>
        /// <returns>
        ///     True if insert in successful, false otherwise.
        /// </returns>
        public bool SacuvajProizvod(Proizvod p)
        {
            int rowsAffected = 0;
            try
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = $"INSERT INTO Proizvod VALUES({p.ID}, '{p.Ime}', {p.Cena}, {p.Proizvodjac.IDProizvodjaca})";

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Problem u bazi: " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected == 1;
        }

    }
}
