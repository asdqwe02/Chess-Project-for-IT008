
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
            this.AIbutton = new System.Windows.Forms.Button();
            this.LANbutton = new System.Windows.Forms.Button();
            this.PRbutton = new System.Windows.Forms.Button();
            this.OTbutton = new System.Windows.Forms.Button();
            this.ABbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AIbutton
            // 
            this.AIbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AIbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIbutton.Location = new System.Drawing.Point(64, 49);
            this.AIbutton.Name = "AIbutton";
            this.AIbutton.Size = new System.Drawing.Size(199, 47);
            this.AIbutton.TabIndex = 0;
            this.AIbutton.Text = "Single Player";
            this.AIbutton.UseVisualStyleBackColor = true;
            this.AIbutton.Click += new System.EventHandler(this.AIbutton_Click);
            // 
            // LANbutton
            // 
            this.LANbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LANbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LANbutton.Location = new System.Drawing.Point(64, 168);
            this.LANbutton.Name = "LANbutton";
            this.LANbutton.Size = new System.Drawing.Size(199, 47);
            this.LANbutton.TabIndex = 1;
            this.LANbutton.Text = "MultiPlayer / LAN";
            this.LANbutton.UseVisualStyleBackColor = true;
            this.LANbutton.Click += new System.EventHandler(this.LANbutton_Click);
            // 
            // PRbutton
            // 
            this.PRbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PRbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRbutton.Location = new System.Drawing.Point(64, 285);
            this.PRbutton.Name = "PRbutton";
            this.PRbutton.Size = new System.Drawing.Size(199, 47);
            this.PRbutton.TabIndex = 2;
            this.PRbutton.Text = "Practice";
            this.PRbutton.UseVisualStyleBackColor = true;
            this.PRbutton.Click += new System.EventHandler(this.PRbutton_Click);
            // 
            // OTbutton
            // 
            this.OTbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OTbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTbutton.Location = new System.Drawing.Point(64, 395);
            this.OTbutton.Name = "OTbutton";
            this.OTbutton.Size = new System.Drawing.Size(199, 47);
            this.OTbutton.TabIndex = 3;
            this.OTbutton.Text = "Option";
            this.OTbutton.UseVisualStyleBackColor = true;
            this.OTbutton.Click += new System.EventHandler(this.OTbutton_Click);
            // 
            // ABbutton
            // 
            this.ABbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ABbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABbutton.Location = new System.Drawing.Point(64, 514);
            this.ABbutton.Name = "ABbutton";
            this.ABbutton.Size = new System.Drawing.Size(199, 47);
            this.ABbutton.TabIndex = 4;
            this.ABbutton.Text = "About";
            this.ABbutton.UseVisualStyleBackColor = true;
            this.ABbutton.Click += new System.EventHandler(this.ABbutton_Click);
            // 
            // Open
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChessForm.Properties.Resources.d6aa82bf6c37530d7521fd3f4164d516;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 616);
            this.Controls.Add(this.ABbutton);
            this.Controls.Add(this.OTbutton);
            this.Controls.Add(this.PRbutton);
            this.Controls.Add(this.LANbutton);
            this.Controls.Add(this.AIbutton);
            this.Name = "Open";
            this.Text = "Chess-Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AIbutton;
        private System.Windows.Forms.Button LANbutton;
        private System.Windows.Forms.Button PRbutton;
        private System.Windows.Forms.Button OTbutton;
        private System.Windows.Forms.Button ABbutton;
    }
}