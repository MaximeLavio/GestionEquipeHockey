using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GestionEquipeHockey.Classes
{
    public class AdoNet
    {
        // Attributs privés
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string connectionString;
        private DataTable dtJoueurs;
        private DataSet dsGestionHockey;
        private DataTable dtGardiens;
        private DataTable dtContrats;


        // Propriétés 
        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionString { get => connectionString; }
        public DataTable DtJoueurs { get => dtJoueurs; set => dtJoueurs = value; }
        public DataSet DsGestionHockey { get => dsGestionHockey; set => dsGestionHockey = value; }
        public DataTable DtGardiens{ get => dtGardiens; set => dtGardiens = value; }
        public DataTable DtContrats { get => dtContrats; set => dtContrats = value; }

        //Constructeur
        public AdoNet()
        {
            connectionString = "Data Source=NAT8\\MONSQL;Initial Catalog=GestionHockey;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dsGestionHockey = new DataSet();
            dtJoueurs = new DataTable();
            dtGardiens = new DataTable();
            dtContrats = new DataTable();
        }


    }
}

