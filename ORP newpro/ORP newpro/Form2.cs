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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
           

        }

        private void Bt_PricE_Click(object sender, EventArgs e)
        {
            double Mobile;//กำหนดตัวแปรMobile ชนิดdouble 
            bool We = double.TryParse(TB_MOBILE.Text, out Mobile);//ใช้ bool เพื่อตรวจสอบข้อเท็จจริง ใช้ TryParseเพื่อลองแปลงค่า จากTB_MOBILE
            if (TB_MOBILE.Text == "" || TB_NamE.Text == "" || TB_Sit.Text == "")//สร้างเงื่อนไข ถ้าหาก มีช่องใดช่องหนึ่งว่างหรือยังไม่กรอกข้อมูล 
            {
               
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "ข้อมูลไม่ถูกต้อง!!");//ให้แสดงข้อมความบน MessageBox ว่า "กรุณากรอกข้อมูลให้ครบ", "ข้อมูลไม่ถูกต้อง!!
            }
            else if (We == false)//ถ้าเข้าเงื่อนไข  We == false

            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "ข้อมูลไม่ถูกต้อง!!");//ให้แสดงข้อมความบน MessageBox ว่า"กรุณากรอกข้อมูลให้ครบ", "ข้อมูลไม่ถูกต้อง!!"
                TB_MOBILE.Clear();//ลบข้อความบน TB_MOBILE
                TB_NamE.Clear();//ลบข้อความบน TB_NamE

            }


            else   //หากไม่เข้าเงื่อนไขกรณีใดๆ
            {
                File.WriteAllText("NAME.txt", TB_NamE.Text);//เขียนข้อความที่อยู่บนTB_NamE เก็บไว้ในNAME.txt
                File.WriteAllText("NumberMobile.txt", TB_MOBILE.Text);//เขียนข้อความที่อยู่บนTB_MOBILE เก็บไว้ในNumberMobile.txt
                File.WriteAllText("SeatNumber.txt", TB_Sit.Text);//เขียนข้อความที่อยู่บนTB_Sit เก็บไว้ในSeatNumber.txt



                int Seate; //สร้างตัวแปร ชื่อ Seate ชนิด int
                bool ssa = int.TryParse(TB_Sit.Text, out Seate);//ใช้ bool เพื่อตรวจสอบข้อเท็จจริง ใช้ TryParseเพื่อลองแปลงค่า จากTB_Sit
                if (Seate >= 1 && Seate <= 13)//สร้างเงืื่อนไข ถ้าSeate >= 1 และ Seate <= 13
                {
                    MessageBox.Show("ยืนยันจำนวนที่นั่ง");//ให้แสดงข้อมความบน MessageBox ว่า ยืนยันจำนวนที่นั่ง
                    Form4 Rt4 = new Form4(); //เรียกใช้ฟังก์ชั่นจาก Form4
                    string Seat = File.ReadAllText("SeatNumber.txt");//สร้างตัวแปร Seat ชนิดint ดึงข้อมูลจาก SeatNumber.txt ไปเก็บไว้ใน Seat
                    string Price = File.ReadAllText("Price.txt");//สร้างตัวแปร  Price ชนิดint ดึงข้อมูลจาก Price.txt ไปเก็บไว้ใน Price
                    int price = int.Parse(Price);//แปลงค่า Price ให้เป็นตัวเลข เก็บไว้ใน price
                    int seat = int.Parse(Seat);//แปลงค่าSeat  ให้เป็นตัวเลข เก็บไว้ใน seat 
                    int total = price * seat;//สร้างตัวแปร ชื่อ total ชนิดint เก็บผลคุณของสมการprice * seat
                    File.WriteAllText("Price.txt", total.ToString());//จะเก็บข้อมูลที่ได้จากPrice.txt

                    Rt4.LB_NAME.Text = File.ReadAllText("NAME.txt");//ใช้ File.ReadAllText เพื่อจะดึงข้อมูลจาก NAME.txt มาใช้แสดงบน LB_NAME 
                    Rt4.LB_MOBIE.Text = File.ReadAllText("NumberMobile.txt");//ใช้ File.ReadAllText เพื่อจะดึงข้อมูลจาก NumberMobile.txt มาใช้แสดงบน LB_MOBIE
                    Rt4.LB_PRICE.Text = File.ReadAllText("Price.txt");//ใช้ File.ReadAllText เพื่อจะดึงข้อมูลจาก Price.txt มาใช้แสดงบน LB_PRICE
                    Rt4.LB_SIT.Text = File.ReadAllText("SeatNumber.txt");//ใช้ File.ReadAllText เพื่อจะดึงข้อมูลจาก SeatNumber.txtมาใช้แสดงบน LB_SIT
                    Rt4.LB_TIME.Text = File.ReadAllText("TimeOut.txt");//ใช้ File.ReadAllText เพื่อจะดึงข้อมูลจาก TimeOut.txt มาใช้แสดงบน LB_TIME
                    Rt4.LB_Bus.Text = File.ReadAllText("Bus.txt");//ใช้ File.ReadAllText เพื่อจะดึงข้อมูลจาก Bus.txt มาใช้แสดงบน LB_Bus
                    Rt4.LB_SIT7.Text = File.ReadAllText("Go.txt");//ใช้ File.ReadAllText เพื่อจะดึงข้อมูลจาก Go.txt มาใช้แสดงบน LB_SIT
                    Rt4.ShowDialog();//แสดงหน้าForm4

                }
                else //ถ้าหากไม่เข้าเงื่อนไขใดๆ 
                {

                    MessageBox.Show("กรุณากรอกจำนวนที่นั่งให้ถูกต้อง\r\r(จำนวนที่นั่งมีเพียง 13 ที่นั่ง/เที่ยว)", "ข้อมูลไม่ถูกต้อง!!");//ให้แสดงข้อมความบน MessageBox ว่ากรุณากรอกจำนวนที่นั่งให้ถูกต้อง (จำนวนที่นั่งมีเพียง 13 ที่นั่ง/เที่ยว)
                    TB_Sit.Clear();//ลบข้อความบนTB_Sit
                }
                
                    
                   
                    
                   
            }

           
            
        }

        private void TB_NamE_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TB_MOBILE_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();//ปิดหน้าฟอร์มนี้
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TB_Sit_TextChanged(object sender, EventArgs e)
        {
           
           
            
        }
    }
}
