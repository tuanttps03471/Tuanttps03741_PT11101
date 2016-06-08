namespace Tuanttps03741_PT11101
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
            this.txtthem = new System.Windows.Forms.Button();
            this.txtimageSQL = new System.Windows.Forms.TextBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tnttepimage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtthem
            // 
            this.txtthem.Location = new System.Drawing.Point(170, 39);
            this.txtthem.Name = "txtthem";
            this.txtthem.Size = new System.Drawing.Size(75, 23);
            this.txtthem.TabIndex = 0;
            this.txtthem.Text = "Thêm image";
            this.txtthem.UseVisualStyleBackColor = true;
            this.txtthem.Click += new System.EventHandler(this.txtthem_Click);
            // 
            // txtimageSQL
            // 
            this.txtimageSQL.Location = new System.Drawing.Point(262, 42);
            this.txtimageSQL.Name = "txtimageSQL";
            this.txtimageSQL.Size = new System.Drawing.Size(181, 20);
            this.txtimageSQL.TabIndex = 1;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(271, 83);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(119, 23);
            this.btnSelectImage.TabIndex = 2;
            this.btnSelectImage.Text = "Thêm hình ảnh";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 150);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tnttepimage
            // 
            this.tnttepimage.Location = new System.Drawing.Point(467, 38);
            this.tnttepimage.Name = "tnttepimage";
            this.tnttepimage.Size = new System.Drawing.Size(75, 23);
            this.tnttepimage.TabIndex = 4;
            this.tnttepimage.Text = "Tệp hình ảnh";
            this.tnttepimage.UseVisualStyleBackColor = true;
            this.tnttepimage.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 193);
            this.Controls.Add(this.tnttepimage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.txtimageSQL);
            this.Controls.Add(this.txtthem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtthem;
        private System.Windows.Forms.TextBox txtimageSQL;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tnttepimage;
    }
}

