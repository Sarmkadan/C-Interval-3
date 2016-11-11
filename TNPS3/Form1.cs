using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TNPS3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<float> fZagList = new List<float>();
        public string l2 = "";
        public List<float> firstemp = new List<float>(); 
        private void button1_Click(object sender, EventArgs e)
        { 
            /*firstemp.Add(float.Parse(textBox1.Text));
            firstemp.Add(float.Parse(textBox2.Text));
            firstemp.Add(float.Parse(textBox3.Text));
            firstemp.Add(float.Parse(textBox4.Text));
            firstemp.Add(float.Parse(textBox5.Text));
            firstemp.Add(float.Parse(textBox6.Text));*/
            firstemp.Add(1f);
            firstemp.Add(20f);
            firstemp.Add(30f);
            firstemp.Add(40f);
            firstemp.Add(60f);
            firstemp.Add(80f);

            textBox1.Text = stepen(textBox1.Text);
            textBox2.Text = stepen(textBox2.Text);
            textBox3.Text = stepen(textBox3.Text);
            textBox4.Text = stepen(textBox4.Text);
            textBox5.Text = stepen(textBox5.Text);
            textBox6.Text = stepen(textBox6.Text);//l2
            l2 = textBox2.Text;
        }
        public static string stepen(string input)
        {
            return Math.Round(Math.Pow(float.Parse(input), -1),4).ToString();
        }
        public static string  stepene(string input,string input2)
        {
            return Math.Round(Math.Pow(Math.E, -float.Parse(input)*float.Parse(input2)),4).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {   
            textBox1.Text = stepene(textBox1.Text,textBox7.Text);
            textBox2.Text = stepene(textBox2.Text,textBox7.Text);
            textBox3.Text = stepene(textBox3.Text, textBox7.Text);
            textBox4.Text = stepene(textBox4.Text, textBox7.Text);
            textBox5.Text = stepene(textBox5.Text, textBox7.Text);
            textBox6.Text = stepene(textBox6.Text, textBox7.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            fZagList.Clear();
            pzag(textBox13.Text,textBox1.Text);
            pzag(textBox12.Text,textBox2.Text);
            pzag(textBox11.Text,textBox3.Text);
            pzag(textBox10.Text,textBox4.Text);
            pzag(textBox9.Text,textBox5.Text);
            pzag(textBox8.Text,textBox6.Text);
            float endP = fZagList[0];
            for (int i = 1; i < fZagList.Count; i++)
            {
                endP = endP * fZagList[i];
            }
            textBox14.Text = endP.ToString();
        }
        public void pzag(string input,string output)
        {
            if (input!="")
            {
                float temp1 = float.Parse(1.ToString())-float.Parse(output);
                temp1 = (float)Math.Pow(temp1, float.Parse(input));
                fZagList.Add(1-temp1);
            }
            else
            {
                fZagList.Add(float.Parse(output));
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox15.Text = (string)(float.Parse(l2)*float.Parse(textBox16.Text)).ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            float temp1 = (float.Parse("1")/float.Parse(l2));  //+
            float temp2 = float.Parse(l2)*float.Parse(textBox15.Text);
            float temp22 = 0.5f;
            float temp3 = (temp22/temp2);
            float temp4 = temp1 + temp3;
            textBox18.Text = temp4.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            float temp1 = (float) Math.Pow(Math.E, -float.Parse(textBox7.Text)/float.Parse(textBox18.Text));
            textBox17.Text = temp1.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fZagList.Clear();
            pzag(textBox13.Text, textBox1.Text);

            // pzag(textBox17.Text, textBox2.Text);
            fZagList.Add(float.Parse(textBox17.Text));

            pzag(textBox11.Text, textBox3.Text);
            pzag(textBox10.Text, textBox4.Text);
            pzag(textBox9.Text, textBox5.Text);
            pzag(textBox8.Text, textBox6.Text);
            float endP = fZagList[0];
            for (int i = 1; i < fZagList.Count; i++)
            {
                endP = endP * fZagList[i];
            }
            textBox19.Text = endP.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox25.Text = GetNady(textBox1.Text,textBox13.Text);
            //textBox24.Text = GetNady(textBox2.Text, textBox12.Text);
            textBox24.Text = textBox17.Text;
            textBox23.Text = GetNady(textBox3.Text, textBox11.Text);
            textBox22.Text = GetNady(textBox4.Text, textBox10.Text);
            textBox21.Text = GetNady(textBox5.Text, textBox9.Text);
            textBox20.Text = GetNady(textBox6.Text, textBox8.Text);
        }

        private static string GetNady(string value1, string value2)
        {
            if (value2=="")
            {
                return value1;
            }
            else if (float.Parse(value2)>=2)
            {
                float temp1 = float.Parse(1.ToString()) - float.Parse(value1);
                temp1 = (float)Math.Pow(temp1, float.Parse(value2));
                return (1 - temp1).ToString();
            }
            return null;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox31.Text = (Math.Round(-Math.Log(float.Parse(textBox25.Text))/float.Parse(textBox7.Text),4)).ToString();
            textBox30.Text = (Math.Round(- Math.Log(float.Parse(textBox24.Text)) / float.Parse(textBox7.Text),4)).ToString();
            textBox29.Text = (Math.Round(- Math.Log(float.Parse(textBox23.Text)) / float.Parse(textBox7.Text),4)).ToString();
            textBox28.Text = (Math.Round(- Math.Log(float.Parse(textBox22.Text)) / float.Parse(textBox7.Text),4)).ToString();
            textBox27.Text = (Math.Round(-Math.Log(float.Parse(textBox21.Text)) / float.Parse(textBox7.Text),4)).ToString();
            textBox26.Text = (Math.Round (- Math.Log(float.Parse(textBox20.Text)) / float.Parse(textBox7.Text),4)).ToString();

            //Double a =  Math.Log(6);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            float sum;
            sum = float.Parse(textBox31.Text);
            sum += float.Parse(textBox30.Text);
            sum += float.Parse(textBox29.Text);
            sum += float.Parse(textBox28.Text);
            sum += float.Parse(textBox27.Text);
            sum += float.Parse(textBox26.Text);

            textBox32.Text =sum.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        List<float> temp = new List<float>();
            temp.Add(getPChanse(float.Parse(textBox32.Text), firstemp[0]));
            temp.Add(getPChanse(float.Parse(textBox32.Text), firstemp[1]));
            temp.Add(getPChanse(float.Parse(textBox32.Text), firstemp[2]));
            temp.Add(getPChanse(float.Parse(textBox32.Text), firstemp[3]));
            temp.Add(getPChanse(float.Parse(textBox32.Text), firstemp[4]));
            temp.Add(getPChanse(float.Parse(textBox32.Text), firstemp[5]));

            Form newform = new Form();
            Chart newchart = new Chart();
            newform.Controls.Add(newchart);
            newform.Show();
            newchart.Dock = DockStyle.Fill;
            newchart.ChartAreas.Add("helo world");
            newchart.Series.Add("hello world2");
            newchart.ChartAreas[0].AxisY.ScaleView.Zoom(0,1);
            newchart.ChartAreas[0].AxisX.ScaleView.Zoom(0,100);
            
           // newchart.ChartAreas[0].re
            for (int i = 0; i < temp.Count; i++)
            {

                        newchart.Series[0].Points.AddXY(firstemp[i],temp[i]);
                        newchart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            }
            /*
            for (int i = 0; i < firstemp[5]; i++)
            {
                newchart.Series[0].Points.AddXY(i, temp[2]);
                newchart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }*/

        }

        private float getPChanse(float Lambda, float i)
        {
            float part1 = (float)Math.Pow(Lambda * i, float.Parse(textBox33.Text)) / 6;
            float part2 = part1 + 1 + Lambda * i;
            float part3 = part2 + (float)Math.Pow(Lambda * i, 2) / 2;
            float part4 = part3 * (float)Math.Pow(Math.E, -Lambda * i);
            if ((float)Math.Round(part4, 7)<=1)
            {
                return (float)Math.Round(part4, 7);
            }
            else
            {
                return 1f;
            }
            
        }
        private float getPCreserv(float Lambda, float t)
        {
            float temp1 = 1f - (float)Math.Pow(1f - ((float) Math.Pow(Math.E, -Lambda*t)),float.Parse(textBox33.Text)+1f);
            if (temp1 <= 1)
            {
                return temp1;
            }
            else
            {
                return 1f;
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            List<float> temp = new List<float>();
            temp.Add(getPCreserv(float.Parse(textBox32.Text), firstemp[0]));
            temp.Add(getPCreserv(float.Parse(textBox32.Text), firstemp[1]));
            temp.Add(getPCreserv(float.Parse(textBox32.Text), firstemp[2]));
            temp.Add(getPCreserv(float.Parse(textBox32.Text), firstemp[3]));
            temp.Add(getPCreserv(float.Parse(textBox32.Text), firstemp[4]));
            temp.Add(getPCreserv(float.Parse(textBox32.Text), firstemp[5]));

            Form newform = new Form();
            Chart newchart = new Chart();
            newform.Controls.Add(newchart);
            newform.Show();
            newchart.Dock = DockStyle.Fill;
            newchart.ChartAreas.Add("helo world");
            newchart.Series.Add("hello world2");
            newchart.ChartAreas[0].AxisY.ScaleView.Zoom(0, 1);
            newchart.ChartAreas[0].AxisX.ScaleView.Zoom(0, 100);

            // newchart.ChartAreas[0].re
            for (int i = 0; i < temp.Count; i++)
            {

                newchart.Series[0].Points.AddXY(firstemp[i], temp[i]);
                newchart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            }
            /*
            for (int i = 0; i < firstemp[5]; i++)
            {
                newchart.Series[0].Points.AddXY(i, temp[2]);
                newchart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }*/
        }

        private void button13_Click(object sender, EventArgs e)
        {
            List<float> temp = new List<float>();
            temp.Add((float)Math.Pow(getPCreserv(float.Parse(textBox32.Text), firstemp[0]),6));
            temp.Add((float)Math.Pow(getPCreserv(float.Parse(textBox32.Text), firstemp[1]),6));
            temp.Add((float)Math.Pow(getPCreserv(float.Parse(textBox32.Text), firstemp[2]),6));
            temp.Add((float)Math.Pow(getPCreserv(float.Parse(textBox32.Text), firstemp[3]),6));
            temp.Add((float)Math.Pow(getPCreserv(float.Parse(textBox32.Text), firstemp[4]),6));
            temp.Add((float)Math.Pow(getPCreserv(float.Parse(textBox32.Text), firstemp[5]),6));

            Form newform = new Form();
            Chart newchart = new Chart();
            newform.Controls.Add(newchart);
            newform.Show();
            newchart.Dock = DockStyle.Fill;
            newchart.ChartAreas.Add("helo world");
            newchart.Series.Add("hello world2");
            newchart.ChartAreas[0].AxisY.ScaleView.Zoom(0, 1);
            newchart.ChartAreas[0].AxisX.ScaleView.Zoom(0, 100);

            // newchart.ChartAreas[0].re
            for (int i = 0; i < temp.Count; i++)
            {

                newchart.Series[0].Points.AddXY(firstemp[i], temp[i]);
                newchart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            }
            /*
            for (int i = 0; i < firstemp[5]; i++)
            {
                newchart.Series[0].Points.AddXY(i, temp[2]);
                newchart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }*/
        }

        private float getPCKovzne(float Lsys, float t, float m, float n)
        {
            float temp1 = (float) Math.Pow(Math.E,-(n-m)*Lsys*t );
            float temps2 = 0f;
            //var a = (float) Math.Pow((n - m)*Lsys*t, 6)/Factorial(6);
            for (int i = 6; i >= 1; i--)
            {
                 temps2 += (float) Math.Pow((n - m)*Lsys*t, i)/Factorial(i);
            }
            if (temp1 * temps2<=1)
            {
               return  temp1 * temps2;
            }
            else
            {
                return 1f;
            }
        }
        int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);

        }
        private void button14_Click(object sender, EventArgs e)
        {
            List<float> temp = new List<float>();
            temp.Add(getPCKovzne(float.Parse(textBox32.Text), firstemp[0],float.Parse(textBox33.Text),6));
            temp.Add(getPCKovzne(float.Parse(textBox32.Text), firstemp[1],float.Parse(textBox33.Text),6));
            temp.Add(getPCKovzne(float.Parse(textBox32.Text), firstemp[2],float.Parse(textBox33.Text),6));
            temp.Add(getPCKovzne(float.Parse(textBox32.Text), firstemp[3],float.Parse(textBox33.Text),6));
            temp.Add(getPCKovzne(float.Parse(textBox32.Text), firstemp[4],float.Parse(textBox33.Text),6));
            temp.Add(getPCKovzne(float.Parse(textBox32.Text), firstemp[5],float.Parse(textBox33.Text),6));

            Form newform = new Form();
            Chart newchart = new Chart();
            newform.Controls.Add(newchart);
            newform.Show();
            newchart.Dock = DockStyle.Fill;
            newchart.ChartAreas.Add("helo world");
            newchart.Series.Add("hello world2");
            newchart.ChartAreas[0].AxisY.ScaleView.Zoom(0, 1);
            newchart.ChartAreas[0].AxisX.ScaleView.Zoom(0, 100);

            // newchart.ChartAreas[0].re
            for (int i = 0; i < temp.Count; i++)
            {

                newchart.Series[0].Points.AddXY(firstemp[i], temp[i]);
                newchart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            }
            /*
            for (int i = 0; i < firstemp[5]; i++)
            {
                newchart.Series[0].Points.AddXY(i, temp[2]);
                newchart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }*/
        }
    }
}
