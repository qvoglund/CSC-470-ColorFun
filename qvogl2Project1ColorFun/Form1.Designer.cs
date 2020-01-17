namespace qvogl2Project1ColorFun
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.redTextBox = new System.Windows.Forms.TextBox();
            this.greenTextBox = new System.Windows.Forms.TextBox();
            this.blueTextBox = new System.Windows.Forms.TextBox();
            this.alphaTextBox = new System.Windows.Forms.TextBox();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.alphaTrackBar = new System.Windows.Forms.TrackBar();
            this.redBit = new System.Windows.Forms.TextBox();
            this.greenBit = new System.Windows.Forms.TextBox();
            this.blueBit = new System.Windows.Forms.TextBox();
            this.alphaBit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 172);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(12, 216);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(566, 45);
            this.redTrackBar.TabIndex = 1;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // redTextBox
            // 
            this.redTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redTextBox.Location = new System.Drawing.Point(12, 197);
            this.redTextBox.Name = "redTextBox";
            this.redTextBox.Size = new System.Drawing.Size(100, 13);
            this.redTextBox.TabIndex = 2;
            this.redTextBox.Text = "Red";
            // 
            // greenTextBox
            // 
            this.greenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.greenTextBox.Location = new System.Drawing.Point(12, 267);
            this.greenTextBox.Name = "greenTextBox";
            this.greenTextBox.Size = new System.Drawing.Size(100, 13);
            this.greenTextBox.TabIndex = 3;
            this.greenTextBox.Text = "Green";
            // 
            // blueTextBox
            // 
            this.blueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blueTextBox.Location = new System.Drawing.Point(12, 337);
            this.blueTextBox.Name = "blueTextBox";
            this.blueTextBox.Size = new System.Drawing.Size(100, 13);
            this.blueTextBox.TabIndex = 4;
            this.blueTextBox.Text = "Blue";
            // 
            // alphaTextBox
            // 
            this.alphaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alphaTextBox.Location = new System.Drawing.Point(12, 407);
            this.alphaTextBox.Name = "alphaTextBox";
            this.alphaTextBox.Size = new System.Drawing.Size(100, 13);
            this.alphaTextBox.TabIndex = 5;
            this.alphaTextBox.Text = "Alpha";
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(12, 286);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(566, 45);
            this.greenTrackBar.TabIndex = 6;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.Location = new System.Drawing.Point(12, 356);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(566, 45);
            this.blueTrackBar.TabIndex = 7;
            this.blueTrackBar.Scroll += new System.EventHandler(this.blueTrackBar_Scroll);
            // 
            // alphaTrackBar
            // 
            this.alphaTrackBar.Location = new System.Drawing.Point(12, 426);
            this.alphaTrackBar.Maximum = 255;
            this.alphaTrackBar.Name = "alphaTrackBar";
            this.alphaTrackBar.Size = new System.Drawing.Size(566, 45);
            this.alphaTrackBar.TabIndex = 8;
            this.alphaTrackBar.Scroll += new System.EventHandler(this.alphaTrackBar_Scroll);
            // 
            // redBit
            // 
            this.redBit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redBit.Location = new System.Drawing.Point(477, 197);
            this.redBit.Name = "redBit";
            this.redBit.Size = new System.Drawing.Size(100, 13);
            this.redBit.TabIndex = 9;
            this.redBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // greenBit
            // 
            this.greenBit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.greenBit.Location = new System.Drawing.Point(477, 267);
            this.greenBit.Name = "greenBit";
            this.greenBit.Size = new System.Drawing.Size(100, 13);
            this.greenBit.TabIndex = 10;
            this.greenBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // blueBit
            // 
            this.blueBit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blueBit.Location = new System.Drawing.Point(478, 337);
            this.blueBit.Name = "blueBit";
            this.blueBit.Size = new System.Drawing.Size(100, 13);
            this.blueBit.TabIndex = 11;
            this.blueBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // alphaBit
            // 
            this.alphaBit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alphaBit.Location = new System.Drawing.Point(477, 407);
            this.alphaBit.Name = "alphaBit";
            this.alphaBit.Size = new System.Drawing.Size(100, 13);
            this.alphaBit.TabIndex = 12;
            this.alphaBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 485);
            this.Controls.Add(this.alphaBit);
            this.Controls.Add(this.blueBit);
            this.Controls.Add(this.greenBit);
            this.Controls.Add(this.redBit);
            this.Controls.Add(this.alphaTrackBar);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.alphaTextBox);
            this.Controls.Add(this.blueTextBox);
            this.Controls.Add(this.greenTextBox);
            this.Controls.Add(this.redTextBox);
            this.Controls.Add(this.redTrackBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Color Fun";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.TextBox redTextBox;
        private System.Windows.Forms.TextBox greenTextBox;
        private System.Windows.Forms.TextBox blueTextBox;
        private System.Windows.Forms.TextBox alphaTextBox;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.TrackBar alphaTrackBar;
        private System.Windows.Forms.TextBox redBit;
        private System.Windows.Forms.TextBox greenBit;
        private System.Windows.Forms.TextBox blueBit;
        private System.Windows.Forms.TextBox alphaBit;
    }
}

