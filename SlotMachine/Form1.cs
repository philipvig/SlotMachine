using System.Data.SQLite;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        String connectionstring = "Data Source=Data.db;Version=3";
        SQLiteConnection conn;

        Image[] Slot = new Image[2];
        int money;
        int insertedcoins = 0;
        int userprofit = 0;
        
        System.Media.SoundPlayer button = new System.Media.SoundPlayer(@"C:\Users\phili\source\repos\SlotMachine\SlotMachine\Properties\Images\button.wav");
        System.Media.SoundPlayer rolling = new System.Media.SoundPlayer(@"C:\Users\phili\source\repos\SlotMachine\SlotMachine\Properties\Images\rolling.wav");
        System.Media.SoundPlayer win = new System.Media.SoundPlayer(@"C:\Users\phili\source\repos\SlotMachine\SlotMachine\Properties\Images\win.wav");
        System.Media.SoundPlayer lose = new System.Media.SoundPlayer(@"C:\Users\phili\source\repos\SlotMachine\SlotMachine\Properties\Images\lose.wav");
        System.Media.SoundPlayer bigwin = new System.Media.SoundPlayer(@"C:\Users\phili\source\repos\SlotMachine\SlotMachine\Properties\Images\bigwin.wav");
        System.Media.SoundPlayer insertcoin = new System.Media.SoundPlayer(@"C:\Users\phili\source\repos\SlotMachine\SlotMachine\Properties\Images\coin.wav");
        public Form1()
        {
            
            InitializeComponent();
            Slot[0] = slotmachine.Image;
            Slot[1] = lightsout.Image;
            coins.Text = money.ToString();
            conn = new SQLiteConnection(connectionstring);
            conn.Open();







        }
        public int chances()
        {
            //calculating the outcome
            int drop;
            Random rnd = new Random();
            int chances = rnd.Next(0, 101);
            if (chances <= 55)
            {
                drop = 1; //nothing
            }
            else if (chances <= 72)
            {
                drop = 2; //cherries,5coins
            }
            else if (chances <= 85)
            {
                drop = 3; //grapes,10coins

            }
            else if (chances <= 95)
            {
                drop = 4; //strawberries,15coins
            }
            else
            {
                drop = 5; //bigwin,30coins
            }
            return drop;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money >= 2)
            {
                if (timer1.Enabled == false)
                {
                    insertedcoins += 2;
                    userprofit += -2;
                    button.Play();
                    timer1.Enabled = true;
                    money = money - 2;
                    coins.Text = money.ToString();
                    chances();
                    hand1.Visible = false;
                    hand2.Visible = true;
                    button2.Visible = false;

                    rolling.Play();
                }
            }
           
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int i = 0;
        int c = 0;
        

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            
            Random rnd = new Random();
            int spin1 = rnd.Next(1, 4);
            int spin2 = rnd.Next(1, 4);
            int spin3 = rnd.Next(1, 4);
            Row1.Image = Fruits.Images[spin1];
            Row2.Image = Fruits.Images[spin2];
            Row3.Image = Fruits.Images[spin3];
            slotmachine.Image = Slot[i];
            i++;
            if (i > 1)
            {
                i = 0;
            }
            
            
            c++;
            
            if (c == 25)
            {
                int percentage = chances();
                if (percentage == 1)
                {
                    if (Row1.Image != Row2.Image)
                    {
                        timer1.Enabled = false;
                        rolling.Stop();
                        lose.Play();
                    }
                    
                    


                }
                else if (percentage == 2)
                {
                    Row1.Image = Fruits.Images[1];
                    Row2.Image = Fruits.Images[1];
                    Row3.Image = Fruits.Images[1];
                    money = money + 5;
                    timer1.Enabled = false;
                    rolling.Stop();
                    win.Play();
                    userprofit += 5;
                    
                }
                else if (percentage == 3)
                {
                    Row1.Image = Fruits.Images[2];
                    Row2.Image = Fruits.Images[2];
                    Row3.Image = Fruits.Images[2];
                    money = money + 10;
                    timer1.Enabled = false;
                    rolling.Stop();
                    win.Play();
                    userprofit += 10;
                }
                else if (percentage == 4)
                {
                    Row1.Image = Fruits.Images[3];
                    Row2.Image = Fruits.Images[3];
                    Row3.Image = Fruits.Images[3];
                    money = money + 15;
                    timer1.Enabled = false;
                    rolling.Stop();
                    win.Play();
                    userprofit += 15;
                }
                else
                {
                    Row1.Image = Fruits.Images[4];
                    Row2.Image = Fruits.Images[4];
                    Row3.Image = Fruits.Images[4];
                    money = money + 30;
                    timer1.Enabled = false;
                    rolling.Stop();
                    bigwin.Play();
                    userprofit += 30;
                }                             
                c = 0;
                coins.Text = money.ToString();
                hand2.Visible = false;
                hand1.Visible = true;
                button2.Visible = true;

            }
            //imgnum++;
            //if (imgnum > 4)
            //{
            //    imgnum = 1;
            //    c++;
                
            //}
            //if (c == 10)
            //{
            //    timer1.Enabled = false;
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Row3_Click(object sender, EventArgs e)
        {
            
        }

        private void Row2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void Row2_Click_1(object sender, EventArgs e)
        {

        }

        private void Row3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buy_Click(object sender, EventArgs e)
        {
            if (money < 2)
            {
                
                insertedcoins += 2;
                userprofit += -2;
                money = money + 2;
                coins.Text = money.ToString();
                insertcoin.Play();
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertSQL = $"INSERT INTO TotalCoins('Coins','UserProfit') VALUES ('{insertedcoins}','{userprofit}')";
            SQLiteCommand cmd = new SQLiteCommand(insertSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }
    }
}