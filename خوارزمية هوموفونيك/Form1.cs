using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace خوارزمية_هوموفونيك
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillDataGrid();
        }
        void fillDataGrid()
        {
            for (int i = 0; i < 13; i++)
            {
                string column = string.Format("Column{0}", i + 1);
                dataGridView1.Columns.Add(column, column);
            }

            for (int row = 0; row < 128; row++)
            {
                // We need to save each row as an array

                string[] currentColumn = new string[13];
                // We we add each column to the currentColumn

                for (int col = 0; col < 13; col++)
                {
                    if (col == 0)
                        currentColumn[0] = aToZ[row].ToString();
                    else
                    {
                        string rand = rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString();
                        while (checkReabet.Contains(rand))
                            rand = rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString();
                        checkReabet += rand;
                        currentColumn[col] = rand;
                    }
                    // We add that to the gridView
                }
                dataGridView1.Rows.Add(currentColumn);
            }
        }
        Random rnd = new Random();
        string checkReabet = "";
        string aToZ = "ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyz0123456789|أبتثجحخدذرزسشصضطظعغفقكلمنهويائءةلإؤى\\,.؟{}!@#$%^&*)(/-+<،>~:;?'=_";     
        string [][] alphabet = new string[26][];

        private void buttonClear_Click(object sender, EventArgs e)
        {  
            textBoxCipher.Clear();
            textBoxDecipher.Clear();
            textBoxPlain.Clear();
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add("rea16652@gmail.com");
                mailMessage.From = new MailAddress("rea16652@gmail.com");
                mailMessage.Subject = "ASP.NET e-mail test";
                mailMessage.Body = "Hello world,\n\nThis is an ASP.NET test e-mail!";
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Send(mailMessage);
                MessageBox.Show("E-mail sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not send the e-mail - error: " + ex.Message);
            }
        }
        int letterRow;
        Random randVal=new Random();
        private void buttonCipher_Click(object sender, EventArgs e)
        {
            textBoxCipher.Clear();
            string plain = textBoxPlain.Text.ToUpper();
            for (int i = 0; i < plain.Length; i++)
            {
                if (aToZ.Contains(plain[i]))
                {
                    for (int j = 0; j < 128; j++)
                        if (dataGridView1.Rows[j].Cells[0].Value.ToString() == plain[i].ToString())
                        { letterRow = j; break; }
                    textBoxCipher.Text += dataGridView1.Rows[letterRow].Cells[randVal.Next(1, 13)].Value.ToString();
                }
                else
                    textBoxCipher.Text += plain[i];
            }
        }

        private void buttonDecipher_Click(object sender, EventArgs e)
        {
            textBoxDecipher.Clear();
            string cipher = textBoxCipher.Text.ToUpper();
            for (int i = 0; i < cipher.Length; i += 4)
            {
                string letterval = cipher[i].ToString() + cipher[i + 1].ToString() + cipher[i + 2].ToString() + cipher[i + 3].ToString();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int j = 1; j < 13; j++)
                        if (row.Cells[j].Value.ToString().Contains(letterval))
                        {
                            textBoxDecipher.Text += dataGridView1.Rows[row.Index].Cells[0].Value.ToString();
                            goto ANN;
                        }
                }
            ANN:
                int k;
            }
        }

        private void buttonProb_Click(object sender, EventArgs e)
        {
            if (this.Height == 400)
                this.Size = new Size(1188, 692);
            else
                this.Size = new Size(1188, 400);

            Rectangle rect = Screen.PrimaryScreen.WorkingArea;
            this.Left = (rect.Width - this.Width) / 2;
            this.Top = (rect.Height - this.Height) / 2;
        }

        private void textBoxPlain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }
    }
}
