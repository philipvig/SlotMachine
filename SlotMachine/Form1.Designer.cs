namespace SlotMachine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Row1 = new System.Windows.Forms.PictureBox();
            this.Fruits = new System.Windows.Forms.ImageList(this.components);
            this.Row2 = new System.Windows.Forms.PictureBox();
            this.Row3 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.slotmachine = new System.Windows.Forms.PictureBox();
            this.lightsout = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.coins = new System.Windows.Forms.Label();
            this.hand1 = new System.Windows.Forms.PictureBox();
            this.hand2 = new System.Windows.Forms.PictureBox();
            this.buy = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Row1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Row2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Row3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotmachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightsout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(622, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Row1
            // 
            this.Row1.BackColor = System.Drawing.Color.White;
            this.Row1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Row1.Location = new System.Drawing.Point(317, 277);
            this.Row1.Name = "Row1";
            this.Row1.Size = new System.Drawing.Size(61, 58);
            this.Row1.TabIndex = 2;
            this.Row1.TabStop = false;
            this.Row1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Fruits
            // 
            this.Fruits.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.Fruits.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Fruits.ImageStream")));
            this.Fruits.TransparentColor = System.Drawing.Color.Transparent;
            this.Fruits.Images.SetKeyName(0, "1.png");
            this.Fruits.Images.SetKeyName(1, "1.png");
            this.Fruits.Images.SetKeyName(2, "2.png");
            this.Fruits.Images.SetKeyName(3, "3.png");
            this.Fruits.Images.SetKeyName(4, "4.png");
            // 
            // Row2
            // 
            this.Row2.BackColor = System.Drawing.Color.White;
            this.Row2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Row2.Location = new System.Drawing.Point(390, 277);
            this.Row2.Name = "Row2";
            this.Row2.Size = new System.Drawing.Size(61, 58);
            this.Row2.TabIndex = 3;
            this.Row2.TabStop = false;
            // 
            // Row3
            // 
            this.Row3.BackColor = System.Drawing.Color.White;
            this.Row3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Row3.Location = new System.Drawing.Point(462, 277);
            this.Row3.Name = "Row3";
            this.Row3.Size = new System.Drawing.Size(61, 58);
            this.Row3.TabIndex = 4;
            this.Row3.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Asset 12.png");
            this.imageList1.Images.SetKeyName(1, "Asset 13.png");
            // 
            // slotmachine
            // 
            this.slotmachine.BackColor = System.Drawing.Color.Transparent;
            this.slotmachine.Image = global::SlotMachine.Properties.Resources.Asset_12;
            this.slotmachine.Location = new System.Drawing.Point(170, 64);
            this.slotmachine.Name = "slotmachine";
            this.slotmachine.Size = new System.Drawing.Size(500, 446);
            this.slotmachine.TabIndex = 7;
            this.slotmachine.TabStop = false;
            // 
            // lightsout
            // 
            this.lightsout.Image = ((System.Drawing.Image)(resources.GetObject("lightsout.Image")));
            this.lightsout.Location = new System.Drawing.Point(170, 64);
            this.lightsout.Name = "lightsout";
            this.lightsout.Size = new System.Drawing.Size(500, 446);
            this.lightsout.TabIndex = 8;
            this.lightsout.TabStop = false;
            this.lightsout.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(669, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 33);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "COINS:";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // coins
            // 
            this.coins.AutoSize = true;
            this.coins.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coins.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.coins.Location = new System.Drawing.Point(733, 9);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(26, 33);
            this.coins.TabIndex = 10;
            this.coins.Text = "0";
            // 
            // hand1
            // 
            this.hand1.BackColor = System.Drawing.Color.Transparent;
            this.hand1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hand1.BackgroundImage")));
            this.hand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hand1.Location = new System.Drawing.Point(622, 230);
            this.hand1.Name = "hand1";
            this.hand1.Size = new System.Drawing.Size(57, 169);
            this.hand1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hand1.TabIndex = 11;
            this.hand1.TabStop = false;
            // 
            // hand2
            // 
            this.hand2.BackColor = System.Drawing.Color.Transparent;
            this.hand2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hand2.BackgroundImage")));
            this.hand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hand2.Location = new System.Drawing.Point(622, 249);
            this.hand2.Name = "hand2";
            this.hand2.Size = new System.Drawing.Size(57, 194);
            this.hand2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hand2.TabIndex = 12;
            this.hand2.TabStop = false;
            this.hand2.Visible = false;
            // 
            // buy
            // 
            this.buy.BackColor = System.Drawing.Color.Transparent;
            this.buy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy.FlatAppearance.BorderSize = 0;
            this.buy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buy.ForeColor = System.Drawing.Color.Transparent;
            this.buy.Location = new System.Drawing.Point(12, 9);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(152, 74);
            this.buy.TabIndex = 13;
            this.buy.Text = "Insert 2 Coins";
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.Location = new System.Drawing.Point(727, 496);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(88, 64);
            this.exit.TabIndex = 14;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 563);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.hand2);
            this.Controls.Add(this.hand1);
            this.Controls.Add(this.coins);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Row3);
            this.Controls.Add(this.Row2);
            this.Controls.Add(this.Row1);
            this.Controls.Add(this.lightsout);
            this.Controls.Add(this.slotmachine);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Row1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Row2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Row3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotmachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightsout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Row1;
        private ImageList Fruits;
        private PictureBox Row2;
        private PictureBox Row3;
        private ImageList imageList1;
        private PictureBox slotmachine;
        private PictureBox lightsout;
        private TextBox textBox2;
        private Label coins;
        private PictureBox hand1;
        private PictureBox hand2;
        private Button buy;
        private Button exit;
    }
}