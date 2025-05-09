using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamingconsole
{
    public partial class Auswahl : Form
    {
        public Auswahl()
        {
            InitializeComponent();
        }

        private void Auswahl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Tictactoe tictactoeForm = new Tictactoe();
            tictactoeForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Language languageForm = new Language();  
            languageForm.Show();
            this.Hide();

        }
    }
}
