namespace ChessForm
{
    partial class Pawn_Promotion
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
            this.Queen_Butt = new System.Windows.Forms.Button();
            this.Knight_Butt = new System.Windows.Forms.Button();
            this.Rook_Butt = new System.Windows.Forms.Button();
            this.Bishop_Butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Queen_Butt
            // 
            this.Queen_Butt.Location = new System.Drawing.Point(24, 62);
            this.Queen_Butt.Name = "Queen_Butt";
            this.Queen_Butt.Size = new System.Drawing.Size(63, 41);
            this.Queen_Butt.TabIndex = 0;
            this.Queen_Butt.Text = "Queen";
            this.Queen_Butt.UseVisualStyleBackColor = true;
            this.Queen_Butt.Click += new System.EventHandler(this.Queen_Butt_Click);
            // 
            // Knight_Butt
            // 
            this.Knight_Butt.Location = new System.Drawing.Point(212, 62);
            this.Knight_Butt.Name = "Knight_Butt";
            this.Knight_Butt.Size = new System.Drawing.Size(63, 41);
            this.Knight_Butt.TabIndex = 1;
            this.Knight_Butt.Text = "Knight";
            this.Knight_Butt.UseVisualStyleBackColor = true;
            this.Knight_Butt.Click += new System.EventHandler(this.Knight_Butt_Click);
            // 
            // Rook_Butt
            // 
            this.Rook_Butt.Location = new System.Drawing.Point(119, 62);
            this.Rook_Butt.Name = "Rook_Butt";
            this.Rook_Butt.Size = new System.Drawing.Size(63, 41);
            this.Rook_Butt.TabIndex = 2;
            this.Rook_Butt.Text = "Rook";
            this.Rook_Butt.UseVisualStyleBackColor = true;
            this.Rook_Butt.Click += new System.EventHandler(this.Rook_Butt_Click);
            // 
            // Bishop_Butt
            // 
            this.Bishop_Butt.Location = new System.Drawing.Point(309, 62);
            this.Bishop_Butt.Name = "Bishop_Butt";
            this.Bishop_Butt.Size = new System.Drawing.Size(63, 41);
            this.Bishop_Butt.TabIndex = 3;
            this.Bishop_Butt.Text = "Bishop";
            this.Bishop_Butt.UseVisualStyleBackColor = true;
            this.Bishop_Butt.Click += new System.EventHandler(this.Bishop_Butt_Click);
            // 
            // Pawn_Promotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 169);
            this.Controls.Add(this.Bishop_Butt);
            this.Controls.Add(this.Rook_Butt);
            this.Controls.Add(this.Knight_Butt);
            this.Controls.Add(this.Queen_Butt);
            this.Name = "Pawn_Promotion";
            this.Text = "Pawn Promotion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Queen_Butt;
        private System.Windows.Forms.Button Knight_Butt;
        private System.Windows.Forms.Button Rook_Butt;
        private System.Windows.Forms.Button Bishop_Butt;
    }
}