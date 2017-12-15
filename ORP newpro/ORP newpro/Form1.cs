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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "หนองคาย-ท่าบ่อ");//เมื่อคลิกปุ่ม จะให้ข้อความว่า หนองคาย-ท่าบ่อ ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "07.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 07.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "242-7");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 242-7 ไปเก็บใน Bus.txt
            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog();//แสดงหน้าForm2



        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "หนองคาย-ท่าบ่อ");//เมื่อคลิกปุ่ม จะให้ข้อความว่า หนองคาย-ท่าบ่อ ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "09.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 09.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "242-12");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 242-12 ไปเก็บใน Bus.txt

            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog();//แสดงหน้าForm2
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "หนองคาย-ท่าบ่อ");//เมื่อคลิกปุ่ม จะให้ข้อความว่า หนองคาย-ท่าบ่อ ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "11.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 11.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "242-9");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 242-9 ไปเก็บใน Bus.txt
            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog();//แสดงหน้าForm2
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "หนองคาย-ท่าบ่อ");//เมื่อคลิกปุ่ม จะให้ข้อความว่า หนองคาย-ท่าบ่อ ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "13.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 13.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "242-11");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 242-11 ไปเก็บใน Bus.txt
            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog();//แสดงหน้าForm2
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "หนองคาย-ท่าบ่อ");//เมื่อคลิกปุ่ม จะให้ข้อความว่า หนองคาย-ท่าบ่อ ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "15.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 15.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "242-3");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 242-3 ไปเก็บใน Bus.txt
            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog();//แสดงหน้าForm2
        }

        private void button6_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Go.txt", "หนองคาย-ท่าบ่อ");//เมื่อคลิกปุ่ม จะให้ข้อความว่า หนองคาย-ท่าบ่อ ไปเก็บใน Go.txt
            File.WriteAllText("TimeOut.txt", "17.00น.");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 17.00น. ไปเก็บใน TimeOut.txt
            File.WriteAllText("Bus.txt", "242-5");//เมื่อคลิกปุ่ม จะให้ข้อความว่า 242-5 ไปเก็บใน Bus.txt
            Form2 Rt2 = new Form2();//สร้างตัวแปร Rt2 เพื่อนำฟังก์ชั่นในForm2ทั้งหมดมาใช้
            Rt2.ShowDialog();//แสดงหน้าForm2
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();//ปิดหน้านี้
        }
    }
}
