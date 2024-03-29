﻿namespace ChessForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PiecesImageList = new System.Windows.Forms.ImageList(this.components);
            this.coordinates = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.BlackTurn = new System.Windows.Forms.PictureBox();
            this.WhiteTurn = new System.Windows.Forms.PictureBox();
            this.BlackTimeM = new System.Windows.Forms.TextBox();
            this.BlackTimeS = new System.Windows.Forms.TextBox();
            this.WhiteTimeS = new System.Windows.Forms.TextBox();
            this.WhiteTimeM = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BlackTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 44);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 642);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PiecesImageList
            // 
            this.PiecesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PiecesImageList.ImageStream")));
            this.PiecesImageList.TransparentColor = System.Drawing.SystemColors.HotTrack;
            this.PiecesImageList.Images.SetKeyName(0, "Bishop Black 60x60.png");
            this.PiecesImageList.Images.SetKeyName(1, "King Black 60x60.png");
            this.PiecesImageList.Images.SetKeyName(2, "Knight Black 60x60.png");
            this.PiecesImageList.Images.SetKeyName(3, "Pawn Black 60x60.png");
            this.PiecesImageList.Images.SetKeyName(4, "Queen Black 60x60.png");
            this.PiecesImageList.Images.SetKeyName(5, "Rook Black 60x60.png");
            this.PiecesImageList.Images.SetKeyName(6, "Bishop White 60x60.png");
            this.PiecesImageList.Images.SetKeyName(7, "King White 60x60.png");
            this.PiecesImageList.Images.SetKeyName(8, "Knight White 60x60.png");
            this.PiecesImageList.Images.SetKeyName(9, "Pawn White 60x60.png");
            this.PiecesImageList.Images.SetKeyName(10, "Queen White 60x60.png");
            this.PiecesImageList.Images.SetKeyName(11, "Rook White 60x60.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(83, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(167, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(437, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "E";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(345, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(259, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(520, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "F";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(613, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "G";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(695, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "H";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(12, 471);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(12, 391);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(12, 311);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 29);
            this.label12.TabIndex = 13;
            this.label12.Text = "5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(12, 226);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 29);
            this.label13.TabIndex = 14;
            this.label13.Text = "6";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(12, 152);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 29);
            this.label14.TabIndex = 15;
            this.label14.Text = "7";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(12, 559);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 29);
            this.label15.TabIndex = 16;
            this.label15.Text = "2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font(".VnAristote", 16.2F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(12, 637);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 29);
            this.label16.TabIndex = 17;
            this.label16.Text = "1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Agency FB", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(903, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 79);
            this.button1.TabIndex = 18;
            this.button1.Text = "Surrender";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(884, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(215, 44);
            this.label17.TabIndex = 19;
            this.label17.Text = "Black Player";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(884, 642);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(231, 44);
            this.label18.TabIndex = 20;
            this.label18.Text = "White Player";
            // 
            // BlackTurn
            // 
            this.BlackTurn.BackColor = System.Drawing.Color.Transparent;
            this.BlackTurn.BackgroundImage = global::ChessForm.Properties.Resources.ikoni_scrollup;
            this.BlackTurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BlackTurn.Location = new System.Drawing.Point(966, 262);
            this.BlackTurn.Name = "BlackTurn";
            this.BlackTurn.Size = new System.Drawing.Size(62, 56);
            this.BlackTurn.TabIndex = 21;
            this.BlackTurn.TabStop = false;
            // 
            // WhiteTurn
            // 
            this.WhiteTurn.BackColor = System.Drawing.Color.Transparent;
            this.WhiteTurn.BackgroundImage = global::ChessForm.Properties.Resources.ikoni_scrollup2;
            this.WhiteTurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WhiteTurn.Location = new System.Drawing.Point(966, 409);
            this.WhiteTurn.Name = "WhiteTurn";
            this.WhiteTurn.Size = new System.Drawing.Size(62, 55);
            this.WhiteTurn.TabIndex = 22;
            this.WhiteTurn.TabStop = false;
            // 
            // BlackTimeM
            // 
            this.BlackTimeM.BackColor = System.Drawing.Color.Black;
            this.BlackTimeM.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackTimeM.ForeColor = System.Drawing.Color.White;
            this.BlackTimeM.Location = new System.Drawing.Point(903, 128);
            this.BlackTimeM.Multiline = true;
            this.BlackTimeM.Name = "BlackTimeM";
            this.BlackTimeM.ReadOnly = true;
            this.BlackTimeM.Size = new System.Drawing.Size(101, 64);
            this.BlackTimeM.TabIndex = 25;
            this.BlackTimeM.Text = "60";
            this.BlackTimeM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BlackTimeS
            // 
            this.BlackTimeS.BackColor = System.Drawing.Color.White;
            this.BlackTimeS.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackTimeS.ForeColor = System.Drawing.Color.Black;
            this.BlackTimeS.Location = new System.Drawing.Point(996, 152);
            this.BlackTimeS.Multiline = true;
            this.BlackTimeS.Name = "BlackTimeS";
            this.BlackTimeS.ReadOnly = true;
            this.BlackTimeS.Size = new System.Drawing.Size(94, 64);
            this.BlackTimeS.TabIndex = 26;
            this.BlackTimeS.Text = "00";
            this.BlackTimeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WhiteTimeS
            // 
            this.WhiteTimeS.BackColor = System.Drawing.Color.Black;
            this.WhiteTimeS.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteTimeS.ForeColor = System.Drawing.Color.White;
            this.WhiteTimeS.Location = new System.Drawing.Point(996, 536);
            this.WhiteTimeS.Multiline = true;
            this.WhiteTimeS.Name = "WhiteTimeS";
            this.WhiteTimeS.ReadOnly = true;
            this.WhiteTimeS.Size = new System.Drawing.Size(94, 64);
            this.WhiteTimeS.TabIndex = 28;
            this.WhiteTimeS.Text = "00";
            this.WhiteTimeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WhiteTimeM
            // 
            this.WhiteTimeM.BackColor = System.Drawing.Color.White;
            this.WhiteTimeM.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteTimeM.ForeColor = System.Drawing.Color.Black;
            this.WhiteTimeM.Location = new System.Drawing.Point(903, 512);
            this.WhiteTimeM.Multiline = true;
            this.WhiteTimeM.Name = "WhiteTimeM";
            this.WhiteTimeM.ReadOnly = true;
            this.WhiteTimeM.Size = new System.Drawing.Size(101, 64);
            this.WhiteTimeM.TabIndex = 27;
            this.WhiteTimeM.Text = "60";
            this.WhiteTimeM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChessForm.Properties.Resources.wp5313510;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 709);
            this.ControlBox = false;
            this.Controls.Add(this.WhiteTimeS);
            this.Controls.Add(this.WhiteTimeM);
            this.Controls.Add(this.BlackTimeS);
            this.Controls.Add(this.BlackTimeM);
            this.Controls.Add(this.WhiteTurn);
            this.Controls.Add(this.BlackTurn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1234, 756);
            this.MinimumSize = new System.Drawing.Size(1234, 756);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versus Human";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BlackTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteTurn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList PiecesImageList;
        private System.Windows.Forms.ToolTip coordinates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox BlackTurn;
        private System.Windows.Forms.PictureBox WhiteTurn;
        private System.Windows.Forms.TextBox BlackTimeM;
        private System.Windows.Forms.TextBox BlackTimeS;
        private System.Windows.Forms.TextBox WhiteTimeS;
        private System.Windows.Forms.TextBox WhiteTimeM;
        private System.Windows.Forms.Timer timer1;
    }
}

