using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorProject.Model;
using System.Configuration;
using System.Data.SqlClient;


namespace VisitorProject.DAL
{
    class ZoneTypeGateway
    {
        String con = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString;
        List<Zonetype> zonetypeList = new List<Zonetype>(); 

        internal List<Model.Zonetype> GetAllZone()
        {
           SqlConnection connection = new SqlConnection(con);

            String query = "SELECT * FROM t_zone";

            connection.Open();
            SqlCommand command = new SqlCommand(query,connection);

            SqlDataReader aReader = command.ExecuteReader();

            while (aReader.Read())
            {
                Zonetype zonetype = new Zonetype();

                zonetype.id = int.Parse(aReader["Id"].ToString());
                zonetype.typename = aReader["Zone"].ToString();
                zonetypeList.Add(zonetype);

            }
            aReader.Close();
            connection.Close();
            return zonetypeList;


        }

        public int SaveZone(Zonetype zonetype)
        {
            SqlConnection connection = new SqlConnection(con);
            String query = "INSERT INTO t_zone VALUES('"+zonetype.typename+"')";
            connection.Open();
            SqlCommand command = new SqlCommand(query,connection);
            int mess = command.ExecuteNonQuery();
            connection.Close();
            return mess;



        }
    }
}
