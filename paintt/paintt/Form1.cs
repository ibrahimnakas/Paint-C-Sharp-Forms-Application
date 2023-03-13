using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color renk;
        int kalinlik;
        Point basnokta, bitnokta;

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult tus = cd.ShowDialog();
            if (tus == DialogResult.OK)
            {
                renk = cd.Color;
                button1.BackColor = renk;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                basnokta = new Point(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LemonChiffon;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bitnokta = new Point(e.X, e.Y);
                Graphics cizim = pictureBox1.CreateGraphics();
                renk = button1.BackColor;
                kalinlik = Convert.ToInt32(comboBox1.Text);
                Pen kalem = new Pen(renk , kalinlik);
                SolidBrush firca = new SolidBrush(renk);

                if (radioButton1.Checked==true)
                {
                    cizim.DrawLine(kalem , basnokta ,bitnokta);
                }
                else
                {
                    if (radioButton4.Checked==true)
                    {
                        if (radioButton2.Checked==true)
                        {
                            int genislik = 0, yukseklik = 0;
                            if ((bitnokta.X > basnokta.X) && (bitnokta.Y > basnokta.Y))
                            {
                                genislik = bitnokta.X - basnokta.X;
                                yukseklik = bitnokta.Y - basnokta.Y;
                                cizim.DrawRectangle(kalem , basnokta.X , basnokta.Y , genislik , yukseklik);
                            }
                            else if ((basnokta.X > bitnokta.X) && (basnokta.Y > bitnokta.Y))
                            {
                                genislik = basnokta.X - bitnokta.X;
                                yukseklik = basnokta.Y - bitnokta.Y;
                                cizim.DrawRectangle(kalem, bitnokta.X, bitnokta.Y, genislik, yukseklik);
                            }
                        }
                        else if (radioButton3.Checked == true)
                        {
                            int genislik = 0, yukseklik = 0;
                            if ((bitnokta.X > basnokta.X) && (bitnokta.Y > basnokta.Y))
                            {
                                genislik = bitnokta.X - basnokta.X;
                                yukseklik = bitnokta.Y - basnokta.Y;
                                cizim.DrawEllipse(kalem, basnokta.X, basnokta.Y, genislik, yukseklik);
                            }
                            else if ((basnokta.X > bitnokta.X) && (basnokta.Y > bitnokta.Y))
                            {
                                genislik = basnokta.X - bitnokta.X;
                                yukseklik= basnokta.Y - bitnokta.Y;
                                cizim.DrawEllipse(kalem, bitnokta.X, bitnokta.Y, genislik, yukseklik);
                            }
                        }
                    }
                    else
                    {
                        if (radioButton2.Checked==true)
                        {
                            int genislik = 0, yukseklik = 0;
                            if ((bitnokta.X > basnokta.X) && (bitnokta.Y > basnokta.Y))
                            {
                                genislik = bitnokta.X - basnokta.X;
                                yukseklik = bitnokta.Y - basnokta.Y;
                                cizim.FillRectangle(firca, basnokta.X, basnokta.Y, genislik, yukseklik);
                            }
                            else if ((basnokta.X > bitnokta.X) && (basnokta.Y > bitnokta.Y))
                            {
                                genislik = basnokta.X - bitnokta.X;
                                yukseklik = basnokta.Y - bitnokta.Y;
                                cizim.FillRectangle(firca, bitnokta.X, bitnokta.Y, genislik, yukseklik);
                            }
                        }
                        else if (radioButton3.Checked==true)
                        {
                            int genislik = 0, yukseklik = 0;
                            if ((bitnokta.X > basnokta.X) && (bitnokta.Y > basnokta.Y))
                            {
                                genislik = bitnokta.X - basnokta.X;
                                yukseklik = bitnokta.Y - basnokta.Y;
                                cizim.FillEllipse(firca, basnokta.X, basnokta.Y, genislik, yukseklik);
                            }
                            else if ((basnokta.X > bitnokta.X) && (basnokta.Y > bitnokta.Y))
                            {
                                genislik = basnokta.X - bitnokta.X;
                                yukseklik = basnokta.Y - bitnokta.Y;
                                cizim.FillEllipse(firca, bitnokta.X, bitnokta.Y, genislik, yukseklik);
                            }
                        }
                    }
                    cizim.Dispose();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }
    }
}
