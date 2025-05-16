using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;



namespace Gamingconsole
{
    public partial class Anleitung : Form
    {
        public Anleitung()
        {
            InitializeComponent();
            this.Load += Anleitung_Load; 
        }

        private void Anleitung_Load(object? sender, EventArgs e)
        {
            string sprache = Spracheinstellung.GewählteSprache;
            string connectionString = "Data Source=..\\..\\..\\gamingconsoledb.db";
            string query = "SELECT Content FROM Instruction WHERE Language = @sprache";

            using (var conn = new Microsoft.Data.Sqlite.SqliteConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sprache", sprache);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string text = reader.GetString(0);
                            richTextBox1.Text = text;
                        }
                        else
                        {
                            richTextBox1.Text = "Keine Anleitung gefunden.";
                        }
                    }
                }
            }
        }
    }
}
