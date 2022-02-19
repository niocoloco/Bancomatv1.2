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
    public partial class Form2 : Form
    {

        string name, pw;
        string path;        //indirizzo file
        int balance = 0; //conto
        int moneytoadd;  //soldi da aggiungere
        int prelievo;   //soldi da prelevare
        int visibile = 0;

        //passaggio dal Form1 (registrazione) di nome e pw
        public Form2(TextBox box_name, TextBox box_pw, int stip)
        {
            InitializeComponent();
            path = box_name.Text + ".dat";
            name = box_name.Text;
            pw = box_pw.Text;
            balance = stip;
            lbl_balance.Text = stip.ToString();  //il saldo iniziale convertito in string sarà 0
        }


        //Pulsante deposita
        private void btn_addmoney_Click(object sender, EventArgs e)
        {
            //Controllo se pw inserita == pw del form1
            if (pw.Equals(txt_pw.Text))
            {
                //converto da stringa a Int a 32 bit
                moneytoadd = Convert.ToInt32(txt_moneytoadd.Text);
                //se minore di 0 rendo l'importo positivo
                if (moneytoadd < 0)
                {
                    moneytoadd *= -1;
                }

                //il conto incrementerà di moneytoadd
                balance += moneytoadd;

                lbl_balance.Text = balance.ToString();

                MessageBox.Show("Hai aggiunto € " + moneytoadd + " al tuo conto.", "Deposito riuscito.");

                File.Delete(path);

                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                {
                    writer.Write(pw);
                    writer.Write(name);
                    writer.Write(balance);
                }

            }

            else
            {
                MessageBox.Show("Password errata.", "Errore");
            }

            //svuoto le textbox
            txt_pw.Text = "";
            txt_moneytoadd.Text = "";

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        //Pulsante prelievo
        private void btm_prelievo_Click(object sender, EventArgs e)
        {
            //Controllo se pw inserita == pw del form1
            if (pw.Equals(txt_pw.Text))
            {
                prelievo = Convert.ToInt32(txt_prelievo.Text);

                if (prelievo < 0)
                {
                    prelievo *= -1;
                }

                if (prelievo > balance)
                {
                    MessageBox.Show("Errore nel prelievo, conto non sufficente.", "Prelievo fallito.");
                }

                else
                {

                    balance -= prelievo;

                    lbl_balance.Text = balance.ToString();

                    MessageBox.Show("Hai prelevato € " + prelievo + " dal tuo conto.", "Prelievo riuscito.");


                    File.Delete(path);

                    using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                    {
                        writer.Write(pw);
                        writer.Write(name);
                        writer.Write(balance);
                    }

                }

            }

            txt_pw.Text = "";
            txt_prelievo.Text = "";
        }

        //chiusura programma
        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Application.Exit();
        }

        private void creatoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atzori Nicolò", "Sviluppatore");
        }

        private void btn_pwvisible_Click(object sender, EventArgs e)
        {
            visibile++;
            if (visibile%2 == 0)
            {
                txt_pw.UseSystemPasswordChar = true;
            }
            else
            {
                txt_pw.UseSystemPasswordChar = false;
            }
        }


        private void time_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("HH:MM:ss");
            lbl_date.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

        private void autoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atzori Nicolò", "Programmatore");
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/niocoloco");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            time.Start();
        }
    }
}
