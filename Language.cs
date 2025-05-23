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
    public partial class Language : Form
    {
        public Language()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Deutsch
        {
            Spracheinstellung.GewählteSprache = "de";
            Anleitung anleitungForm = new Anleitung();
            anleitungForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) // Englisch
        {
            Spracheinstellung.GewählteSprache = "en";
            Anleitung anleitungForm = new Anleitung();
            anleitungForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) // Italienisch
        {
            Spracheinstellung.GewählteSprache = "it";
            Anleitung anleitungForm = new Anleitung();
            anleitungForm.Show();
            this.Hide(); // Versteckt das aktuelle Fenster
        }

        private void Language_Load(object sender, EventArgs e)
        {

        }
    }
}