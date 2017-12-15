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
    public partial class The_Number_Land : Form
    {
        string statuspic;//ประกาศตัวเเปล ชื่อ statuspic
        //นำไฟล์เสียงที่ชื่อ ...(.wav) มาเก็บไว้ในตัวเเปล s(...)  
        SoundPlayer correct = new SoundPlayer("correct.wav");
        SoundPlayer s1 = new SoundPlayer("1.wav");
        SoundPlayer s2 = new SoundPlayer("2.wav");
        SoundPlayer s3 = new SoundPlayer("3.wav");
        SoundPlayer s4 = new SoundPlayer("4.wav");
        SoundPlayer s5 = new SoundPlayer("5.wav");
        SoundPlayer s6 = new SoundPlayer("6.wav");
        SoundPlayer s7 = new SoundPlayer("7.wav");
        SoundPlayer s8 = new SoundPlayer("8.wav");
        SoundPlayer s9 = new SoundPlayer("9.wav");
        SoundPlayer s10 = new SoundPlayer("10.wav");
        SoundPlayer s11= new SoundPlayer("11.wav");
        SoundPlayer s12 = new SoundPlayer("12.wav");
        SoundPlayer s13 = new SoundPlayer("13.wav");
        SoundPlayer s14 = new SoundPlayer("14.wav");
        SoundPlayer s15 = new SoundPlayer("15.wav");
        SoundPlayer s16 = new SoundPlayer("16.wav");
        SoundPlayer s17 = new SoundPlayer("17.wav");
        SoundPlayer s18 = new SoundPlayer("18.wav");
        SoundPlayer s19 = new SoundPlayer("19.wav");
        SoundPlayer s20 = new SoundPlayer("20.wav");
        SoundPlayer s21 = new SoundPlayer("21.wav");
        SoundPlayer s22 = new SoundPlayer("22.wav");
        SoundPlayer s23 = new SoundPlayer("23.wav");
        SoundPlayer s24 = new SoundPlayer("24.wav");
        SoundPlayer s25 = new SoundPlayer("25.wav");
        SoundPlayer s26 = new SoundPlayer("26.wav");
        SoundPlayer s27 = new SoundPlayer("27.wav");
        SoundPlayer s28 = new SoundPlayer("28.wav");
        SoundPlayer s29 = new SoundPlayer("29.wav");
        SoundPlayer s30 = new SoundPlayer("30.wav");
        SoundPlayer s31 = new SoundPlayer("31.wav");
        SoundPlayer s32 = new SoundPlayer("32.wav");
        SoundPlayer s33 = new SoundPlayer("33.wav");
        SoundPlayer s34 = new SoundPlayer("34.wav");
        SoundPlayer s35 = new SoundPlayer("35.wav");
        SoundPlayer s36 = new SoundPlayer("36.wav");
        SoundPlayer s37 = new SoundPlayer("37.wav");
        SoundPlayer s38 = new SoundPlayer("38.wav");
        SoundPlayer s39 = new SoundPlayer("39.wav");
        SoundPlayer s40 = new SoundPlayer("40.wav");
        SoundPlayer s41 = new SoundPlayer("41.wav");
        SoundPlayer s42 = new SoundPlayer("42.wav");
        SoundPlayer s43 = new SoundPlayer("43.wav");
        SoundPlayer s44 = new SoundPlayer("44.wav");
        SoundPlayer s45 = new SoundPlayer("45.wav");
        SoundPlayer s46 = new SoundPlayer("46.wav");
        SoundPlayer s47 = new SoundPlayer("47.wav");
        SoundPlayer s48 = new SoundPlayer("48.wav");
        SoundPlayer s49 = new SoundPlayer("49.wav");
        SoundPlayer s50 = new SoundPlayer("50.wav");
        SoundPlayer s51 = new SoundPlayer("51.wav");
        SoundPlayer s52 = new SoundPlayer("52.wav");
        SoundPlayer s53 = new SoundPlayer("53.wav");
        SoundPlayer s54 = new SoundPlayer("54.wav");
        SoundPlayer s55 = new SoundPlayer("55.wav");
        SoundPlayer s56 = new SoundPlayer("56.wav");
        SoundPlayer s57 = new SoundPlayer("57.wav");
        SoundPlayer s58 = new SoundPlayer("58.wav");
        SoundPlayer s59 = new SoundPlayer("59.wav");
        SoundPlayer s60 = new SoundPlayer("60.wav");
        SoundPlayer s61 = new SoundPlayer("61.wav");
        SoundPlayer s62 = new SoundPlayer("62.wav");
        SoundPlayer s63 = new SoundPlayer("63.wav");
        SoundPlayer s64 = new SoundPlayer("64.wav");
        SoundPlayer s65 = new SoundPlayer("65.wav");
        SoundPlayer s66 = new SoundPlayer("66.wav");
        SoundPlayer s67 = new SoundPlayer("67.wav");
        SoundPlayer s68 = new SoundPlayer("68.wav");
        SoundPlayer s69 = new SoundPlayer("69.wav");
        SoundPlayer s70 = new SoundPlayer("70.wav");
        SoundPlayer s71 = new SoundPlayer("71.wav");
        SoundPlayer s72 = new SoundPlayer("72.wav");
        SoundPlayer s73 = new SoundPlayer("73.wav");
        SoundPlayer s74 = new SoundPlayer("74.wav");
        SoundPlayer s75 = new SoundPlayer("75.wav");
        SoundPlayer s76 = new SoundPlayer("76.wav");
        SoundPlayer s77 = new SoundPlayer("77.wav");
        SoundPlayer s78 = new SoundPlayer("78.wav");
        SoundPlayer s79 = new SoundPlayer("79.wav");
        SoundPlayer s80 = new SoundPlayer("80.wav");
        SoundPlayer s81 = new SoundPlayer("81.wav");
        SoundPlayer s82 = new SoundPlayer("82.wav");
        SoundPlayer s83 = new SoundPlayer("83.wav");
        SoundPlayer s84 = new SoundPlayer("84.wav");
        SoundPlayer s85 = new SoundPlayer("85.wav");
        SoundPlayer s86 = new SoundPlayer("86.wav");
        SoundPlayer s87 = new SoundPlayer("87.wav");
        SoundPlayer s88 = new SoundPlayer("88.wav");
        SoundPlayer s89 = new SoundPlayer("89.wav");
        SoundPlayer s90 = new SoundPlayer("90.wav");
        SoundPlayer s91 = new SoundPlayer("91.wav");
        SoundPlayer s92 = new SoundPlayer("92.wav");
        SoundPlayer s93 = new SoundPlayer("93.wav");
        SoundPlayer s94 = new SoundPlayer("94.wav");
        SoundPlayer s95 = new SoundPlayer("95.wav");
        SoundPlayer s96 = new SoundPlayer("96.wav");
        SoundPlayer s97 = new SoundPlayer("97.wav");
        SoundPlayer s98 = new SoundPlayer("98.wav");
        SoundPlayer s99 = new SoundPlayer("99.wav");
        SoundPlayer s100 = new SoundPlayer("100.wav");
        SoundPlayer s0 = new SoundPlayer("0.wav");

        public The_Number_Land()
        {
            InitializeComponent();
        }

        public string[] sum = System.IO.File.ReadAllLines(Application.StartupPath + @"\number.txt");//คำสั่งที่ดึงข้อมูลในรูปเเบบของอาเรย์จากไฟล์ number.txt มาเก็บในตัวเเปล sum 

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button104_Click(object sender, EventArgs e)
        {
            Close(); //คำสั่งให้ปิดหน้านั้นๆ
        }

        
             
        private void btn1_Click(object sender, EventArgs e)
        {
            s1.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s1 เล่น 
            textBox1.Text = sum[0];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 0 (อาเรย์)
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[10];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 10 (อาเรย์)
            s11.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s11 เล่น 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[1];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 1 (อาเรย์)
            s2.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s2 เล่น 
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[2];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 2 (อาเรย์)
            s3.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s3 เล่น 
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[3];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 3 (อาเรย์)
            s4.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s4 เล่น 
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[4];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 4 (อาเรย์)
            s5.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s5 เล่น 
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[5];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 5 (อาเรย์)
            s6.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s6 เล่น 
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[6];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 6 (อาเรย์)
            s7.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s7 เล่น 
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[7];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 7 (อาเรย์)
            s8.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s8 เล่น 
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[8];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 8 (อาเรย์)
            s9.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s9 เล่น 
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[9];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 9 (อาเรย์)
            s10.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s10เล่น 
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[11];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 11 (อาเรย์)
            s12.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s12 เล่น 
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[12];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 12 (อาเรย์)
            s13.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s13 เล่น 
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[13];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 13 (อาเรย์)
            s14.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s14 เล่น 
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[14];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 14 (อาเรย์)
            s15.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s15 เล่น 
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[15];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 15 (อาเรย์)
            s16.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s16 เล่น 
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[16];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 16 (อาเรย์)
            s17.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s17 เล่น 
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[17];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 17 (อาเรย์)
            s18.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s18 เล่น 
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[18];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 18 (อาเรย์)
            s19.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s19 เล่น 
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[19];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 19 (อาเรย์)
            s20.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s20 เล่น 
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[20];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 20 (อาเรย์)
            s21.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s21 เล่น 
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[21];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 21 (อาเรย์)
            s22.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s22 เล่น 
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[22];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 22 (อาเรย์)
            s23.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s23 เล่น 
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[23];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 23 (อาเรย์)
            s24.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s25 เล่น 
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[24];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 24 (อาเรย์)
            s25.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s25 เล่น 
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[25];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 25 (อาเรย์)
            s26.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s26 เล่น 
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[26];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 26 (อาเรย์)
            s27.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s27 เล่น 
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[27];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 27 (อาเรย์)
            s28.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s28 เล่น 
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[28];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 28 (อาเรย์)
            s29.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s29 เล่น 
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[29];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 29 (อาเรย์)
            s30.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s30 เล่น 
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[30];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 30 (อาเรย์)
            s31.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s31 เล่น 
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[31];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 31 (อาเรย์)
            s32.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s32 เล่น 
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[32];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 32 (อาเรย์)
            s33.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s33 เล่น 
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[33];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 33 (อาเรย์)
            s34.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s34 เล่น 
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[34];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 34 (อาเรย์)
            s35.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s35 เล่น 
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[35];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 35 (อาเรย์)
            s36.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s36 เล่น 
        }

        private void btn37_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[36];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 36 (อาเรย์)
            s37.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s37 เล่น 
        }

        private void btn38_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[37];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 37 (อาเรย์)
            s38.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s38 เล่น 
        }

        private void btn39_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[38];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 38 (อาเรย์)
            s39.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s39 เล่น 
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[39];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 39 (อาเรย์)
            s40.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s40 เล่น 
        }

        private void btn41_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[40];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 40 (อาเรย์)
            s41.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s41 เล่น 
        }

        private void btn42_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[41];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 41 (อาเรย์)
            s42.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s42 เล่น 
        }

        private void btn43_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[42];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 42 (อาเรย์)
            s43.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s43 เล่น 
        }

        private void btn44_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[43];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 43 (อาเรย์)
            s44.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s44 เล่น 
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[44];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 44 (อาเรย์)
            s45.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s45 เล่น 
        }

        private void btn46_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[45];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 45 (อาเรย์)
            s46.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s46 เล่น 
        }

        private void btn47_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[46];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 46 (อาเรย์)
            s47.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s47 เล่น 
        }

        private void btn48_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[47];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 47 (อาเรย์)
            s48.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s48 เล่น 
        }

        private void btn49_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[48];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 48 (อาเรย์)
            s49.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s49 เล่น 
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[49];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 49 (อาเรย์)
            s50.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s50 เล่น 
        }

        private void btn51_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[50];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 50 (อาเรย์)
            s51.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s51 เล่น 
        }

        private void btn52_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[51];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 51 (อาเรย์)
            s52.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s52 เล่น 
        }

        private void btn53_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[52];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 52 (อาเรย์)
            s53.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s53 เล่น 
        }

        private void btn54_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[53];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 53 (อาเรย์)
            s54.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s54 เล่น 
        }

        private void btn55_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[54];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 54 (อาเรย์)
            s55.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s55 เล่น 
        }

        private void btn56_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[55];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 55 (อาเรย์)
            s56.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s56 เล่น 
        }

        private void btn57_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[56];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 56 (อาเรย์)
            s57.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s57 เล่น 
        }

        private void btn58_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[57];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 57 (อาเรย์)
            s58.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s58 เล่น 
        }

        private void btn59_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[58];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 58 (อาเรย์)
            s59.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s59 เล่น 
        }

        private void btn60_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[59];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 59 (อาเรย์)
            s60.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s60 เล่น 
        }

        private void btn61_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[60];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 60 (อาเรย์)
            s61.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s61 เล่น 
        }

        private void btn62_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[61];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 61 (อาเรย์)
            s62.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s62 เล่น 
        }

        private void btn63_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[62];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 62 (อาเรย์)
            s63.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s63 เล่น 
        }

        private void btn64_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[63];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 63 (อาเรย์)
            s64.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s64 เล่น 
        }

        private void btn65_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[64];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 64 (อาเรย์)
            s65.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s65 เล่น 
        }

        private void btn66_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[65];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 65 (อาเรย์)
            s66.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s66 เล่น 
        }

        private void btn67_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[66];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 66 (อาเรย์)
            s67.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s67 เล่น 
        }

        private void btn68_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[67];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 67 (อาเรย์)
            s68.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s68 เล่น 
        }

        private void btn69_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[68];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 68 (อาเรย์)
            s69.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s69 เล่น 
        }

        private void btn70_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[69];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 69 (อาเรย์)
            s70.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s70 เล่น 
        }

        private void btn71_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[70];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 70 (อาเรย์)
            s71.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s71 เล่น 
        }

        private void btn72_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[71];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 71 (อาเรย์)
            s72.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s72 เล่น 
        }

        private void btn73_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[72];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 72 (อาเรย์)
            s73.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s73 เล่น 
        }

        private void btn74_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[73];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 73 (อาเรย์)
            s74.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s74 เล่น 
        }

        private void btn75_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[74];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 74 (อาเรย์)
            s75.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s75 เล่น 
        }

        private void btn76_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[75];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 75 (อาเรย์)
            s76.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s76 เล่น 
        }

        private void btn77_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[76];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 76 (อาเรย์)
            s77.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s77 เล่น 
        }

        private void btn78_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[77];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 77 (อาเรย์)
            s78.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s78 เล่น 
        }

        private void btn79_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[78];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 78 (อาเรย์)
            s79.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s79 เล่น 
        }

        private void btn80_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[79];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 79 (อาเรย์)
            s80.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s80 เล่น 
        }

        private void btn81_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[80];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 80 (อาเรย์)
            s81.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s81 เล่น 
        }

        private void btn82_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[81];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 81 (อาเรย์)
            s82.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s82 เล่น 
        }

        private void btn83_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[82];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 82 (อาเรย์)
            s83.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s83 เล่น 
        }

        private void btn84_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[83];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 83 (อาเรย์)
            s84.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s84 เล่น 
        }

        private void btn85_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[84];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 84 (อาเรย์)
            s85.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s85 เล่น 
        }

        private void btn86_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[85];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 85 (อาเรย์)
            s86.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s86 เล่น 
        }

        private void btn87_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[86];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 86 (อาเรย์)
            s87.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s87 เล่น 
        }

        private void btn88_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[87];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 87 (อาเรย์)
            s88.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s88 เล่น 
        }

        private void btn89_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[88];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 88 (อาเรย์)
            s89.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s89 เล่น 
        }

        private void btn90_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[89];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 89(อาเรย์)
            s90.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s90 เล่น 
        }

        private void btn91_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[90];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 90 (อาเรย์)
            s91.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s91 เล่น 
        }

        private void btn92_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[91];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 91 (อาเรย์)
            s92.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s92 เล่น 
        }

        private void btn93_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[92];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 92 (อาเรย์)
            s93.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s93 เล่น 
        }

        private void btn94_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[93];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 93 (อาเรย์)
            s94.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s94 เล่น 
        }

        private void btn95_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[94];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 94 (อาเรย์)
            s95.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s95 เล่น 
        }

        private void btn96_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[95];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 95(อาเรย์)
            s96.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s96 เล่น 
        }

        private void btn97_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[96];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 96 (อาเรย์)
            s97.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s97 เล่น 
        }

        private void btn98_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[97];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 97 (อาเรย์)
            s98.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s98 เล่น 
        }

        private void btn99_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[98];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 98 (อาเรย์)
            s99.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s99 เล่น 
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[99];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 99 (อาเรย์)
            s100.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s100 เล่น 
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = sum[100];//เมื่อกดปุ่มที่ชื่อว่า textBox1 ให้เเสดงข้อมูลในไฟล์ number.txt ในตำเเหน่งที่ 100 (อาเรย์)
            s0.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล s0 เล่น 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
          


        }

        private void buttonnum_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper() == statuspic)//เงื่อนไข ในกรณีที่ข้อมูลที่กรอกลงในtextBox1ตรงกับข้อมูลที่อยู๋ใน statuspic
            {
                MessageBox.Show("ถูกต้อง");//โชว์เมสเซสบ็อก เเสดงคำว่า ถูกต้อง
                correct.Play();
                Randomm();//สุ่มอีกครั้ง

            }
            else//ในกรณีที่ไม่ตรงกับเงื่อนไข
            {
                MessageBox.Show("ผิด");//โชว์เมสเซสบ็อก เเสดงคำว่า ผิด

            }
        }
        void Randomm()//กำหนดเมดตอดที่ชื่อว่า Randomm
        {
            Random rannn = new Random();//ประกาศคำสั่งสุ่มที่มีตัวเเปลชื่อว่า rannn 
            int sooma = rannn.Next(1, 27);//ประกาศตัวเเปลที่ชื่อว่า sooma เเละให้นำค่าที่อยู่ใน rannn ที่ได้จากการสุ่ม มาเก็บไว้ใน sooma
            switch(sooma)//คำสั่งเงื่อนไข(ตรวจสอบตัวเเปล sooma)
            {
                //จากเคสที่ 1-29 เป็นคำสั่งเเสดงภาพใน pictureBoxnum เเละ กำหนดค่าในตัวเเปล statuspic
                case 1:  pictureBoxnum.Image = Resources.Slide0;
                    statuspic = "ZERO";
                    break;
                case 2:pictureBoxnum.Image = Resources.Slide1;
                    statuspic = "ONE";
                    break;
                    
                case 3: pictureBoxnum.Image = Resources.Slide2;
                    statuspic = "TWO";
                    break;
                   
                case 4:pictureBoxnum.Image = Resources.Slide3;
                    statuspic = "THREE";
                    break;
                    
                case 5:pictureBoxnum.Image = Resources.Slide4;
                    statuspic = "FOUR";
                    break;
                    
                case 6: pictureBoxnum.Image = Resources.Slide5;
                    statuspic = "FIVE";
                    break;
                   
                case 7:pictureBoxnum.Image = Resources.Slide6;
                    statuspic = "SIX";
                    break;
                    
                case 8:pictureBoxnum.Image = Resources.Slide7;
                    statuspic = "SEVEN";
                    break;
                    
                case 9:pictureBoxnum.Image = Resources.Slide8;
                    statuspic = "EIGHT";
                    break;
                    
                case 10:pictureBoxnum.Image = Resources.Slide9;
                    statuspic = "NINE";
                    break;
                    
                case 11:
                    pictureBoxnum.Image = Resources.Slide10;
                    statuspic = "TEN";
                    break;
                case 12:
                    pictureBoxnum.Image = Resources.Slide11;
                    statuspic = "ELEVEN";
                    break;
                case 13:
                    pictureBoxnum.Image = Resources.Slide12;
                    statuspic = "TWELVE";
                    break;
                case 14:
                    pictureBoxnum.Image = Resources.Slide13;
                    statuspic = "THIRTEEN";
                    break;
                case 15:
                    pictureBoxnum.Image = Resources.Slide14;
                    statuspic = "FOURTEEN";
                    break;
                case 16:
                    pictureBoxnum.Image = Resources.Slide15;
                    statuspic = "FIFTEEN";
                    break;
                case 17:
                    pictureBoxnum.Image = Resources.Slide16;
                    statuspic = "SIXTEEN";
                    break;
                case 18:
                    pictureBoxnum.Image = Resources.Slide17;
                    statuspic = "SEVENTEEN";
                    break;
                case 19:
                    pictureBoxnum.Image = Resources.Slide18;
                    statuspic = "EIGHTEEN";
                    break;
                case 20:
                    pictureBoxnum.Image = Resources.Slide19;
                    statuspic = "NINETEEN";
                    break;
                case 21:
                    pictureBoxnum.Image = Resources.Slide20;
                    statuspic = "TWENTY";
                    break;
                case 22:
                    pictureBoxnum.Image = Resources.Slide21;
                    statuspic = "TWENTY ONE";
                    break;
                case 23:
                    pictureBoxnum.Image = Resources.Slide22;
                    statuspic = "TWENTY TWO";
                    break;
                case 24:
                    pictureBoxnum.Image = Resources.Slide23;
                    statuspic = "TWENTY THREE";
                    break;
                case 25:
                    pictureBoxnum.Image = Resources.Slide24;
                    statuspic = "TWENTY FOUR";
                    break;
                case 26:
                    pictureBoxnum.Image = Resources.Slide25;
                    statuspic = "TWENTY FIVE";
                    break;
                case 27:
                    pictureBoxnum.Image = Resources.Slide26;
                    statuspic = "TWENTY SIX";
                    break;
                case 28:
                    pictureBoxnum.Image = Resources.Slide27;
                    statuspic = "TWENTY SEVEN";
                    break;
                case 29:
                    pictureBoxnum.Image = Resources.Slide28;
                    statuspic = "TWENTY EIGHT";
                    break;
               
               

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {

        }

        private void button53_Click(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {

        }

        private void button55_Click(object sender, EventArgs e)
        {

        }

        private void button56_Click(object sender, EventArgs e)
        {

        }

        private void button57_Click(object sender, EventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonstartnum_Click(object sender, EventArgs e)
        {
            pictureBoxnum.Visible = true;//คำสั่งให้เเสดงปุ่ม pictureBoxnum (ก่อนหน้านี้ได้ปิดไว้)
            textBoxnum.Visible = true;//คำสั่งให้เเสดงปุ่ม  textBoxnum (ก่อนหน้านี้ได้ปิดไว้)
            buttonstartnum.Visible = false;//คำสั่งให้ปิดปุ่ม pictureBoxnum (ก่อนหน้านี้ได้เปิดไว้)
            btnoknum.Visible = true;//คำสั่งให้เเสดงปุ่ม  btnoknum (ก่อนหน้านี้ได้ปิดไว้)
            Randomm();//ตัวเเปล ของเมดตอด ในตัวเเปลตัวนี้จะมีคำสั่งให้สุ่ม
        }

        private void pictureBoxnum_Click(object sender, EventArgs e)
        {

        }

        private void btnoknum_Click(object sender, EventArgs e)
        {
            if (textBoxnum.Text.ToUpper() == statuspic)//เงื่อนไข ในกรณีที่ตัวหนังสือที่กรอกเข้ามาตรงกับ ค่าที่อยู่ใน statuspic
            {
                MessageBox.Show("ถูกต้อง");//คำสั่งเเสดง messege ใน messege เเสดงคำว่า ถูกต้อง
                
                Randomm();//ตัวเเปล ของเมดตอด ในตัวเเปลตัวนี้จะมีคำสั่งให้สุ่ม
            }
            else//ในกรณีที่ไม่ตรงกับเงื่อนไข
            {
                MessageBox.Show("ผิด");//คำสั่งเเสดง messege ใน messege เเสดงคำว่า ผิด
            }
        }
    }
}
