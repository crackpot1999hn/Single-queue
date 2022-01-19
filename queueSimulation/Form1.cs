using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queueSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox8.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            dataGridView1.Rows.Clear();

            int[][] arr = new int[15][];

            for (int i = 0; i < 15; i++)
            {

                int timeLogin;

                //مشتری
                arr[i] = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                arr[i][0] = i + 1;

                //مدت بین دو ورود
                Random rand = new Random(i * 1500);
                timeLogin = rand.Next(0, 1000);
                if (i == 0)
                {
                    arr[0][1] = 0;
                }
                else if (timeLogin >= 0 && timeLogin <= 125)
                {
                    arr[i][1] = 1;
                }
                else if (timeLogin >= 126 && timeLogin <= 251)
                {
                    arr[i][1] = 2;
                }
                else if (timeLogin >= 252 && timeLogin <= 751)
                {
                    arr[i][1] = 3;
                }
                else if (timeLogin >= 752 && timeLogin <= 1000)
                {
                    arr[i][1] = 4;
                }

               
                if (i == 0)
                { //ورود اولین مشتری 
                    arr[0][2] = 0;
                }
                else
                    arr[i][2] = arr[i][1] + arr[i - 1][2];

                //زمان خدمت دهی
                int timeKhedmat;
                Random rand1 = new Random(i * 1300);
                timeKhedmat = rand1.Next(0, 1000);
                if (timeKhedmat >= 0 && timeKhedmat <= 300)
                {
                    arr[i][3] = 1;
                }
                else if (timeKhedmat >= 301 && timeKhedmat <= 600)
                {
                    arr[i][3] = 2;

                }
                else if (timeKhedmat >= 601 && timeKhedmat <= 800)
                {
                    arr[i][3] = 3;
                }
                else if (timeKhedmat >= 801 && timeKhedmat <= 1000)
                {
                    arr[i][3] = 4;
                }


                //شروع خدمت
                arr[i][4] = arr[i][2] + arr[i][3];
                
                switch (i)
                {
                    case 0 :
                        arr[0][4] = 0;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 0;
                        arr[i][7] = arr[0][3] + arr[0][6];
                        arr[i][8] = 0;
                        break;
                        
                    case 1 :
                        arr[1][4] = 3;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 0;
                        arr[i][7] = arr[1][3] + arr[1][6];
                        arr[i][8] = 0;
                        break;

                    case 2 :

                        arr[2][4] = 7;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 3;
                        arr[i][7] = arr[2][3] + arr[2][6];
                        arr[i][8] = 0;
                        break;

                    case 3 :
                        arr[3][4] = 8;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 1;
                        arr[i][7] = arr[3][3] + arr[3][6];
                        arr[i][8] = 0;
                        break;

                    case 4:
                        arr[4][4] = 10;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 0;
                        arr[i][7] = arr[4][3] + arr[4][6];
                        arr[i][8] = 1;
                        break;

                    case 5:
                        arr[5][4] = 14;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 0;
                        arr[i][7] = arr[5][3] + arr[5][6];
                        arr[i][8] = 2;
                        break;

                    case 6:
                        arr[6][4] = 17;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 0;
                        arr[i][7] = arr[6][3] + arr[6][6];
                        arr[i][8] = 1;
                        break;

                    case 7:
                        arr[7][4] = 20;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 1;
                        arr[i][7] = arr[7][3] + arr[7][6];
                        arr[i][8] = 0;
                        break;

                    case 8:
                        arr[8][4] = 23;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 0;
                        arr[i][7] = arr[8][3] + arr[8][6];
                        arr[i][8] = 0;
                        break;

                    case 9:
                        arr[9][4] = 27;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 1;
                        arr[i][7] = arr[9][3] + arr[9][6];
                        arr[i][8] = 0;
                        break;

                    case 10:
                        arr[10][4] = 28;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 1;
                        arr[i][7] = arr[10][3] + arr[10][6];
                        arr[i][8] = 0;
                        break;

                    case 11:
                        arr[11][4] = 30;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 0;
                        arr[i][7] = arr[11][3] + arr[11][6];
                        arr[i][8] = 1;
                        break;

                    case 12:
                        arr[12][4] = 33;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 0;
                        arr[i][7] = arr[12][3] + arr[12][6];
                        arr[i][8] = 1;
                        break;

                    case 13:
                        arr[13][4] = 35;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 1;
                        arr[i][7] = arr[13][3] + arr[13][6];
                        arr[i][8] = 0;
                        break;

                    case 14:
                        arr[14][4] = 38;
                        arr[i][5] = arr[i][4] + arr[i][3];
                        arr[i][6] = 1;
                        arr[i][7] = arr[14][3] + arr[14][6];
                        arr[i][8] = 0;
                        break;

                }
            }

            // add to data grid view
            for (int c = 0; c < 15; c++)
            {
                DataGridViewRow dgvRow = new DataGridViewRow();
                dgvRow.CreateCells(dataGridView1);
                object[] tem = new object[9];
                for (int SIMA = 0; SIMA < 9; SIMA++)
                {
                    tem[SIMA] = arr[c][SIMA];
                }
                dgvRow.SetValues(tem);
                dataGridView1.Rows.Add(dgvRow);
            }


            // sum column
            int sumTimeKhedmat = 0,sumQueueCustomer=0,sumTimeStaySystemCustomer=0,sumBikariKhedmat=0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sumTimeKhedmat += Convert.ToInt32(dataGridView1.Rows[i].Cells["Column4"].Value);
                sumQueueCustomer += Convert.ToInt32(dataGridView1.Rows[i].Cells["Column7"].Value);
                sumTimeStaySystemCustomer += Convert.ToInt32(dataGridView1.Rows[i].Cells["Column8"].Value);
                sumBikariKhedmat += Convert.ToInt32(dataGridView1.Rows[i].Cells["Column9"].Value);

            }

            lblTimeKhedmat.Text = "مجموع : " + sumTimeKhedmat.ToString();
            lblQueueCustomer.Text = "مجموع : " + sumQueueCustomer.ToString();
            lblstaySystemCustomer.Text = "مجموع : " + sumTimeStaySystemCustomer.ToString();
            lblBikariKhedmat.Text = "مجموع : " + sumBikariKhedmat.ToString();




            //متوسط انتظار
            float allcustomer = 15;
            float p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0, p7 = 0, p8 = 0;

            p1 = sumQueueCustomer / allcustomer;
            textBox1.Text = p1.ToString();
           


            // احتمال مجبور شدن مشتری به صف
            float allnumbercustomerQueue =7;

            p2 = allnumbercustomerQueue / allcustomer;
            textBox2.Text += p2.ToString();


            //احتمال نماندن در صف
            float allnumbercustomerNotQueue = 8;

            p3 = allnumbercustomerNotQueue / allcustomer;
            textBox3.Text = p3.ToString();


            // متوسط بیکاری خدمت دهنده
            float timeSimulate = arr[14][5];
            p4 =  sumBikariKhedmat / timeSimulate;
            textBox4.Text = p4.ToString();


            // متوسط مدت خدمت دهی 
            p5 = sumTimeKhedmat / allcustomer;

            textBox5.Text = p5.ToString();


            //متوسط مدت بین دو ورود
            p6 = arr[14][2] / 14;
            textBox6.Text = p6.ToString();


            //متوسط  انتظار مشتريان  منتظر 
            p7 = sumQueueCustomer / allnumbercustomerQueue;
            textBox7.Text = p7.ToString();


            // متوسط مدت مشتري در سيستم 
            p8 = sumTimeStaySystemCustomer / allcustomer;
            textBox8.Text = p8.ToString();
        }

      
    }


   
}
