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
    
    public partial class The_ABC_Land : Form
    {
        //นำไฟล์เสียงที่ชื่อ ...(.wav) มาเก็บไว้ในตัวเเปล s(...)  
        SoundPlayer aa = new SoundPlayer("ant.wav");
        SoundPlayer ab = new SoundPlayer("bird.wav");
        SoundPlayer ac = new SoundPlayer("cat.wav");
        SoundPlayer ad = new SoundPlayer("dog.wav");
        SoundPlayer ae = new SoundPlayer("egg.wav");
        SoundPlayer af = new SoundPlayer("fan.wav");
        SoundPlayer ag = new SoundPlayer("goat.wav");
        SoundPlayer ah = new SoundPlayer("horse.wav");
        SoundPlayer ai = new SoundPlayer("ink.wav");
        SoundPlayer aj = new SoundPlayer("jar.wav");
        SoundPlayer ak = new SoundPlayer("king.wav");
        SoundPlayer al = new SoundPlayer("lion.wav");
        SoundPlayer am = new SoundPlayer("monkey.wav");
        SoundPlayer an = new SoundPlayer("net.wav");
        SoundPlayer ao = new SoundPlayer("orange.wav");
        SoundPlayer ap = new SoundPlayer("pen.wav");
        SoundPlayer aq = new SoundPlayer("queen.wav");
        SoundPlayer ar = new SoundPlayer("rat.wav");
        SoundPlayer ass = new SoundPlayer("sun.wav");
        SoundPlayer at = new SoundPlayer("tiger.wav");
        SoundPlayer au = new SoundPlayer("umbrella.wav");
        SoundPlayer av = new SoundPlayer("Van.wav");
        SoundPlayer aw = new SoundPlayer("Whale.wav");
        SoundPlayer ax = new SoundPlayer("X-ray.wav");
        SoundPlayer ay = new SoundPlayer("yacht.wav");
        SoundPlayer az = new SoundPlayer("zoo.wav");
        string[] animal;//ประกาศ ตัวเเปลในรูปเเบบของอาเรย์
        string statuspic;//ประกาศตัวเเปลชื่อ statuspic
      
        

        public The_ABC_Land()
        {
            InitializeComponent();
            animal = new string[] { "Ant", "Bird", "Cat", "Dog", "Egg", "Fan", "Goat", "Horse", "Ink", "Jar", "King", "Lion", "Monkey", "Net",
                                   "Orange", "Pen", "Queen", "Rat", "Sun", "Tiger", "Umbrella", "Van", "Whale", "X-ray", "Yacht", "Zoo" };//เก็บข้อมูลลงในตัวเเปล animal ในรูปเเบบของอาเรย์
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button56_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\antt.jpg");//เเสดงรูปภาพที่ชื่อ antt ใน pictureBox1
            textBox3.Text = animal[0].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 0 มาเเสดงใน textBox3
            aa.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล aa เล่น 

        }

        private void button54_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\birdd.jpg");//เเสดงรูปภาพที่ชื่อ birdd ใน pictureBox1
            textBox3.Text = animal[1].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 1 มาเเสดงใน textBox3
            ab.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล ab เล่น 
        }

        private void button52_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\catt.jpg");//เเสดงรูปภาพที่ชื่อ catt ใน pictureBox1
            textBox3.Text = animal[2].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 2 มาเเสดงใน textBox3
            ac.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล ac เล่น 
        }

        private void button50_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\dogg.jpg");//เเสดงรูปภาพที่ชื่อ dogg ใน pictureBox1
            textBox3.Text = animal[3].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 3 มาเเสดงใน textBox3
            ad.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล ad เล่น 
        }

        private void button57_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\eggg.jpg");//เเสดงรูปภาพที่ชื่อ egg ใน pictureBox1
            textBox3.Text = animal[4].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 4 มาเเสดงใน textBox3
            ae.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล ae เล่น 
        }

        private void button41_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\fan.jpg");//เเสดงรูปภาพที่ชื่อ fan ใน pictureBox1
            textBox3.Text = animal[5].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 5 มาเเสดงใน textBox3
            af.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล af เล่น 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\goatt.jpg");//เเสดงรูปภาพที่ชื่อ goatt ใน pictureBox1
            textBox3.Text = animal[6].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 6 มาเเสดงใน textBox3
            ag.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล ag เล่น 
        }

        private void button43_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\horsee.jpg");//เเสดงรูปภาพที่ชื่อ horsee ใน pictureBox1
            textBox3.Text = animal[7].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 7 มาเเสดงใน textBox3
            ah.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล ah เล่น 
        }

        private void button53_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\inkk.jpg");//เเสดงรูปภาพที่ชื่อ inkk ใน pictureBox1
            textBox3.Text = animal[8].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 8 มาเเสดงใน textBox3
            ai.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล ai เล่น 
        }

        private void button51_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\jarr.jpg");//เเสดงรูปภาพที่ชื่อ jarr ใน pictureBox1
            textBox3.Text = animal[9].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 9 มาเเสดงใน textBox3
            aj.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล aj เล่น 
        }

        private void button55_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\kingg.jpg");//เเสดงรูปภาพที่ชื่อ kingg ใน pictureBox1
            textBox3.Text = animal[10].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 10 มาเเสดงใน textBox3
            ak.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล ak เล่น 
        }

        private void button48_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\lionn.jpg");//เเสดงรูปภาพที่ชื่อ lionn ใน pictureBox1
            textBox3.Text = animal[11].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 11 มาเเสดงใน textBox3
            al.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล al เล่น 
        }

        private void button44_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\monkeyy.jpg");//เเสดงรูปภาพที่ชื่อ monkeyy ใน pictureBox1
            textBox3.Text = animal[12].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 12 มาเเสดงใน textBox3
            am.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล am เล่น 
        }

        private void button42_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\nett.jpg");//เเสดงรูปภาพที่ชื่อ nett ใน pictureBox1
            textBox3.Text = animal[13].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 13 มาเเสดงใน textBox3
            an.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล an เล่น 
        }

        private void button45_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\orangee.jpg");//เเสดงรูปภาพที่ชื่อ orangee ใน pictureBox1
            textBox3.Text = animal[14].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 14 มาเเสดงใน textBox3
            ao.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล ao เล่น 
        }

        private void button40_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\penn.jpg");//เเสดงรูปภาพที่ชื่อ penn ใน pictureBox1
            textBox3.Text = animal[15].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 15 มาเเสดงใน textBox3
            ap.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล ap เล่น 
        }

        private void button35_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\queenn.jpg");//เเสดงรูปภาพที่ชื่อ queenn ใน pictureBox1
            textBox3.Text = animal[16].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 16 มาเเสดงใน textBox3
            aq.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล aq เล่น 
        }

        private void button46_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\ratt.jpg");//เเสดงรูปภาพที่ชื่อ ratt ใน pictureBox1
            textBox3.Text = animal[17].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 0 มาเเสดงใน textBox3
            ar.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล green เล่น 
        }

        private void button38_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\sunn.jpg");//เเสดงรูปภาพที่ชื่อ antt ใน pictureBox1
            textBox3.Text = animal[18].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 18 มาเเสดงใน textBox3
            ass.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล ass เล่น 
        }

        private void button58_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\tigerr.jpg");//เเสดงรูปภาพที่ชื่อ tigger ใน pictureBox1
            textBox3.Text = animal[19].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 19 มาเเสดงใน textBox3
            at.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล at เล่น 
        }

        private void button39_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\umbrellaa.jpg");//เเสดงรูปภาพที่ชื่อ umbrella ใน pictureBox1
            textBox3.Text = animal[20].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 20 มาเเสดงใน textBox3
            au.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล au เล่น 
        }

        private void button49_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\vann.jpg");//เเสดงรูปภาพที่ชื่อ vann ใน pictureBox1
            textBox3.Text = animal[21].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 21 มาเเสดงใน textBox3
            av.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล av เล่น 
        }

        private void button37_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\whalee.jpg");//เเสดงรูปภาพที่ชื่อ whale ใน pictureBox1
            textBox3.Text = animal[22].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 22 มาเเสดงใน textBox3
            aw.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล aw เล่น 
        }

        private void button47_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\x-rayyy.jpg");//เเสดงรูปภาพที่ชื่อ x-rayyy ใน pictureBox1
            textBox3.Text = animal[23].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 23 มาเเสดงใน textBox3
            ax.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล ax เล่น 
        }

        private void button36_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\yachtt.jpg");//เเสดงรูปภาพที่ชื่อ yacht ใน pictureBox1
            textBox3.Text = animal[24].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่24 มาเเสดงใน textBox3
            ay.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล ay เล่น 
        }

        private void button34_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\zooo.jpg");//เเสดงรูปภาพที่ชื่อ zooo ใน pictureBox1
            textBox3.Text = animal[25].ToString();//เเสดงข้อมูลที่อยู่ในตัวเเปล  animal ในรูปเเบบของอาเรย์ในตำเเหน่งที่ 25 มาเเสดงใน textBox3
            az.Play();//สั่งให้ไฟล์เสียงที่อยู่ในตัวเเปล az เล่น 
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
          
     
        }

        private void bt1_Click(object sender, EventArgs e)
        {

        }
        void RandomText()
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            pictureBox2.Visible = true;//คำสั่งให้เเสดงปุ่ม  pictureBox2 (ก่อนหน้านี้ได้ปิดไว้)
            textBox1.Visible = true;//คำสั่งให้เเสดงปุ่ม textBox1 (ก่อนหน้านี้ได้ปิดไว้)
            button5.Visible = false;//คำสั่งให้ปิดปุ่ม  button5 (ก่อนหน้านี้ได้เปิดไว้)
            button6.Visible = true;//คำสั่งให้เเสดงปุ่ม button6 (ก่อนหน้านี้ได้ปิดไว้)
            RandomPic();//ตัวเเปล ของเมดตอด ในตัวเเปลตัวนี้จะมีคำสั่งให้สุ่ม
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            if(textBox1.Text.ToUpper()==statuspic)//เงื่อนไข ในกรณีที่ตัวหนังสือที่กรอกเข้ามาตรงกับ ค่าที่อยู่ใน statuspic
            {
                MessageBox.Show("ถูกต้อง");//คำสั่งเเสดง messege ใน messege เเสดงคำว่า ถูกต้อง
                RandomPic();//ตัวเเปล ของเมดตอด ในตัวเเปลตัวนี้จะมีคำสั่งให้สุ่ม

            }
            else//ในกรณีที่ไม่ตรงกับเงื่อนไข
            {
                MessageBox.Show("ผิด");//คำสั่งเเสดง messege ใน messege เเสดงคำว่า ผิด

            }
        }
        void RandomPic()//กำหนดเมดตอดที่ชื่อว่า Randompic
        {
            Random ranpa = new Random();//ประกาศคำสั่งสุ่มที่มีตัวเเปลชื่อว่า ranpa 
            int sooma = ranpa.Next(1, 27);//ประกาศตัวเเปลที่ชื่อว่า sooma เเละให้นำค่าที่อยู่ใน ranpa ที่ได้จากการสุ่ม มาเก็บไว้ใน sooma
            switch (sooma)//คำสั่งเงื่อนไข(ตรวจสอบตัวเเปล sooma)
            {
                //จากเคสที่ 1-26 เป็นคำสั่งเเสดงภาพใน pictureBox2 เเละ กำหนดค่าในตัวเเปล statuspic
                case 1:
                    pictureBox2.Image = Resources.antt;
                    statuspic = "ANT";
                    break;
                case 2:
                    pictureBox2.Image = Resources.birdd;
                    statuspic = "BIRD";
                    break;
                case 3:
                    pictureBox2.Image = Resources.catt;
                    statuspic = "CAT";
                    break;
                case 4:
                    pictureBox2.Image = Resources.dogg;
                    statuspic = "DOG";
                    break;
                case 5:
                    pictureBox2.Image = Resources.eggg;
                    statuspic = "EGG";
                    break;
                case 6:
                    pictureBox2.Image = Resources.fan;
                    statuspic = "FAN";
                    break;
                case 7:
                    pictureBox2.Image = Resources.goatt;
                    statuspic = "GOAT";
                    break;
                case 8:
                    pictureBox2.Image = Resources.horsee;
                    statuspic = "HORSE";
                    break;
                case 9:
                    pictureBox2.Image = Resources.inkk;
                    statuspic = "INK";
                    break;
                case 10:
                    pictureBox2.Image = Resources.jarr;
                    statuspic = "JAR";
                    break;
                case 11:
                    pictureBox2.Image = Resources.kingg;
                    statuspic = "KING";
                    break;
                case 12:
                    pictureBox2.Image = Resources.lionn;
                    statuspic = "LION";
                    break;
                case 13:
                    pictureBox2.Image = Resources.monkeyy;
                    statuspic = "MONKEY";
                    break;
                case 14:
                    pictureBox2.Image = Resources.nett;
                    statuspic = "NET";
                    break;
                case 15:
                    pictureBox2.Image = Resources.orangee;
                    statuspic = "ORANGE";
                    break;
                case 16:
                    pictureBox2.Image = Resources.penn;
                    statuspic = "PEN";
                    break;
                case 17:
                    pictureBox2.Image = Resources.queenn;
                    statuspic = "QUEEN";
                    break;
                case 18:
                    pictureBox2.Image = Resources.ratt;
                    statuspic = "RAT";
                    break;
                case 19:
                    pictureBox2.Image = Resources.sunn;
                    statuspic = "SUN";
                    break;
                case 20:
                    pictureBox2.Image = Resources.tigerr;
                    statuspic = "TIGER";
                    break;
                case 21:
                    pictureBox2.Image = Resources.umbrellaa;
                    statuspic = "UMBRELLA";
                    break;
                case 22:
                    pictureBox2.Image = Resources.vann;
                    statuspic = "VAN";
                    break;
                case 23:
                    pictureBox2.Image = Resources.whalee;
                    statuspic = "WHALE";
                    break;
                case 24:
                    pictureBox2.Image = Resources.x_rayyy;
                    statuspic = "X-RAY";
                    break;
                case 25:
                    pictureBox2.Image = Resources.yachtt;
                    statuspic = "YACHT";
                    break;
                case 26:
                    pictureBox2.Image = Resources.zooo;
                    statuspic = "ZOO";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
