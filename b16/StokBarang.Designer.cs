﻿namespace b16
{
    partial class StokBarang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nama_barang = new System.Windows.Forms.TextBox();
            this.jumlah_barang = new System.Windows.Forms.NumericUpDown();
            this.harga_barang = new System.Windows.Forms.NumericUpDown();
            this.jenis_barang = new System.Windows.Forms.TextBox();
            this.simpan = new System.Windows.Forms.Button();
            this.TabelProduk = new System.Windows.Forms.DataGridView();
            this.id_hapus = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.hapus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.id_update = new System.Windows.Forms.NumericUpDown();
            this.edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jumlah_barang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harga_barang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelProduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_hapus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_update)).BeginInit();
            this.SuspendLayout();
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.ForeColor = System.Drawing.Color.White;
            this.label0.Location = new System.Drawing.Point(91, 52);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(156, 25);
            this.label0.TabIndex = 0;
            this.label0.Text = "Nama Barang :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jumlah Barang :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Harga Barang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jenis Barang :";
            // 
            // nama_barang
            // 
            this.nama_barang.Location = new System.Drawing.Point(266, 57);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(339, 20);
            this.nama_barang.TabIndex = 4;
            // 
            // jumlah_barang
            // 
            this.jumlah_barang.Location = new System.Drawing.Point(266, 97);
            this.jumlah_barang.Name = "jumlah_barang";
            this.jumlah_barang.Size = new System.Drawing.Size(120, 20);
            this.jumlah_barang.TabIndex = 5;
            // 
            // harga_barang
            // 
            this.harga_barang.Location = new System.Drawing.Point(266, 139);
            this.harga_barang.Name = "harga_barang";
            this.harga_barang.Size = new System.Drawing.Size(120, 20);
            this.harga_barang.TabIndex = 6;
            // 
            // jenis_barang
            // 
            this.jenis_barang.Location = new System.Drawing.Point(266, 177);
            this.jenis_barang.Name = "jenis_barang";
            this.jenis_barang.Size = new System.Drawing.Size(339, 20);
            this.jenis_barang.TabIndex = 7;
            // 
            // simpan
            // 
            this.simpan.Location = new System.Drawing.Point(266, 214);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(81, 27);
            this.simpan.TabIndex = 8;
            this.simpan.Text = "Simpan";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // TabelProduk
            // 
            this.TabelProduk.AllowUserToAddRows = false;
            this.TabelProduk.AllowUserToDeleteRows = false;
            this.TabelProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelProduk.Location = new System.Drawing.Point(147, 263);
            this.TabelProduk.Name = "TabelProduk";
            this.TabelProduk.Size = new System.Drawing.Size(509, 150);
            this.TabelProduk.TabIndex = 9;
            this.TabelProduk.Click += new System.EventHandler(this.TabelProduk_Click);
            // 
            // id_hapus
            // 
            this.id_hapus.Location = new System.Drawing.Point(717, 180);
            this.id_hapus.Name = "id_hapus";
            this.id_hapus.Size = new System.Drawing.Size(46, 20);
            this.id_hapus.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(685, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hapus Data";
            // 
            // hapus
            // 
            this.hapus.BackColor = System.Drawing.Color.Red;
            this.hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus.ForeColor = System.Drawing.Color.White;
            this.hapus.Location = new System.Drawing.Point(700, 213);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(75, 23);
            this.hapus.TabIndex = 12;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = false;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(691, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Update Data";
            // 
            // id_update
            // 
            this.id_update.Location = new System.Drawing.Point(717, 72);
            this.id_update.Name = "id_update";
            this.id_update.Size = new System.Drawing.Size(46, 20);
            this.id_update.TabIndex = 14;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Yellow;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.Black;
            this.edit.Location = new System.Drawing.Point(700, 98);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 15;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // StokBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.edit);
            this.Controls.Add(this.id_update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id_hapus);
            this.Controls.Add(this.TabelProduk);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.jenis_barang);
            this.Controls.Add(this.harga_barang);
            this.Controls.Add(this.jumlah_barang);
            this.Controls.Add(this.nama_barang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Name = "StokBarang";
            this.Size = new System.Drawing.Size(812, 450);
            ((System.ComponentModel.ISupportInitialize)(this.jumlah_barang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harga_barang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelProduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_hapus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nama_barang;
        private System.Windows.Forms.NumericUpDown jumlah_barang;
        private System.Windows.Forms.NumericUpDown harga_barang;
        private System.Windows.Forms.TextBox jenis_barang;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.DataGridView TabelProduk;
        private System.Windows.Forms.NumericUpDown id_hapus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown id_update;
        private System.Windows.Forms.Button edit;
    }
}
