using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace SiteEpsiAdministration
{
    public class Client
    {
        public int id { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime birthdate { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public int zipcode { get; set; }
        public string city { get; set; }
        public int role { get; set; }

        public Client(int id, string lastname, string firstname, string email, string password, DateTime birthdate, string address1, string address2, int zipcode, string city, int role)
        {
            this.id = id;
            this.lastname = lastname;
            this.firstname = firstname;
            this.email = email;
            this.password = password;
            this.birthdate = birthdate;
            this.address1 = address1;
            this.address2 = address2;
            this.zipcode = zipcode;
            this.city = city;
            this.role = role;
        }

        
        public Client()
        {

        }

        public List<Client> loadClient()
        {
            List<Client> lesClients = new List<Client>();
            string connectionString = ConfigurationManager.ConnectionStrings["SQLDbConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                string sql = "select * from Client";
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Client cl = new Client (
                        int.Parse(reader.GetValue(0).ToString()), reader.GetValue(1).ToString(),
                        reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), 
                        reader.GetValue(4).ToString(), DateTime.Parse(reader.GetValue(5).ToString()),
                        reader.GetValue(6).ToString(), reader.GetValue(7).ToString(), 
                        int.Parse(reader.GetValue(8).ToString()), reader.GetValue(9).ToString(), 
                        int.Parse(reader.GetValue(10).ToString())
                        );
                        lesClients.Add(cl);
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }
            connection.Close();
            return lesClients;
        }
    }
}