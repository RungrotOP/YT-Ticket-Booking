using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ORP_newpro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Price.txt", "30");//เมื่อคลิกปุ่ม จะให้เก็บราคา 30  ไปเก็บใน Price.txt
            Form1 Rt1 = new Form1();//สร้างตัวแปร Rt1 เพื่อนำฟังก์ชั่นในForm1 ทั้งหมดมาใช้
            Rt1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Price.txt", "30");//เมื่อคลิกปุ่ม จะให้เก็บราคา 30  ไปเก็บใน Price.txt
            From5 Rt5 = new From5();//สร้างตัวแปร Rt5 เพื่อนำฟังก์ชั่นในForm5 ทั้งหมดมาใช้
            Rt5.ShowDialog();//ใช้คำสั่ง ShowDialog เปิดForm5
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Price.txt", "80");//เมื่อคลิกปุ่ม จะให้เก็บราคา 80  ไปเก็บใน Price.txt
            Form6 Rt6 = new Form6();//สร้างตัวแปร Rt6 เพื่อนำฟังก์ชั่นในForm6 ทั้งหมดมาใช้
            Rt6.ShowDialog();//ใช้คำสั่ง ShowDialog เปิดForm6
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Price.txt", "80");//เมื่อคลิกปุ่ม จะให้เก็บราคา 80  ไปเก็บใน Price.txt
            Form7 Rt7 = new Form7();//สร้างตัวแปร Rt7 เพื่อนำฟังก์ชั่นในForm7 ทั้งหมดมาใช้
            Rt7.ShowDialog();//ใช้คำสั่ง ShowDialog เปิดForm7
        }

        private void PT1_Click(object sender, EventArgs e)
        {
            Close();Environment.Exit(0);//ปิดออกจากโปรแกรม
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            Form8 RT8 = new Form8();//สร้างตัวแปร RT8 เพื่อนำฟังก์ชั่นในForm8 ทั้งหมดมาใช้
            RT8.ShowDialog();//ใช้คำสั่ง ShowDialog เปิดForm8
        }
    }
}
