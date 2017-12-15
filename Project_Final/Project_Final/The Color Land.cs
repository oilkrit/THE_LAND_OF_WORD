using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Project_Final.Properties;

namespace Project_Final
{
    public partial class The_Color_Land : Form
    {
        //นำไฟล์เสียงที่ชื่อ ...(.wav) มาเก็บไว้ในตัวเเปล s(...)  
        SoundPlayer black = new SoundPlayer("black.wav");
        SoundPlayer green = new SoundPlayer("green.wav");
        SoundPlayer yellow = new SoundPlayer("yellow.wav");
        SoundPlayer darkblue = new SoundPlayer("dark blue.wav");
        SoundPlayer white = new SoundPlayer("white.wav");
        SoundPlayer orange = new SoundPlayer("orange.wav");
        SoundPlayer brown = new SoundPlayer("brown.wav");
        SoundPlayer blue = new SoundPlayer("blue.wav");
        SoundPlayer gray = new SoundPlayer("gray.wav");
        SoundPlayer red = new SoundPlayer("red.wav");
        SoundPlayer purple = new SoundPlayer("purple.wav");
        SoundPlayer pink = new SoundPlayer("pink.wav");
        SoundPlayer silver = new SoundPlayer("silver.wav");
        SoundPlayer gold = new SoundPlayer("gold.wav");

        string[] color;//ประกาศ ตัวเเปลในรูปเเบบของอาเรย์
        string[] reading;//ประกาศ ตัวเเปลในรูปเเบบของอาเรย์
        string[] thaiword;//ประกาศ ตัวเเปลในรูปเเบบของอาเรย์
        string statuspicc;//ประกาศตัวเเปล ชื่อ statuspicc
        public The_Color_Land()
        {
            InitializeComponent();
            color = new string[] { "Black", "Brown", "Green", "Orange", "White", "dark Blue", "Yellow", "Blue", "Gold", "Pink", "Red", "Purple", "Gray", "Silver" };//เก็บข้อมูลลงในตัวเเปล color ในรูปเเบบของอาเรย์
            reading = new string[] { "บะเเล็กคึ", "บราว", "กรีน", "ออ-เร้น", "ไวทึ", "บลู", "ด้าก-บลู", "โกวดึ", "เยล-โล่", "พิ้งค์", "เรด", "เพอ-เพิว", "เกรย์", "ซิน-เว่อร์" };//เก็บข้อมูลลงในตัวเเปล  reading ในรูปเเบบของอาเรย์
            thaiword = new string[] { "สีดำ", "สีเขียว", "สีเหลือง", "สีน้ำเงิน", "สีขาว", "สีส้ม", "สีน้ำตาล", "สีฟ้า", "สีเทา", "สีเเดง", "สีม่วง", "สีชมพู", "สีเงิน", "สีทอง" };//เก็บข้อมูลลงในตัวเเปล  thaiword ในรูปเเบบของอาเรย์






        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            black.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล black เล่น 
            textBox1.Text = color[0].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 0 (อาเรย์)
            textBox2.Text = reading[0].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 0 (อาเรย์)
            textBox3.Text = thaiword[0].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 0 (อาเรย์)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            green.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
            textBox1.Text = color[2].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 2 (อาเรย์)
            textBox2.Text = reading[2].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 2 (อาเรย์)
            textBox3.Text = thaiword[1].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 1 (อาเรย์)
        }

        private void button11_Click(object sender, EventArgs e)
        {
            yellow.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
            textBox1.Text = color[6].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 6 (อาเรย์)
            textBox2.Text = reading[8].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 8 (อาเรย์)
            textBox3.Text = thaiword[2].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 2 (อาเรย์)
        }

        private void button15_Click(object sender, EventArgs e)
        {
            darkblue.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
            textBox1.Text = color[5].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 5 (อาเรย์)
            textBox2.Text = reading[6].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 6 (อาเรย์)
            textBox3.Text = thaiword[3].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 3 (อาเรย์)
        }

        private void button5_Click(object sender, EventArgs e)
        {
            white.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
            textBox1.Text = color[4].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 4 (อาเรย์)
            textBox2.Text = reading[4].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 4 (อาเรย์)
            textBox3.Text = thaiword[4].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 4 (อาเรย์)
        }

        private void button8_Click(object sender, EventArgs e)
        {
            orange.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
            textBox1.Text = color[3].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 3 (อาเรย์)
            textBox2.Text = reading[3].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 3 (อาเรย์)
            textBox3.Text = thaiword[5].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 5 (อาเรย์)
        }

        private void button12_Click(object sender, EventArgs e)
        {
            brown.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
            textBox1.Text = color[1].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 1 (อาเรย์)
            textBox2.Text = reading[1].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 1 (อาเรย์)
            textBox3.Text = thaiword[6].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 6 (อาเรย์)
        }

        private void button16_Click(object sender, EventArgs e)
        {
            blue.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
            textBox1.Text = color[7].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 7 (อาเรย์)
            textBox2.Text = reading[5].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 5 (อาเรย์)
            textBox3.Text = thaiword[7].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 7 (อาเรย์)
        }

        private void button18_Click(object sender, EventArgs e)
        {
            gray.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
            textBox1.Text = color[12].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 12 (อาเรย์)
            textBox2.Text = reading[12].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 12 (อาเรย์)
            textBox3.Text = thaiword[8].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 8 (อาเรย์)
        }

        private void button9_Click(object sender, EventArgs e)
        {
            red.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
            textBox1.Text = color[10].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 10 (อาเรย์)
            textBox2.Text = reading[10].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 10 (อาเรย์)
            textBox3.Text = thaiword[9].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 9 (อาเรย์)
        }

        private void button13_Click(object sender, EventArgs e)
        {
            purple.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
            textBox1.Text = color[11].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 11 (อาเรย์)
            textBox2.Text = reading[11].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 11 (อาเรย์)
            textBox3.Text = thaiword[10].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 10 (อาเรย์)
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pink.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
            textBox1.Text = color[9].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 9 (อาเรย์)
            textBox2.Text = reading[9].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 9 (อาเรย์)
            textBox3.Text = thaiword[11].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 11 (อาเรย์)
        }

        private void button6_Click(object sender, EventArgs e)
        {
            silver.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
            textBox1.Text = color[13].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 13 (อาเรย์)
            textBox2.Text = reading[13].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 13 (อาเรย์)
            textBox3.Text = thaiword[12].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 12 (อาเรย์)
        }

        private void button14_Click(object sender, EventArgs e)
        {
            gold.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
            textBox1.Text = color[8].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในตัวเเปล color ในตำเเหน่งที่ 8 (อาเรย์)
            textBox2.Text = reading[7].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox2 ให้เเสดงข้อมูลในตัวเเปล reading ในตำเเหน่งที่ 7 (อาเรย์)
            textBox3.Text = thaiword[13].ToString();//เมื่อกดปุ่มที่ชื่อว่า textBox3 ให้เเสดงข้อมูลในตัวเเปล thaiword ในตำเเหน่งที่ 13 (อาเรย์)
        }

        private void button104_Click(object sender, EventArgs e)
        {
            Close();//คำสั่งออกจากหน้านั้นๆ
        }

        private void button21_Click(object sender, EventArgs e)
        {
            pictureBoxcolor.Visible = true;//คำสั่งให้เเสดงปุ่ม pictureBoxcolor (ก่อนหน้านี้ได้ปิดไว้)
            textBoxcolor.Visible = true;//คำสั่งให้เเสดงปุ่ม textBoxcolor (ก่อนหน้านี้ได้ปิดไว้)
            btnstart.Visible = false;//คำสั่งให้ปิดปุ่ม btnstart (ก่อนหน้านี้ได้เปิดไว้)
            buttonokcolor.Visible = true;//คำสั่งให้เเสดงปุ่ม buttonokcolo (ก่อนหน้านี้ได้ปิดไว้)
            Randommm();//ตัวเเปล ของเมดตอด ในตัวเเปลตัวนี้จะมีคำสั่งให้สุ่ม
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if(textBoxcolor.Text.ToUpper()==statuspicc)//เงื่อนไข ในกรณีที่ตัวหนังสือที่กรอกเข้ามาตรงกับ ค่าที่อยู่ใน statuspic
            {
                MessageBox.Show("ถูกต้อง");//คำสั่งเเสดง messege ใน messege เเสดงคำว่า ถูกต้อง
                Randommm();//ตัวเเปล ของเมดตอด ในตัวเเปลตัวนี้จะมีคำสั่งให้สุ่ม
            }
            else//ในกรณีที่ไม่ตรงกับเงื่อนไข
            {
                MessageBox.Show("ผิด");//คำสั่งเเสดง messege ใน messege เเสดงคำว่า ผิด
            }
        }
        void Randommm()//กำหนดเมดตอดที่ชื่อว่า Randommm
        {
            Random rancolor = new Random();//ประกาศคำสั่งสุ่มที่มีตัวเเปลชื่อว่า rancolor 
            int soomcolor = rancolor.Next(1,14);//ประกาศตัวเเปลที่ชื่อว่า soomcolor เเละให้นำค่าที่อยู่ใน rancolor ที่ได้จากการสุ่ม มาเก็บไว้ใน soomcolor
            switch (soomcolor)//คำสั่งเงื่อนไข(ตรวจสอบตัวเเปล soomcolor)
            {
                //จากเคสที่ 1-13 เป็นคำสั่งเเสดงภาพใน pictureBoxcolor เเละ กำหนดค่าในตัวเเปล statuspic
                case 1:
                    pictureBoxcolor.Image = Resources.cblack;
                    statuspicc = "BLACK";
                    break;

                case 2:
                    pictureBoxcolor.Image = Resources.cgreen;
                    statuspicc = "GREEN";
                    break;

                case 3:
                    pictureBoxcolor.Image =Resources.cyellow;
                    statuspicc = "YELLOW";
                    break;

                case 4:
                   pictureBoxcolor.Image = Resources.cdarkblue;
                    statuspicc = "DARK BLUE";
                    break;

                case 5:
                   pictureBoxcolor.Image = Resources.cwhite;
                    statuspicc = "WHITE";
                    break;

                case 6:
                    pictureBoxcolor.Image = Resources.corange;
                    statuspicc = "ORANGE";
                    break;

                case 7:
                   pictureBoxcolor.Image = Resources.cbrown;
                    statuspicc = "BROWN";
                    break;

                case 8:
                    pictureBoxcolor.Image =Resources.cblue;
                    statuspicc = "BLUE";
                    break;

                case 9:
                   pictureBoxcolor.Image = Resources.cgray;
                    statuspicc = "GRAY";
                    break;

                case 10:
                  pictureBoxcolor.Image = Resources.cred;
                    statuspicc = "RED";
                    break;

                case 11:
                 pictureBoxcolor.Image = Resources.cpurple;
                    statuspicc = "PURPLE";
                    break;

                case 12:
                   pictureBoxcolor.Image = Resources.cpink;
                    statuspicc = "PINK";
                    break;

                case 13:
                   pictureBoxcolor.Image =Resources.cgold;
                    statuspicc = "GOLD";
                    break;
            }
        }
        
       
    } 
    
}        

        
    

