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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "สังคม-หนองคาย");//เมื่อคลิกปุ่ม จะให้ข้อความว่า หนองคาย-สังคม ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "08.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 08.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "211-4");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 211-4 ไปเก็บใน Bus.txt
            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog();//ใช้คำสั่ง ShowDialog เปิดForm2
        }

        private void button16_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "สังคม-หนองคาย");//เมื่อคลิกปุ่ม จะให้ข้อความว่า สังคม-หนองคาย ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "12.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 12.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "211-7");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 211-7 ไปเก็บใน Bus.txt
            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog();//ใช้คำสั่ง ShowDialog เปิดForm2
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();//ปิดหน้าฟอร์มนี้
        }
    }
}
