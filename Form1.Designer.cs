namespace GuessTheWordGame_WinForms_CSharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labSubTitle = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.ILIcons = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labSubTitle);
            this.panel1.Controls.Add(this.labTitle);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Location = new System.Drawing.Point(241, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 572);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuessTheWordGame_WinForms_CSharp.Properties.Resources.Trophy;
            this.pictureBox1.Location = new System.Drawing.Point(97, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labSubTitle
            // 
            this.labSubTitle.AutoSize = true;
            this.labSubTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.labSubTitle.Location = new System.Drawing.Point(143, 267);
            this.labSubTitle.Name = "labSubTitle";
            this.labSubTitle.Size = new System.Drawing.Size(308, 45);
            this.labSubTitle.TabIndex = 1;
            this.labSubTitle.Text = "Think . Guess . Win";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Comic Sans MS", 50F);
            this.labTitle.Location = new System.Drawing.Point(24, 180);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(547, 95);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Guess the Word";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageIndex = 1;
            this.btnExit.ImageList = this.ILIcons;
            this.btnExit.Location = new System.Drawing.Point(132, 432);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(331, 77);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Black;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.ImageIndex = 0;
            this.btnPlay.ImageList = this.ILIcons;
            this.btnPlay.Location = new System.Drawing.Point(132, 349);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(331, 77);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // ILIcons
            // 
            this.ILIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILIcons.ImageStream")));
            this.ILIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ILIcons.Images.SetKeyName(0, "Icon_Play_Game.png");
            this.ILIcons.Images.SetKeyName(1, "Icon_Exit.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GuessTheWordGame_WinForms_CSharp.Properties.Resources.Backgroundpng;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 622);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Form1";
            this.Text = "Guess The Word Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labSubTitle;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ImageList ILIcons;
    }
}

