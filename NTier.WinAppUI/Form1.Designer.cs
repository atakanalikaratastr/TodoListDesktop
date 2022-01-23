
namespace NTier.WinAppUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnTamamlanmisGorevler = new System.Windows.Forms.Button();
            this.btnTamamlanmamisGorevler = new System.Windows.Forms.Button();
            this.btnTumListeyiGetir = new System.Windows.Forms.Button();
            this.gbAnaGorevListeleme = new System.Windows.Forms.GroupBox();
            this.btnSecilenYilaGoreAra = new System.Windows.Forms.Button();
            this.btnAnaGorevAra = new System.Windows.Forms.Button();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.gbAnaGorevArama = new System.Windows.Forms.GroupBox();
            this.txtIsimVeyaAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGorevOlusturma = new System.Windows.Forms.GroupBox();
            this.txtGorevNotu = new System.Windows.Forms.TextBox();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGoreviSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbAnaGorevListeleme.SuspendLayout();
            this.gbAnaGorevArama.SuspendLayout();
            this.gbGorevOlusturma.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(658, 357);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 407);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(653, 264);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnTamamlanmisGorevler
            // 
            this.btnTamamlanmisGorevler.Location = new System.Drawing.Point(10, 4);
            this.btnTamamlanmisGorevler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTamamlanmisGorevler.Name = "btnTamamlanmisGorevler";
            this.btnTamamlanmisGorevler.Size = new System.Drawing.Size(168, 22);
            this.btnTamamlanmisGorevler.TabIndex = 2;
            this.btnTamamlanmisGorevler.Text = "Tamamlanmış Görevler";
            this.btnTamamlanmisGorevler.UseVisualStyleBackColor = true;
            this.btnTamamlanmisGorevler.Click += new System.EventHandler(this.btnTamamlanmisGorevler_Click);
            // 
            // btnTamamlanmamisGorevler
            // 
            this.btnTamamlanmamisGorevler.Location = new System.Drawing.Point(184, 4);
            this.btnTamamlanmamisGorevler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTamamlanmamisGorevler.Name = "btnTamamlanmamisGorevler";
            this.btnTamamlanmamisGorevler.Size = new System.Drawing.Size(168, 22);
            this.btnTamamlanmamisGorevler.TabIndex = 3;
            this.btnTamamlanmamisGorevler.Text = "Tamamlanmamış Görevler";
            this.btnTamamlanmamisGorevler.UseVisualStyleBackColor = true;
            this.btnTamamlanmamisGorevler.Click += new System.EventHandler(this.btnTamamlanmamisGorevler_Click);
            // 
            // btnTumListeyiGetir
            // 
            this.btnTumListeyiGetir.Location = new System.Drawing.Point(421, 4);
            this.btnTumListeyiGetir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTumListeyiGetir.Name = "btnTumListeyiGetir";
            this.btnTumListeyiGetir.Size = new System.Drawing.Size(114, 22);
            this.btnTumListeyiGetir.TabIndex = 4;
            this.btnTumListeyiGetir.Text = "Tüm Listeyi Getir";
            this.btnTumListeyiGetir.UseVisualStyleBackColor = true;
            this.btnTumListeyiGetir.Click += new System.EventHandler(this.btnTumListeyiGetir_Click);
            // 
            // gbAnaGorevListeleme
            // 
            this.gbAnaGorevListeleme.Controls.Add(this.btnSecilenYilaGoreAra);
            this.gbAnaGorevListeleme.Controls.Add(this.btnAnaGorevAra);
            this.gbAnaGorevListeleme.Controls.Add(this.cmbYil);
            this.gbAnaGorevListeleme.Controls.Add(this.cmbAy);
            this.gbAnaGorevListeleme.Location = new System.Drawing.Point(674, 452);
            this.gbAnaGorevListeleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAnaGorevListeleme.Name = "gbAnaGorevListeleme";
            this.gbAnaGorevListeleme.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAnaGorevListeleme.Size = new System.Drawing.Size(248, 126);
            this.gbAnaGorevListeleme.TabIndex = 5;
            this.gbAnaGorevListeleme.TabStop = false;
            this.gbAnaGorevListeleme.Text = "Ay ve Yıla Göre Ana Görev Listele";
            // 
            // btnSecilenYilaGoreAra
            // 
            this.btnSecilenYilaGoreAra.Location = new System.Drawing.Point(10, 86);
            this.btnSecilenYilaGoreAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSecilenYilaGoreAra.Name = "btnSecilenYilaGoreAra";
            this.btnSecilenYilaGoreAra.Size = new System.Drawing.Size(233, 22);
            this.btnSecilenYilaGoreAra.TabIndex = 3;
            this.btnSecilenYilaGoreAra.Text = "Seçilen Yıla Göre Ara";
            this.btnSecilenYilaGoreAra.UseVisualStyleBackColor = true;
            this.btnSecilenYilaGoreAra.Click += new System.EventHandler(this.btnSecilenYilaGoreAra_Click);
            // 
            // btnAnaGorevAra
            // 
            this.btnAnaGorevAra.Location = new System.Drawing.Point(160, 36);
            this.btnAnaGorevAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnaGorevAra.Name = "btnAnaGorevAra";
            this.btnAnaGorevAra.Size = new System.Drawing.Size(82, 22);
            this.btnAnaGorevAra.TabIndex = 2;
            this.btnAnaGorevAra.Text = "Ara";
            this.btnAnaGorevAra.UseVisualStyleBackColor = true;
            this.btnAnaGorevAra.Click += new System.EventHandler(this.btnAnaGorevAra_Click);
            // 
            // cmbYil
            // 
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Location = new System.Drawing.Point(10, 45);
            this.cmbYil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(133, 23);
            this.cmbYil.TabIndex = 1;
            // 
            // cmbAy
            // 
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Location = new System.Drawing.Point(10, 20);
            this.cmbAy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(133, 23);
            this.cmbAy.TabIndex = 0;
            // 
            // gbAnaGorevArama
            // 
            this.gbAnaGorevArama.Controls.Add(this.txtIsimVeyaAciklama);
            this.gbAnaGorevArama.Controls.Add(this.label1);
            this.gbAnaGorevArama.Location = new System.Drawing.Point(674, 31);
            this.gbAnaGorevArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAnaGorevArama.Name = "gbAnaGorevArama";
            this.gbAnaGorevArama.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAnaGorevArama.Size = new System.Drawing.Size(322, 48);
            this.gbAnaGorevArama.TabIndex = 6;
            this.gbAnaGorevArama.TabStop = false;
            this.gbAnaGorevArama.Text = "Görev İsmine veya Açıklamasına Göre Ara";
            // 
            // txtIsimVeyaAciklama
            // 
            this.txtIsimVeyaAciklama.Location = new System.Drawing.Point(41, 20);
            this.txtIsimVeyaAciklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsimVeyaAciklama.Name = "txtIsimVeyaAciklama";
            this.txtIsimVeyaAciklama.Size = new System.Drawing.Size(273, 23);
            this.txtIsimVeyaAciklama.TabIndex = 1;
            this.txtIsimVeyaAciklama.TextChanged += new System.EventHandler(this.txtIsimVeyaAciklama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ara:";
            // 
            // gbGorevOlusturma
            // 
            this.gbGorevOlusturma.Controls.Add(this.txtGorevNotu);
            this.gbGorevOlusturma.Controls.Add(this.txtGorev);
            this.gbGorevOlusturma.Controls.Add(this.label3);
            this.gbGorevOlusturma.Controls.Add(this.label2);
            this.gbGorevOlusturma.Location = new System.Drawing.Point(674, 83);
            this.gbGorevOlusturma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGorevOlusturma.Name = "gbGorevOlusturma";
            this.gbGorevOlusturma.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGorevOlusturma.Size = new System.Drawing.Size(313, 312);
            this.gbGorevOlusturma.TabIndex = 7;
            this.gbGorevOlusturma.TabStop = false;
            this.gbGorevOlusturma.Text = "Görev Oluşturma Paneli";
            // 
            // txtGorevNotu
            // 
            this.txtGorevNotu.Location = new System.Drawing.Point(88, 64);
            this.txtGorevNotu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGorevNotu.Multiline = true;
            this.txtGorevNotu.Name = "txtGorevNotu";
            this.txtGorevNotu.Size = new System.Drawing.Size(221, 242);
            this.txtGorevNotu.TabIndex = 3;
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(88, 28);
            this.txtGorev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(221, 23);
            this.txtGorev.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Görev Notu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Görev:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(674, 400);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(313, 22);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGoreviSil
            // 
            this.btnGoreviSil.Location = new System.Drawing.Point(674, 426);
            this.btnGoreviSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoreviSil.Name = "btnGoreviSil";
            this.btnGoreviSil.Size = new System.Drawing.Size(313, 22);
            this.btnGoreviSil.TabIndex = 9;
            this.btnGoreviSil.Text = "Görevi Sil";
            this.btnGoreviSil.UseVisualStyleBackColor = true;
            this.btnGoreviSil.Click += new System.EventHandler(this.btnGoreviSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alt Görevler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 680);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGoreviSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gbGorevOlusturma);
            this.Controls.Add(this.gbAnaGorevArama);
            this.Controls.Add(this.gbAnaGorevListeleme);
            this.Controls.Add(this.btnTumListeyiGetir);
            this.Controls.Add(this.btnTamamlanmamisGorevler);
            this.Controls.Add(this.btnTamamlanmisGorevler);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = ",0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbAnaGorevListeleme.ResumeLayout(false);
            this.gbAnaGorevArama.ResumeLayout(false);
            this.gbAnaGorevArama.PerformLayout();
            this.gbGorevOlusturma.ResumeLayout(false);
            this.gbGorevOlusturma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnTamamlanmisGorevler;
        private System.Windows.Forms.Button btnTamamlanmamisGorevler;
        private System.Windows.Forms.Button btnTumListeyiGetir;
        private System.Windows.Forms.GroupBox gbAnaGorevListeleme;
        private System.Windows.Forms.Button btnSecilenYilaGoreAra;
        private System.Windows.Forms.Button btnAnaGorevAra;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.GroupBox gbAnaGorevArama;
        private System.Windows.Forms.TextBox txtIsimVeyaAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbGorevOlusturma;
        private System.Windows.Forms.TextBox txtGorevNotu;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGoreviSil;
        private System.Windows.Forms.Label label4;
    }
}

