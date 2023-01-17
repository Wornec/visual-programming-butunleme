using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _202151501019.büt
{
    public partial class Form2 : Form
    {
        private MySqlConnection conn;
        private string server;
        private string db;
        private string uid;
        private string password;
        public Form2()
        {
            InitializeComponent();
            server = "localhost";
            db = "db";
            uid = "root";
            password = "";

            string connString;
            connString = $"SERVER={server};DATABASE={db};UID={uid};PASSWORD={password};";

            conn = new MySqlConnection(connString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1(tbUser.Text, tbPass.text)
        }
        
        public bool 
    }
}
