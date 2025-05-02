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
    public partial class Anleitung : Form
    {
        public Anleitung(string language)
        {
            InitializeComponent();

            ///
            myTextBox1.Text = "SELECT  FROM uebeseeaf af"
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auswahl auswahlForm = new Auswahl(); 
            auswahlForm.Show(); 
            this.Close(); 

        }
    }
}
