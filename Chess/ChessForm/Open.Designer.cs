
namespace ChessForm
{
    partial class Open
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Open));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Menuu = new System.Windows.Forms.GroupBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.PracticeButton = new System.Windows.Forms.Button();
            this.MultiButton = new System.Windows.Forms.Button();
            this.SingleButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Menuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(80, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 268);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHESS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(121, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 79);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assert YourSelf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(-17, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(653, 79);
            this.label3.TabIndex = 2;
            this.label3.Text = " --    By Your Intelligence    --";
            // 
            // Menuu
            // 
            this.Menuu.BackColor = System.Drawing.Color.Transparent;
            this.Menuu.Controls.Add(this.pictureBox2);
            this.Menuu.Controls.Add(this.QuitButton);
            this.Menuu.Controls.Add(this.AboutButton);
            this.Menuu.Controls.Add(this.PracticeButton);
            this.Menuu.Controls.Add(this.MultiButton);
            this.Menuu.Controls.Add(this.SingleButton);
            this.Menuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menuu.Location = new System.Drawing.Point(761, 12);
            this.Menuu.Name = "Menuu";
            this.Menuu.Size = new System.Drawing.Size(449, 549);
            this.Menuu.TabIndex = 3;
            this.Menuu.TabStop = false;
            this.Menuu.Text = "Menu";
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QuitButton.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.White;
            this.QuitButton.Location = new System.Drawing.Point(20, 463);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(219, 80);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            this.QuitButton.MouseLeave += new System.EventHandler(this.SingleButton_MouseLeave);
            this.QuitButton.MouseHover += new System.EventHandler(this.SingleButton_MouseHover);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AboutButton.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Location = new System.Drawing.Point(224, 377);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(219, 80);
            this.AboutButton.TabIndex = 3;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            this.AboutButton.MouseLeave += new System.EventHandler(this.SingleButton_MouseLeave);
            this.AboutButton.MouseHover += new System.EventHandler(this.SingleButton_MouseHover);
            // 
            // PracticeButton
            // 
            this.PracticeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PracticeButton.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PracticeButton.ForeColor = System.Drawing.Color.White;
            this.PracticeButton.Location = new System.Drawing.Point(20, 291);
            this.PracticeButton.Name = "PracticeButton";
            this.PracticeButton.Size = new System.Drawing.Size(219, 80);
            this.PracticeButton.TabIndex = 2;
            this.PracticeButton.Text = "Practice";
            this.PracticeButton.UseVisualStyleBackColor = false;
            this.PracticeButton.Click += new System.EventHandler(this.PracticeButton_Click);
            this.PracticeButton.MouseLeave += new System.EventHandler(this.SingleButton_MouseLeave);
            this.PracticeButton.MouseHover += new System.EventHandler(this.SingleButton_MouseHover);
            // 
            // MultiButton
            // 
            this.MultiButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MultiButton.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiButton.ForeColor = System.Drawing.Color.White;
            this.MultiButton.Location = new System.Drawing.Point(224, 205);
            this.MultiButton.Name = "MultiButton";
            this.MultiButton.Size = new System.Drawing.Size(219, 80);
            this.MultiButton.TabIndex = 1;
            this.MultiButton.Text = "MultiPlayer";
            this.MultiButton.UseVisualStyleBackColor = false;
            this.MultiButton.Click += new System.EventHandler(this.MultiButton_Click);
            this.MultiButton.MouseLeave += new System.EventHandler(this.SingleButton_MouseLeave);
            this.MultiButton.MouseHover += new System.EventHandler(this.SingleButton_MouseHover);
            // 
            // SingleButton
            // 
            this.SingleButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SingleButton.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleButton.ForeColor = System.Drawing.Color.White;
            this.SingleButton.Location = new System.Drawing.Point(20, 119);
            this.SingleButton.Name = "SingleButton";
            this.SingleButton.Size = new System.Drawing.Size(219, 80);
            this.SingleButton.TabIndex = 0;
            this.SingleButton.Text = "SinglePlayer";
            this.SingleButton.UseVisualStyleBackColor = false;
            this.SingleButton.Click += new System.EventHandler(this.SingleButton_Click);
            this.SingleButton.MouseLeave += new System.EventHandler(this.SingleButton_MouseLeave);
            this.SingleButton.MouseHover += new System.EventHandler(this.SingleButton_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ChessForm.Properties.Resources.Youtube_Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(72, 482);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 73);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::ChessForm.Properties.Resources.pngfind_com_rules_png_420867;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(138, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 73);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::ChessForm.Properties.Resources.db238be9_b433_4904_9555_fe342bc795de_200x200;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(178, 448);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(246, 138);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Open
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 64F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = global::ChessForm.Properties.Resources.chess_wide;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1222, 584);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Menuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1240, 631);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1240, 631);
            this.Name = "Open";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChessGame";
            this.Menuu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Menuu;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button PracticeButton;
        private System.Windows.Forms.Button MultiButton;
        private System.Windows.Forms.Button SingleButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}