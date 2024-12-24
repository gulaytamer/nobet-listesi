namespace nöbet_lisrtesi
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
            btnDagit = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            txtTel_No = new TextBox();
            txtMeslek = new TextBox();
            txtAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            txtSoyad = new TextBox();
            ID = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDagit
            // 
            btnDagit.BackColor = Color.PowderBlue;
            btnDagit.Location = new Point(226, 209);
            btnDagit.Name = "btnDagit";
            btnDagit.Size = new Size(157, 139);
            btnDagit.TabIndex = 9;
            btnDagit.Text = "PERSONELİ DAĞIT";
            btnDagit.UseVisualStyleBackColor = false;
            btnDagit.Click += btnDagit_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(97, 319);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 8;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(97, 261);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(97, 209);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtTel_No
            // 
            txtTel_No.Location = new Point(178, 163);
            txtTel_No.Name = "txtTel_No";
            txtTel_No.Size = new Size(125, 27);
            txtTel_No.TabIndex = 5;
            // 
            // txtMeslek
            // 
            txtMeslek.Location = new Point(178, 130);
            txtMeslek.Name = "txtMeslek";
            txtMeslek.Size = new Size(125, 27);
            txtMeslek.TabIndex = 4;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(178, 64);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 166);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Tel No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 130);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Meslek";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 64);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.CadetBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(427, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(374, 453);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 97);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 11;
            label4.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(178, 97);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 12;
            txtSoyad.TextChanged += txtSoyad_TextChanged;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(111, 34);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 13;
            ID.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(178, 31);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(txtID);
            Controls.Add(ID);
            Controls.Add(txtSoyad);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btnDagit);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtTel_No);
            Controls.Add(txtMeslek);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDagit;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private TextBox txtTel_No;
        private TextBox txtMeslek;
        private TextBox txtAd;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox txtSoyad;
        private Label ID;
        private TextBox txtID;
    }
}
