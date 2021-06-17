using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OuthsNCrosses
{
    public partial class fMain : Form
    {
        int CurrentPlayer;
        List<string> Players=new List<string>();

        public fMain()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            using (fPlayers fDlg = new fPlayers())
            {
                if (Players.Count == 0)
                {
                    fDlg.ShowDialog();
                    if (fDlg.DialogResult == DialogResult.OK)
                    {
                        Players.Add(fDlg.txtPlayer1.Text);
                        Players.Add(fDlg.txtPlayer2.Text);
                        lblPlayer1.Text = fDlg.txtPlayer1.Text;
                        lblPlayer2.Text = fDlg.txtPlayer2.Text;
                    }
                }
                foreach (System.Windows.Forms.Control aControl in this.Controls)
                {
                    if (aControl is Field)
                    {
                        aControl.Refresh();
                        aControl.Enabled = true;
                        aControl.Text = "";
                    }
                }
                this.CurrentPlayer = 1;
                lblPlayer1.ForeColor = Color.Red;
                lblPlayer2.ForeColor = Color.Black;
            }
        }

        private void EndGame()
        {
            foreach (System.Windows.Forms.Control aControl in this.Controls)
            {
                if (aControl is Field)
                {
                    aControl.Enabled = false;
                }
            }
        }        

        private void CheckResults(int Player)
        {
            //Проверяем строки
            //1
            if (field1.Text == Player.ToString()
                & field2.Text == Player.ToString()
                & field3.Text == Player.ToString())
            {
                MessageBox.Show("Выиграл " + Players[Player-1]+"!");
                EndGame();
                return;
            }
            //2
            if (field4.Text == Player.ToString()
                & field5.Text == Player.ToString()
                & field6.Text == Player.ToString())
            {
                MessageBox.Show("Выиграл " + Players[Player - 1] + "!");
                EndGame();
                return;
            }
            //3
            if (field7.Text == Player.ToString()
                & field8.Text == Player.ToString()
                & field9.Text == Player.ToString())
            {
                MessageBox.Show("Выиграл " + Players[Player - 1] + "!");
                EndGame();
                return;
            }
            //Проверяем столбцы
            //1
            if (field1.Text == Player.ToString()
                & field6.Text == Player.ToString()
                & field9.Text == Player.ToString())
            {
                MessageBox.Show("Выиграл " + Players[Player - 1] + "!");
                EndGame();
                return;
            }
            //2
            if (field2.Text == Player.ToString()
                & field5.Text == Player.ToString()
                & field8.Text == Player.ToString())
            {
                MessageBox.Show("Выиграл " + Players[Player - 1] + "!");
                EndGame();
                return;
            }
            //3
            if (field3.Text == Player.ToString()
                & field4.Text == Player.ToString()
                & field7.Text == Player.ToString())
            {
                MessageBox.Show("Выиграл " + Players[Player - 1] + "!");
                EndGame();
                return;
            }
            //Проверяем диагонали
            //1
            if (field1.Text == Player.ToString()
                & field5.Text == Player.ToString()
                & field7.Text == Player.ToString())
            {
                MessageBox.Show("Выиграл " + Players[Player - 1] + "!");
                EndGame();
                return;
            }
            //2
            if (field3.Text == Player.ToString()
                & field5.Text == Player.ToString()
                & field9.Text == Player.ToString())
            {
                MessageBox.Show("Выиграл " + Players[Player - 1] + "!");
                EndGame();
                return;
            }
            //Проверяем ничью (если дошли до этого места)
            bool nowin = true;
            foreach (System.Windows.Forms.Control aControl in this.Controls)
            {
                if (aControl is Field)
                {
                    if (aControl.Text == "")
                        nowin = false; //если нашли не заполненое поле
                }
            }
            if (nowin)
            {
                MessageBox.Show("Ничья!");
                EndGame();
                return;
            }

            if (Player == 1)
            {
                CurrentPlayer = 2;
                lblPlayer2.ForeColor = Color.Red;
                lblPlayer1.ForeColor = Color.Black;
            }
            else
            {
                CurrentPlayer = 1;
                lblPlayer2.ForeColor = Color.Black;
                lblPlayer1.ForeColor = Color.Red;
            }
        }


        private void field1_Click(object sender, EventArgs e)
        {
            field1.PlayerClick(CurrentPlayer);
            this.CheckResults(CurrentPlayer);
        }

        private void field2_Click(object sender, EventArgs e)
        {
            field2.PlayerClick(CurrentPlayer);
            this.CheckResults(CurrentPlayer);
        }

        private void field3_Click(object sender, EventArgs e)
        {
            field3.PlayerClick(CurrentPlayer);
            this.CheckResults(CurrentPlayer);
        }

        private void field6_Click(object sender, EventArgs e)
        {
            field6.PlayerClick(CurrentPlayer);
            this.CheckResults(CurrentPlayer);
        }

        private void field5_Click(object sender, EventArgs e)
        {
            field5.PlayerClick(CurrentPlayer);
            this.CheckResults(CurrentPlayer);
        }

        private void field4_Click(object sender, EventArgs e)
        {
            field4.PlayerClick(CurrentPlayer);
            this.CheckResults(CurrentPlayer);
        }

        private void field9_Click(object sender, EventArgs e)
        {
            field9.PlayerClick(CurrentPlayer);
            this.CheckResults(CurrentPlayer);
        }

        private void field8_Click(object sender, EventArgs e)
        {
            field8.PlayerClick(CurrentPlayer);
            this.CheckResults(CurrentPlayer);
        }

        private void field7_Click(object sender, EventArgs e)
        {
            field7.PlayerClick(CurrentPlayer);
            this.CheckResults(CurrentPlayer);
        }

        private void mnuStartGame_Click(object sender, EventArgs e)
        {
            this.StartGame();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
