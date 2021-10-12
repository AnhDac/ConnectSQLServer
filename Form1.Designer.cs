
namespace WindowsFormsApp1
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
            this.btnShowNV = new System.Windows.Forms.Button();
            this.dgvPhongTro = new System.Windows.Forms.DataGridView();
            this.btnShowPhongTro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowNV
            // 
            this.btnShowNV.Location = new System.Drawing.Point(43, 30);
            this.btnShowNV.Name = "btnShowNV";
            this.btnShowNV.Size = new System.Drawing.Size(144, 44);
            this.btnShowNV.TabIndex = 0;
            this.btnShowNV.Text = "Show Nhân Viên";
            this.btnShowNV.UseVisualStyleBackColor = true;
            this.btnShowNV.Click += new System.EventHandler(this.btnShowNV_Click);
            // 
            // dgvPhongTro
            // 
            this.dgvPhongTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongTro.Location = new System.Drawing.Point(30, 115);
            this.dgvPhongTro.Name = "dgvPhongTro";
            this.dgvPhongTro.RowHeadersWidth = 51;
            this.dgvPhongTro.RowTemplate.Height = 24;
            this.dgvPhongTro.Size = new System.Drawing.Size(678, 283);
            this.dgvPhongTro.TabIndex = 1;
            // 
            // btnShowPhongTro
            // 
            this.btnShowPhongTro.Location = new System.Drawing.Point(249, 30);
            this.btnShowPhongTro.Name = "btnShowPhongTro";
            this.btnShowPhongTro.Size = new System.Drawing.Size(144, 44);
            this.btnShowPhongTro.TabIndex = 2;
            this.btnShowPhongTro.Text = "Show Phòng Trọ";
            this.btnShowPhongTro.UseVisualStyleBackColor = true;
            this.btnShowPhongTro.Click += new System.EventHandler(this.btnShowPhongTro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 454);
            this.Controls.Add(this.btnShowPhongTro);
            this.Controls.Add(this.dgvPhongTro);
            this.Controls.Add(this.btnShowNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly Phong Tro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowNV;
        private System.Windows.Forms.DataGridView dgvPhongTro;
        private System.Windows.Forms.Button btnShowPhongTro;
    }
}

