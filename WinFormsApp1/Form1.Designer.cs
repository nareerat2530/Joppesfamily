namespace WinFormsApp1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayButton = new System.Windows.Forms.Button();
            this.FeedButton = new System.Windows.Forms.Button();
            this.ListText = new System.Windows.Forms.Label();
            this.HaruButton = new System.Windows.Forms.Button();
            this.LeoButton = new System.Windows.Forms.Button();
            this.PoppyButton = new System.Windows.Forms.Button();
            this.HaruPic = new System.Windows.Forms.Label();
            this.LeoPic = new System.Windows.Forms.Label();
            this.PoppyPic = new System.Windows.Forms.Label();
            this.PetInfo = new System.Windows.Forms.TextBox();
            this.FoodLabel = new System.Windows.Forms.Label();
            this.informationBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.FeedBox = new System.Windows.Forms.TextBox();
            this.PlayInfo = new System.Windows.Forms.TextBox();
            this.Check_ball = new System.Windows.Forms.Button();
            this.Check_mouse = new System.Windows.Forms.Button();
            this.ToyInfo = new System.Windows.Forms.TextBox();
            this.FoodBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(168, 245);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(65, 27);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // FeedButton
            // 
            this.FeedButton.Location = new System.Drawing.Point(301, 245);
            this.FeedButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FeedButton.Name = "FeedButton";
            this.FeedButton.Size = new System.Drawing.Size(65, 27);
            this.FeedButton.TabIndex = 3;
            this.FeedButton.Text = "Feed";
            this.FeedButton.UseVisualStyleBackColor = true;
            this.FeedButton.Click += new System.EventHandler(this.FeedButton_Click);
            // 
            // ListText
            // 
            this.ListText.Location = new System.Drawing.Point(31, 21);
            this.ListText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListText.Name = "ListText";
            this.ListText.Size = new System.Drawing.Size(140, 42);
            this.ListText.TabIndex = 5;
            this.ListText.Text = "List of animal \r\nPlease choose one";
            // 
            // HaruButton
            // 
            this.HaruButton.Location = new System.Drawing.Point(31, 66);
            this.HaruButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HaruButton.Name = "HaruButton";
            this.HaruButton.Size = new System.Drawing.Size(88, 27);
            this.HaruButton.TabIndex = 8;
            this.HaruButton.Text = "Haru";
            this.HaruButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.HaruButton.UseVisualStyleBackColor = true;
            this.HaruButton.Click += new System.EventHandler(this.HaruButton_Click_1);
            // 
            // LeoButton
            // 
            this.LeoButton.Location = new System.Drawing.Point(31, 99);
            this.LeoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LeoButton.Name = "LeoButton";
            this.LeoButton.Size = new System.Drawing.Size(88, 27);
            this.LeoButton.TabIndex = 9;
            this.LeoButton.Text = "Leo";
            this.LeoButton.UseVisualStyleBackColor = true;
            this.LeoButton.Click += new System.EventHandler(this.LeoButton_Click);
            // 
            // PoppyButton
            // 
            this.PoppyButton.Location = new System.Drawing.Point(31, 138);
            this.PoppyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PoppyButton.Name = "PoppyButton";
            this.PoppyButton.Size = new System.Drawing.Size(88, 27);
            this.PoppyButton.TabIndex = 10;
            this.PoppyButton.Text = "Poppy";
            this.PoppyButton.UseVisualStyleBackColor = true;
            this.PoppyButton.Click += new System.EventHandler(this.PoppyButton_Click);
            // 
            // HaruPic
            // 
            this.HaruPic.Image = ((System.Drawing.Image)(resources.GetObject("HaruPic.Image")));
            this.HaruPic.Location = new System.Drawing.Point(178, 21);
            this.HaruPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HaruPic.Name = "HaruPic";
            this.HaruPic.Size = new System.Drawing.Size(167, 140);
            this.HaruPic.TabIndex = 11;
            this.HaruPic.Text = "\r\n";
            // 
            // LeoPic
            // 
            this.LeoPic.Image = ((System.Drawing.Image)(resources.GetObject("LeoPic.Image")));
            this.LeoPic.Location = new System.Drawing.Point(168, 44);
            this.LeoPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LeoPic.Name = "LeoPic";
            this.LeoPic.Size = new System.Drawing.Size(167, 115);
            this.LeoPic.TabIndex = 12;
            // 
            // PoppyPic
            // 
            this.PoppyPic.Image = ((System.Drawing.Image)(resources.GetObject("PoppyPic.Image")));
            this.PoppyPic.Location = new System.Drawing.Point(178, 12);
            this.PoppyPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PoppyPic.Name = "PoppyPic";
            this.PoppyPic.Size = new System.Drawing.Size(149, 153);
            this.PoppyPic.TabIndex = 13;
            // 
            // PetInfo
            // 
            this.PetInfo.Location = new System.Drawing.Point(168, 162);
            this.PetInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PetInfo.Multiline = true;
            this.PetInfo.Name = "PetInfo";
            this.PetInfo.ReadOnly = true;
            this.PetInfo.Size = new System.Drawing.Size(198, 65);
            this.PetInfo.TabIndex = 15;
            // 
            // FoodLabel
            // 
            this.FoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodLabel.Location = new System.Drawing.Point(124, 324);
            this.FoodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FoodLabel.Name = "FoodLabel";
            this.FoodLabel.Size = new System.Drawing.Size(48, 35);
            this.FoodLabel.TabIndex = 17;
            this.FoodLabel.Text = "Food";
            // 
            // informationBox
            // 
            this.informationBox.Location = new System.Drawing.Point(168, 278);
            this.informationBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.informationBox.Multiline = true;
            this.informationBox.Name = "informationBox";
            this.informationBox.ReadOnly = true;
            this.informationBox.Size = new System.Drawing.Size(198, 57);
            this.informationBox.TabIndex = 18;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(168, 376);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(65, 27);
            this.Cancel.TabIndex = 19;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(301, 376);
            this.Accept.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(65, 27);
            this.Accept.TabIndex = 20;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // FeedBox
            // 
            this.FeedBox.Location = new System.Drawing.Point(168, 376);
            this.FeedBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FeedBox.Multiline = true;
            this.FeedBox.Name = "FeedBox";
            this.FeedBox.ReadOnly = true;
            this.FeedBox.Size = new System.Drawing.Size(198, 65);
            this.FeedBox.TabIndex = 21;
            // 
            // PlayInfo
            // 
            this.PlayInfo.Location = new System.Drawing.Point(168, 278);
            this.PlayInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlayInfo.Multiline = true;
            this.PlayInfo.Name = "PlayInfo";
            this.PlayInfo.ReadOnly = true;
            this.PlayInfo.Size = new System.Drawing.Size(198, 57);
            this.PlayInfo.TabIndex = 22;
            // 
            // Check_ball
            // 
            this.Check_ball.Location = new System.Drawing.Point(168, 342);
            this.Check_ball.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Check_ball.Name = "Check_ball";
            this.Check_ball.Size = new System.Drawing.Size(104, 28);
            this.Check_ball.TabIndex = 23;
            this.Check_ball.Text = "Check ball";
            this.Check_ball.UseVisualStyleBackColor = true;
            this.Check_ball.Click += new System.EventHandler(this.Check_ball_Click);
            // 
            // Check_mouse
            // 
            this.Check_mouse.Location = new System.Drawing.Point(168, 343);
            this.Check_mouse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Check_mouse.Name = "Check_mouse";
            this.Check_mouse.Size = new System.Drawing.Size(104, 27);
            this.Check_mouse.TabIndex = 24;
            this.Check_mouse.Text = "Check Mouse";
            this.Check_mouse.UseVisualStyleBackColor = true;
            this.Check_mouse.Click += new System.EventHandler(this.Check_mouse_Click);
            // 
            // ToyInfo
            // 
            this.ToyInfo.Location = new System.Drawing.Point(168, 378);
            this.ToyInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ToyInfo.Multiline = true;
            this.ToyInfo.Name = "ToyInfo";
            this.ToyInfo.ReadOnly = true;
            this.ToyInfo.Size = new System.Drawing.Size(198, 40);
            this.ToyInfo.TabIndex = 25;
            // 
            // FoodBox
            // 
            this.FoodBox.Location = new System.Drawing.Point(168, 329);
            this.FoodBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FoodBox.Multiline = true;
            this.FoodBox.Name = "FoodBox";
            this.FoodBox.Size = new System.Drawing.Size(198, 40);
            this.FoodBox.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 478);
            this.Controls.Add(this.FoodBox);
            this.Controls.Add(this.ToyInfo);
            this.Controls.Add(this.Check_mouse);
            this.Controls.Add(this.Check_ball);
            this.Controls.Add(this.PlayInfo);
            this.Controls.Add(this.FeedBox);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.informationBox);
            this.Controls.Add(this.FoodLabel);
            this.Controls.Add(this.PetInfo);
            this.Controls.Add(this.PoppyPic);
            this.Controls.Add(this.LeoPic);
            this.Controls.Add(this.HaruPic);
            this.Controls.Add(this.PoppyButton);
            this.Controls.Add(this.LeoButton);
            this.Controls.Add(this.HaruButton);
            this.Controls.Add(this.ListText);
            this.Controls.Add(this.FeedButton);
            this.Controls.Add(this.PlayButton);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox ToyInfo;

        private System.Windows.Forms.TextBox FoodBox;

        private System.Windows.Forms.Button Check_mouse;

        private System.Windows.Forms.Button Check_ball;

        private System.Windows.Forms.TextBox PlayInfo;

        private System.Windows.Forms.TextBox FeedBox;

        private System.Windows.Forms.TextBox PetInfo;

        private System.Windows.Forms.Button Accept;

        private System.Windows.Forms.Button Cancel;

        private System.Windows.Forms.Label FoodLabel;

        private System.Windows.Forms.TextBox informationBox;

        private System.Windows.Forms.Button LeoButton;
        private System.Windows.Forms.Button PoppyButton;

        private System.Windows.Forms.Button FeedButton;
        private System.Windows.Forms.Button PlayButton;

        private System.Windows.Forms.Button HaruButton;

        private System.Windows.Forms.Label HaruPic;
        private System.Windows.Forms.Label LeoPic;
        private System.Windows.Forms.Label PoppyPic;

        

        private System.Windows.Forms.Label ListText;

        #endregion
    }
}