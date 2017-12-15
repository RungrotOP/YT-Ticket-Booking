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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Total.txt",      //เขียนข้อมูลลงใน Total.txt

               "บริษัทยันหว่างทรานสปอร์ต จำกัด" +"\r\n"+"\r\n" +     //แสดงข้อความว่า บริษัทยันหว่างทรานสปอร์ต จำกัด
                 DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd//mm//yyyy") + "\r\n" + "\r\n" + //แสดงวันที่และเวลาปัจจุบัน ในTotal.txt
                "ชื่อ - นามสกุล" + "   :  "+LB_NAME.Text+Environment.NewLine + //แสดงข้อความ ว่า ชื่อ - นามสกุล : และข้อความบนLB_NAME และใช้Environment.NewLine เพื่อเว้นบรรทัด
               "เบอร์ติดต่อ" +"   :  "+LB_MOBIE.Text+Environment.NewLine +//แสดงข้อความ ว่า เบอร์ติดต่อ : และข้อความบน LB_MOBIE และใช้Environment.NewLine เพื่อเว้นบรรทัด
               "จำนวน" +"   :  "+LB_SIT.Text+ "    "+"ที่นั่ง"+Environment.NewLine +  //แสดงข้อความ ว่า จำนวน :   ที่นั่ง และข้อความบน LB_SIT และใช้Environment.NewLine เพื่อเว้นบรรทัด
               "เวลาเดินทาง" +"   : "+ LB_TIME.Text+ Environment.NewLine + //แสดงข้อความ ว่า เวลาเดินทาง : และข้อความบนLB_TIME และใช้Environment.NewLin เพื่อเว้นบรรทัด
                "เส้นทาง" +"   : "+LB_SIT7.Text+ Environment.NewLine +//แสดงข้อความ ว่า เส้นทาง : และข้อความบน LB_SIT7 และใช้Environment.NewLine เพื่อเว้นบรรทัด
                "หมายเลขรถ" +"   :  "+LB_Bus.Text+ Environment.NewLine + //แสดงข้อความ ว่า หมายเลขรถ : และข้อความบนLB_Bus และใช้Environment.NewLine เพื่อเว้นบรรทัด
                "ราคา" +"   :  "+LB_PRICE.Text+"    "+ "บาท"+Environment.NewLine//แสดงข้อความ ว่า  ราคา :  บาท และข้อความบน LB_PRICE และใช้Environment.NewLine เพื่อเว้นบรรทัด
                );
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว","บันทึก");//แสดงข้อความบน MessageBox ว่า บันทึกข้อมูลเรียบร้อยแล้ว เมื่อคลิกปุ่มบันทึกข่อมูล

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณต้องการออกจากโปรแกรม");//แสดงข้อความบน MessageBox ว่า  คุณต้องการออกจากโปรแกรม
            Close(); Environment.Exit(0);//ปิดออกจากโปรแกรม
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();//ปิดออกจาหน้าฟอร์มนี้
        }
    }
}
