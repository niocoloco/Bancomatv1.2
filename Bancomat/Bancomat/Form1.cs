using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bancomat
{
    public partial class Form1 : Form
    {

        int visibile = 0;   //contatore per password visibile
        int balance = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            //se la stringa della pw o del nome è vuota o uno spazio
            //genera finestra di errore
            if (String.IsNullOrWhiteSpace(Convert.ToString(box_pw.Text)) || String.IsNullOrWhiteSpace(Convert.ToString(box_name.Text)))
            {
                MessageBox.Show("Inserisci nome utente e password per accedere al tuo conto.", "Errore");

                //svuoto le TextBox
                box_name.Text = "";
                box_pw.Text = "";
            }

            //se la pw è < di 8 caratteri
            //lbl_pwerr compare con la scritta "Password non sicura, utilizza minimo 8 caratteri."
            else if (box_pw.Text.Length < 8)
            {
                lbl_pwerr.Text = "Password non sicura, utilizza\nminimo 8 caratteri.";
                box_pw.Text = "";
            }

            //se tutto è stato inserito correttamente
            else
            {
                string path = box_name.Text + ".dat";

                //se il file esiste
                if (File.Exists(path))
                {
                    string pw;
                    //controllo sulla password
                    using (BinaryReader reader = new BinaryReader (File.Open(path, FileMode.Open)))
                    {
                        pw = reader.ReadString();   //leggo la pw nel file
                        reader.ReadString();
                        balance = reader.ReadInt32();
                    }

                    //se non è corretta segnala l'errore
                    if (pw != box_pw.Text)
                    {
                        MessageBox.Show("Password errata.", "Errore");
                    }

                    //se la pw è corretta
                    else
                    {
                        //istanzio un nuovo oggetto di tipo Form2
                        Form2 Bancomat = new Form2(box_name, box_pw, balance);   //passo nome utente e password
                        this.Hide(); //nasconde il primo form
                        Bancomat.ShowDialog();  //faccio apparire il nuovo form
                    }

                    //istanzio un nuovo oggetto di tipo Form2
                    
                }
                else
                {
                    //scrivo nel file nome e password
                    using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                    {
                        writer.Write(box_pw.Text);
                        writer.Write(box_name.Text);
                        writer.Write(balance);
                    }

                    //istanzio un nuovo oggetto di tipo Form2
                    Form2 Bancomat = new Form2(box_name, box_pw, balance);   //passo nome utente e password
                    this.Hide(); //nasconde il primo form
                    Bancomat.ShowDialog();  //faccio apparire il nuovo form

                }


            }
        }

        //Pulsante Annulla, svuota i TextBox
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            box_name.Text = "";
            box_pw.Text = "";
        }


        private void creatoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atzori Nicolò", "Sviluppatore");
        }


        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Pulsante con il simbolo dell'occhio
        private void btn_visiblepw_Click(object sender, EventArgs e)
        {
            //una volta premut incremento la variabile
            visibile++;

            //se pari la pw è visibile
            if(visibile%2 == 0)
            {
                box_pw.UseSystemPasswordChar = true;
            }

            //altrimenti risulta sostituita da caratteri che la nascondono
            else
            {
                box_pw.UseSystemPasswordChar = false;
            }
        }

        //Orologio del programma
        private void time_date_Tick(object sender, EventArgs e)
        {
            //stampa della data es. -> dic 29 2021
            lbl_date.Text = DateTime.Now.ToString("MMM dd yyyy");
            //stampa dell'orario es. -> 11:02:24
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //caricamento del form1
        private void Form1_Load(object sender, EventArgs e)
        {
            time_date.Start();  //partenza del timer
        }

        private void autoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atzori Nicolò", "Programmatore");
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/niocoloco");
        }

        private void lbl_version_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aggiunto file README con i contenuti della nuova versione.", "Note della versione 1.2.");
        }
    }
}
