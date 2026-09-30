namespace GuessTheWordGame_WinForms_CSharp
{
    partial class GameSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSetup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numNumberOfAttempts = new System.Windows.Forms.NumericUpDown();
            this.labNumberOfAttempts = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.labDifficulty = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.labCategory = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labSubtitle = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfAttempts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labSubtitle);
            this.panel1.Controls.Add(this.labTitle);
            this.panel1.Location = new System.Drawing.Point(219, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 805);
            this.panel1.TabIndex = 0;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Black;
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.ImageIndex = 0;
            this.btnStartGame.ImageList = this.imageList1;
            this.btnStartGame.Location = new System.Drawing.Point(270, 684);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(331, 71);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Icon_Play_Game.png");
            this.imageList1.Images.SetKeyName(1, "GoBack.png");
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageIndex = 1;
            this.btnBack.ImageList = this.imageList1;
            this.btnBack.Location = new System.Drawing.Point(96, 684);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 71);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.numNumberOfAttempts);
            this.panel4.Controls.Add(this.labNumberOfAttempts);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(96, 507);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(497, 146);
            this.panel4.TabIndex = 2;
            // 
            // numNumberOfAttempts
            // 
            this.numNumberOfAttempts.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.numNumberOfAttempts.Location = new System.Drawing.Point(62, 84);
            this.numNumberOfAttempts.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numNumberOfAttempts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfAttempts.Name = "numNumberOfAttempts";
            this.numNumberOfAttempts.ReadOnly = true;
            this.numNumberOfAttempts.Size = new System.Drawing.Size(97, 45);
            this.numNumberOfAttempts.TabIndex = 2;
            this.numNumberOfAttempts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labNumberOfAttempts
            // 
            this.labNumberOfAttempts.AutoSize = true;
            this.labNumberOfAttempts.Location = new System.Drawing.Point(109, 20);
            this.labNumberOfAttempts.Name = "labNumberOfAttempts";
            this.labNumberOfAttempts.Size = new System.Drawing.Size(337, 45);
            this.labNumberOfAttempts.TabIndex = 1;
            this.labNumberOfAttempts.Text = "Number of Attempts";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GuessTheWordGame_WinForms_CSharp.Properties.Resources.Hash1;
            this.pictureBox4.Location = new System.Drawing.Point(31, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbMeduim);
            this.panel3.Controls.Add(this.rbHard);
            this.panel3.Controls.Add(this.rbEasy);
            this.panel3.Controls.Add(this.labDifficulty);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(96, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 146);
            this.panel3.TabIndex = 2;
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Checked = true;
            this.rbMeduim.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.rbMeduim.Location = new System.Drawing.Point(162, 85);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(131, 42);
            this.rbMeduim.TabIndex = 2;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Text = "Medium";
            this.rbMeduim.UseVisualStyleBackColor = true;
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.rbHard.Location = new System.Drawing.Point(299, 85);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(99, 42);
            this.rbHard.TabIndex = 2;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.rbEasy.Location = new System.Drawing.Point(63, 85);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(93, 42);
            this.rbEasy.TabIndex = 2;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // labDifficulty
            // 
            this.labDifficulty.AutoSize = true;
            this.labDifficulty.Location = new System.Drawing.Point(110, 22);
            this.labDifficulty.Name = "labDifficulty";
            this.labDifficulty.Size = new System.Drawing.Size(167, 45);
            this.labDifficulty.TabIndex = 1;
            this.labDifficulty.Text = "Difficulty";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GuessTheWordGame_WinForms_CSharp.Properties.Resources.Levels1;
            this.pictureBox3.Location = new System.Drawing.Point(32, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbCategories);
            this.panel2.Controls.Add(this.labCategory);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(96, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 146);
            this.panel2.TabIndex = 2;
            // 
            // cbCategories
            // 
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Items.AddRange(new object[] {
            "Animals",
            "Food",
            "Countries",
            "Technology"});
            this.cbCategories.Location = new System.Drawing.Point(63, 82);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(384, 46);
            this.cbCategories.TabIndex = 2;
            // 
            // labCategory
            // 
            this.labCategory.AutoSize = true;
            this.labCategory.Location = new System.Drawing.Point(110, 17);
            this.labCategory.Name = "labCategory";
            this.labCategory.Size = new System.Drawing.Size(154, 45);
            this.labCategory.TabIndex = 1;
            this.labCategory.Text = "Category";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GuessTheWordGame_WinForms_CSharp.Properties.Resources.Category1;
            this.pictureBox2.Location = new System.Drawing.Point(32, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuessTheWordGame_WinForms_CSharp.Properties.Resources.Settings1;
            this.pictureBox1.Location = new System.Drawing.Point(24, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labSubtitle
            // 
            this.labSubtitle.AutoSize = true;
            this.labSubtitle.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.labSubtitle.Location = new System.Drawing.Point(132, 95);
            this.labSubtitle.Name = "labSubtitle";
            this.labSubtitle.Size = new System.Drawing.Size(532, 33);
            this.labSubtitle.TabIndex = 0;
            this.labSubtitle.Text = "Choose your settings before starting the game";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold);
            this.labTitle.Location = new System.Drawing.Point(127, 31);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(299, 65);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Game Setup";
            // 
            // GameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 850);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "GameSetup";
            this.Text = "New Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameSetup_FormClosed);
            this.Load += new System.EventHandler(this.GameSetup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfAttempts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labSubtitle;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numNumberOfAttempts;
        private System.Windows.Forms.Label labNumberOfAttempts;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.Label labDifficulty;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label labCategory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ImageList imageList1;
    }
}