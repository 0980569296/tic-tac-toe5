using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe2
{
    public partial class Form1 : Form
    {
        bool ch;
        int plusone;
        int n = 0;
        void Enabled_false()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;
        }
        void Score()
        {
             if (n == 9)
            {
                MessageBox.Show("Nobody wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n = 0;
                return;
            }
            if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic2.BackColor = Color.PowderBlue;
                btnTic3.BackColor = Color.PowderBlue;
                MessageBox.Show("Player X wins!","Tic Tac Toe",MessageBoxButtons.OK,MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text) + 1;
                lblPlayerX.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;
                MessageBox.Show("Player X wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text) + 1;
                lblPlayerX.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;
                MessageBox.Show("Player X wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text) + 1;
                lblPlayerX.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic4.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;
                MessageBox.Show("Player X wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text) + 1;
                lblPlayerX.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;
                MessageBox.Show("Player X wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text) + 1;
                lblPlayerX.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X")
            {
                btnTic3.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;
                MessageBox.Show("Player X wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text) + 1;
                lblPlayerX.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic9.Text == "X")
            {
                btnTic1.BackColor = Color.Crimson;
                btnTic5.BackColor = Color.Crimson;
                btnTic9.BackColor = Color.Crimson;
                MessageBox.Show("Player X wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text) + 1;
                lblPlayerX.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic3.Text == "X" && btnTic5.Text == "X" && btnTic7.Text == "X")
            {
                btnTic3.BackColor = Color.Crimson;
                btnTic5.BackColor = Color.Crimson;
                btnTic7.BackColor = Color.Crimson;
                MessageBox.Show("Player X wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text) + 1;
                lblPlayerX.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            //-----------------------------------------------------------------------------------------------------------
            else if (btnTic1.Text == "O" && btnTic2.Text == "O" && btnTic3.Text == "O")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic2.BackColor = Color.PowderBlue;
                btnTic3.BackColor = Color.PowderBlue;
                MessageBox.Show("Player O wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text) + 1;
                lblPlayerO.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic4.Text == "O" && btnTic5.Text == "O" && btnTic6.Text == "O")
            {
                btnTic4.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;
                MessageBox.Show("Player O wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text) + 1;
                lblPlayerO.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic7.Text == "O" && btnTic8.Text == "O" && btnTic9.Text == "O")
            {
                btnTic7.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;
                MessageBox.Show("Player O wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text) + 1;
                lblPlayerO.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic1.Text == "O" && btnTic4.Text == "O" && btnTic7.Text == "O")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic4.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;
                MessageBox.Show("Player O wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text) + 1;
                lblPlayerO.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic2.Text == "O" && btnTic5.Text == "O" && btnTic8.Text == "O")
            {
                btnTic2.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;
                MessageBox.Show("Player O wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text) + 1;
                lblPlayerO.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic3.Text == "O" && btnTic6.Text == "O" && btnTic9.Text == "O")
            {
                btnTic3.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;
                MessageBox.Show("Player O wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text) + 1;
                lblPlayerO.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic1.Text == "O" && btnTic5.Text == "O" && btnTic9.Text == "O")
            {
                btnTic1.BackColor = Color.Crimson;
                btnTic5.BackColor = Color.Crimson;
                btnTic9.BackColor = Color.Crimson;
                MessageBox.Show("Player O wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text) + 1;
                lblPlayerO.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
            else if (btnTic3.Text == "O" && btnTic5.Text == "O" && btnTic7.Text == "O")
            {
                btnTic3.BackColor = Color.Crimson;
                btnTic5.BackColor = Color.Crimson;
                btnTic7.BackColor = Color.Crimson;
                MessageBox.Show("Player O wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text) + 1;
                lblPlayerO.Text = Convert.ToString(plusone);
                Enabled_false();
                n = 0;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            if (ch == false)
            {
                btnTic1.Text = "X";
                ch = true;
            }
            else
            {
                btnTic1.Text = "O";
                ch = false;
            }
            Score();
            btnTic1.Enabled = false;
            n++;
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            if (ch == false)
            {
                btnTic2.Text = "X";
                ch = true;
            }
            else
            {
                btnTic2.Text = "O";
                ch = false;
            }
            Score();
            btnTic2.Enabled = false;
            n++;
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            if (ch == false)
            {
                btnTic3.Text = "X";
                ch = true;
            }
            else
            {
                btnTic3.Text = "O";
                ch = false;
            }
            Score();
            btnTic3.Enabled = false;
            n++;
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            if (ch == false)
            {
                btnTic4.Text = "X";
                ch = true;
            }
            else
            {
                btnTic4.Text = "O";
                ch = false;
            }
            Score();
            btnTic4.Enabled = false;
            n++;
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            if (ch == false)
            {
                btnTic5.Text = "X";
                ch = true;
            }
            else
            {
                btnTic5.Text = "O";
                ch = false;
            }
            Score();
            btnTic5.Enabled = false;
            n++;
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            if (ch == false)
            {
                btnTic6.Text = "X";
                ch = true;
            }
            else
            {
                btnTic6.Text = "O";
                ch = false;
            }
            Score();
            btnTic6.Enabled = false;
            n++;
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            if (ch == false)
            {
                btnTic7.Text = "X";
                ch = true;
            }
            else
            {
                btnTic7.Text = "O";
                ch = false;
            }
            Score();
            btnTic7.Enabled = false;
            n++;
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            if (ch == false)
            {
                btnTic8.Text = "X";
                ch = true;
            }
            else
            {
                btnTic8.Text = "O";
                ch = false;
            }
            Score();
            btnTic8.Enabled = false;
            n++;
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            if (ch == false)
            {
                btnTic9.Text = "X";
                ch = true;
            }
            else
            {
                btnTic9.Text = "O";
                ch = false;
            }
            Score();
            btnTic9.Enabled = false;
            n++;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                btnTic1.BackColor = Color.WhiteSmoke;
                btnTic2.BackColor = Color.WhiteSmoke;
                btnTic3.BackColor = Color.WhiteSmoke;
                btnTic4.BackColor = Color.WhiteSmoke;
                btnTic5.BackColor = Color.WhiteSmoke;
                btnTic6.BackColor = Color.WhiteSmoke;
                btnTic7.BackColor = Color.WhiteSmoke;
                btnTic8.BackColor = Color.WhiteSmoke;
                btnTic9.BackColor = Color.WhiteSmoke;

                lblPlayerO.Text = "0";
                lblPlayerX.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void btnRes_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit = MessageBox.Show("confirm if you want to exit!" , "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Tic Tac Toe",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnRes_Click_1(object sender, EventArgs e)
        {
            try
            {
                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                btnNew.Enabled = true;

                btnTic1.BackColor = Color.WhiteSmoke;
                btnTic2.BackColor = Color.WhiteSmoke;
                btnTic3.BackColor = Color.WhiteSmoke;
                btnTic4.BackColor = Color.WhiteSmoke;
                btnTic5.BackColor = Color.WhiteSmoke;
                btnTic6.BackColor = Color.WhiteSmoke;
                btnTic7.BackColor = Color.WhiteSmoke;
                btnTic8.BackColor = Color.WhiteSmoke;
                btnTic9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
