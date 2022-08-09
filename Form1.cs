using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Matrix_Operations
{
    public partial class Form1 : Form
    {

        TextBox[,] matrix1 = new TextBox[5,5];
        TextBox[,] matrix2 = new TextBox[5,5];
        TextBox[,] matrix3 = new TextBox[5,5];

        int i1, i2, j1, j2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            buttonPlus.Enabled = false;
            buttonMinus.Enabled = false;
            buttonX.Enabled = false;

            buttonPlus.Visible = false;
            buttonMinus.Visible = false;
            buttonX.Visible = false;

            matrix1[0, 0] = number00_1;
            matrix1[0, 1] = number01_1;
            matrix1[0, 2] = number02_1;
            matrix1[0, 3] = number03_1;
            matrix1[0, 4] = number04_1;
            matrix1[1, 0] = number10_1;
            matrix1[1, 1] = number11_1;
            matrix1[1, 2] = number12_1;
            matrix1[1, 3] = number13_1;
            matrix1[1, 4] = number14_1;
            matrix1[2, 0] = number20_1;
            matrix1[2, 1] = number21_1;
            matrix1[2, 2] = number22_1;
            matrix1[2, 3] = number23_1;
            matrix1[2, 4] = number24_1;
            matrix1[3, 0] = number30_1;
            matrix1[3, 1] = number31_1;
            matrix1[3, 2] = number32_1;
            matrix1[3, 3] = number33_1;
            matrix1[3, 4] = number34_1;
            matrix1[4, 0] = number40_1;
            matrix1[4, 1] = number41_1;
            matrix1[4, 2] = number42_1;
            matrix1[4, 3] = number43_1;
            matrix1[4, 4] = number44_1;

            matrix2[0, 0] = number00_2;
            matrix2[0, 1] = number01_2;
            matrix2[0, 2] = number02_2;
            matrix2[0, 3] = number03_2;
            matrix2[0, 4] = number04_2;
            matrix2[1, 0] = number10_2;
            matrix2[1, 1] = number11_2;
            matrix2[1, 2] = number12_2;
            matrix2[1, 3] = number13_2;
            matrix2[1, 4] = number14_2;
            matrix2[2, 0] = number20_2;
            matrix2[2, 1] = number21_2;
            matrix2[2, 2] = number22_2;
            matrix2[2, 3] = number23_2;
            matrix2[2, 4] = number24_2;
            matrix2[3, 0] = number30_2;
            matrix2[3, 1] = number31_2;
            matrix2[3, 2] = number32_2;
            matrix2[3, 3] = number33_2;
            matrix2[3, 4] = number34_2;
            matrix2[4, 0] = number40_2;
            matrix2[4, 1] = number41_2;
            matrix2[4, 2] = number42_2;
            matrix2[4, 3] = number43_2;
            matrix2[4, 4] = number44_2;

            matrix3[0, 0] = number00_3;
            matrix3[0, 1] = number01_3;
            matrix3[0, 2] = number02_3;
            matrix3[0, 3] = number03_3;
            matrix3[0, 4] = number04_3;
            matrix3[1, 0] = number10_3;
            matrix3[1, 1] = number11_3;
            matrix3[1, 2] = number12_3;
            matrix3[1, 3] = number13_3;
            matrix3[1, 4] = number14_3;
            matrix3[2, 0] = number20_3;
            matrix3[2, 1] = number21_3;
            matrix3[2, 2] = number22_3;
            matrix3[2, 3] = number23_3;
            matrix3[2, 4] = number24_3;
            matrix3[3, 0] = number30_3;
            matrix3[3, 1] = number31_3;
            matrix3[3, 2] = number32_3;
            matrix3[3, 3] = number33_3;
            matrix3[3, 4] = number34_3;
            matrix3[4, 0] = number40_3;
            matrix3[4, 1] = number41_3;
            matrix3[4, 2] = number42_3;
            matrix3[4, 3] = number43_3;
            matrix3[4, 4] = number44_3;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix1[i, j].Visible = false;
                    matrix1[i, j].Enabled = false;

                    matrix2[i, j].Visible = false;
                    matrix2[i, j].Enabled = false;

                    matrix3[i, j].Visible = false;
                    matrix3[i, j].Enabled = false;
                }
            }

        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {

            if ((rows1.Text == "") || (columns1.Text == "") || (rows2.Text == "") || (columns2.Text == ""))
            {
                MessageBox.Show("Wrong matrix dimensions");
            }
            else
            {
                i1 = int.Parse(rows1.SelectedItem.ToString());
                j1 = int.Parse(columns1.SelectedItem.ToString());

                i2 = int.Parse(rows2.SelectedItem.ToString());
                j2 = int.Parse(columns2.SelectedItem.ToString());

                for (int i = 0; i < i1; i++)
                {
                    for (int j = 0; j < j1; j++)
                    {
                        matrix1[i, j].Text = "";
                        matrix1[i, j].Visible = true;
                        matrix1[i, j].Enabled = true;
                    }
                }

                for (int i = 0; i < i2; i++)
                {
                    for (int j = 0; j < j2; j++)
                    {
                        matrix2[i, j].Text = "";
                        matrix2[i, j].Visible = true;
                        matrix2[i, j].Enabled = true;
                    }
                }

                for (int i=0; i<5; i++)
                {
                    for (int j=j1; j<5; j++)
                    {
                        matrix1[i, j].Text = "";
                        matrix1[i, j].Visible = false;
                        matrix1[i, j].Enabled = false;
                    }
                }

                for (int i=i1; i<5; i++)
                {
                    for (int j=0; j<5; j++)
                    {
                        matrix1[i, j].Text = "";
                        matrix1[i, j].Visible = false;
                        matrix1[i, j].Enabled = false;
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = j2; j < 5; j++)
                    {
                        matrix2[i, j].Text = "";
                        matrix2[i, j].Visible = false;
                        matrix2[i, j].Enabled = false;
                    }
                }

                for (int i = i2; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        matrix2[i, j].Text = "";
                        matrix2[i, j].Visible = false;
                        matrix2[i, j].Enabled = false;
                    }
                }

                for (int i=0; i<5; i++)
                {
                    for (int j=0; j<5; j++)
                    {
                        matrix3[i, j].Text = "";
                        matrix3[i, j].Enabled = false;
                        matrix3[i, j].Visible = false;
                    }
                }

                buttonPlus.Enabled = true;
                buttonMinus.Enabled = true;
                buttonX.Enabled = true;

                buttonPlus.Visible = true;
                buttonMinus.Visible = true;
                buttonX.Visible = true;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

            if ((i1 != i2) || (j1 != j2))
            {
                MessageBox.Show("Wrong matrix dimensions");
            }
            else
            {
                for (int i=0; i<i1; i++)
                {
                    for (int j=0; j<j1; j++)
                    {
                        matrix3[i, j].Visible = true;
                        matrix3[i,j].Enabled = true;

                        if (matrix1[i,j].Text == "")
                        {
                            matrix1[i, j].Text = "0";
                        }
                        if (matrix2[i,j].Text == "")
                        {
                            matrix2[i,j].Text = "0";
                        }

                        matrix3[i, j].Text = (int.Parse(matrix1[i, j].Text) + int.Parse(matrix2[i,j].Text)).ToString();
                    }
                }
            } 
            
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

            if ((i1 != i2) || (j1 != j2))
            {
                MessageBox.Show("Wrong matrix dimensions");
            }
            else
            {
                for (int i = 0; i < i1; i++)
                {
                    for (int j = 0; j < j1; j++)
                    {
                        matrix3[i, j].Visible = true;
                        matrix3[i, j].Enabled = true;

                        matrix3[i, j].Text = (int.Parse(matrix1[i, j].Text) - int.Parse(matrix2[i, j].Text)).ToString();
                    }
                }
            }

        }

        private void buttonX_Click(object sender, EventArgs e)
        {

            int value;

            if (columns1.Text == rows2.Text)
            {
                
                for (int i=0; i<i1; i++)
                {
                    for (int j=0; j<j1; j++)
                    {
                        if (matrix1[i,j].Text == "")
                        {
                            matrix1[i, j].Text = "0";
                        }                        
                    }
                }

                for (int i=0; i<i2; i++)
                {
                    for (int j=0; j<j2; j++)
                    {
                        if (matrix2[i, j].Text == "")
                        {
                            matrix2[i, j].Text = "0";
                        }
                    }
                }

                for (int i=0; i<i1; i++)
                {
                    for (int j=0; j<j2; j++)
                    {
                        matrix3[i, j].Enabled = true;
                        matrix3[i, j].Visible = true;
                    }
                }

                for (int i=0; i<i1; i++)
                {
                    for (int j=0; j<j2; j++)
                    {
                        value = 0;
                        for (int k=0; k<j1; k++)
                        {
                            value += (int.Parse(matrix1[i, k].Text) * int.Parse(matrix2[k, j].Text));
                            matrix3[i, j].Text = value.ToString();
                        }
                    }
                }

            }

            else
            {
                MessageBox.Show("Wrong matrix dimensions");
            }

        }

        private void buttonGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/GingerCRO/");
        }
    }
}
