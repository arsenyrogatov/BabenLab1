namespace BabenLab1
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
            this.openFile_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileStatus_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.r_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.g_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.b_pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.r_pictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g_pictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFile_button
            // 
            this.openFile_button.AutoSize = true;
            this.openFile_button.Location = new System.Drawing.Point(10, 10);
            this.openFile_button.Name = "openFile_button";
            this.openFile_button.Size = new System.Drawing.Size(110, 27);
            this.openFile_button.TabIndex = 0;
            this.openFile_button.Text = "Выберите файл";
            this.openFile_button.UseVisualStyleBackColor = true;
            this.openFile_button.Click += new System.EventHandler(this.openFile_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.fileStatus_label);
            this.panel1.Controls.Add(this.openFile_button);
            this.panel1.Location = new System.Drawing.Point(11, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 50);
            this.panel1.TabIndex = 1;
            // 
            // fileStatus_label
            // 
            this.fileStatus_label.AutoSize = true;
            this.fileStatus_label.Location = new System.Drawing.Point(126, 15);
            this.fileStatus_label.Name = "fileStatus_label";
            this.fileStatus_label.Size = new System.Drawing.Size(106, 17);
            this.fileStatus_label.TabIndex = 1;
            this.fileStatus_label.Text = "Файл не выбран";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.r_pictureBox);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 284);
            this.panel2.TabIndex = 2;
            // 
            // r_pictureBox
            // 
            this.r_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.r_pictureBox.Name = "r_pictureBox";
            this.r_pictureBox.Size = new System.Drawing.Size(276, 276);
            this.r_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.r_pictureBox.TabIndex = 0;
            this.r_pictureBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.g_pictureBox);
            this.panel3.Location = new System.Drawing.Point(302, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 284);
            this.panel3.TabIndex = 3;
            // 
            // g_pictureBox
            // 
            this.g_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.g_pictureBox.Name = "g_pictureBox";
            this.g_pictureBox.Size = new System.Drawing.Size(276, 276);
            this.g_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.g_pictureBox.TabIndex = 0;
            this.g_pictureBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.b_pictureBox);
            this.panel4.Location = new System.Drawing.Point(592, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 284);
            this.panel4.TabIndex = 3;
            // 
            // b_pictureBox
            // 
            this.b_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.b_pictureBox.Name = "b_pictureBox";
            this.b_pictureBox.Size = new System.Drawing.Size(276, 276);
            this.b_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b_pictureBox.TabIndex = 0;
            this.b_pictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "BMP files (*.BMP)|*.bmp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 368);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаба 1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.r_pictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.g_pictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.b_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button openFile_button;
        private Panel panel1;
        private Label fileStatus_label;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox r_pictureBox;
        private PictureBox g_pictureBox;
        private PictureBox b_pictureBox;
        private OpenFileDialog openFileDialog;
    }
}