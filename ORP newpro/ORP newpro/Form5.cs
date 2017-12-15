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
    public partial class From5 : Form
    {
        public From5()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "ท่าบ่อ-หนองคาย");//เมื่อคลิกปุ่ม จะให้ข้อความว่า ท่าบ่อ-หนองคาย ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "07.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 07.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "242-15");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 242-15 ไปเก็บใน Bus.txt
            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog(); //ใช้คำสั่ง ShowDialog เปิดForm2
        }

        private void button8_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "ท่าบ่อ-หนองคาย");//เมื่อคลิกปุ่ม จะให้ข้อความว่า ท่าบ่อ-หนองคาย ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "09.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 09.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "242-44");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 242-44 ไปเก็บใน Bus.txt
            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog();//ใช้คำสั่ง ShowDialog เปิดForm2
        }

        private void button9_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "ท่าบ่อ-หนองคาย");//เมื่อคลิกปุ่ม จะให้ข้อความว่า ท่าบ่อ-หนองคาย ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "11.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 11.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "242-16");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 242-16 ไปเก็บใน Bus.txt
            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog();//ใช้คำสั่ง ShowDialog เปิดForm2
        }

        private void button10_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "ท่าบ่อ-หนองคาย");//เมื่อคลิกปุ่ม จะให้ข้อความว่า ท่าบ่อ-หนองคาย ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "13.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 13.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "242-21");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 242-21 ไปเก็บใน Bus.txt
            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog();//ใช้คำสั่ง ShowDialog เปิดForm2
        }

        private void button11_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "ท่าบ่อ-หนองคาย");//เมื่อคลิกปุ่ม จะให้ข้อความว่า ท่าบ่อ-หนองคาย ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "15.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 15.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "242-14");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 242-14 ไปเก็บใน Bus.txt
            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog();//ใช้คำสั่ง ShowDialog เปิดForm2
        }

        private void button12_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "ท่าบ่อ-หนองคาย");//เมื่อคลิกปุ่ม จะให้ข้อความว่า ท่าบ่อ-หนองคาย ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "17.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 17.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "242-13");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 242-13 ไปเก็บใน Bus.txt
            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog();//ใช้คำสั่ง ShowDialog เปิดForm2
        }

        private void ProMot2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();//ปิดหน้าฟอร์มนี้
        }
    }
}
