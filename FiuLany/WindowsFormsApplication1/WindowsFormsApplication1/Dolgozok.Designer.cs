namespace WindowsFormsApplication1
{
    partial class Dolgozok
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
            this.lany = new System.Windows.Forms.ComboBox();
            this.fiu = new System.Windows.Forms.ComboBox();
            this.lany1 = new System.Windows.Forms.Label();
            this.fiu1 = new System.Windows.Forms.Label();
            this.ossz = new System.Windows.Forms.GroupBox();
            this.adat = new System.Windows.Forms.GroupBox();
            this.osszlany = new System.Windows.Forms.RadioButton();
            this.osszfiu = new System.Windows.Forms.RadioButton();
            this.oidos = new System.Windows.Forms.Label();
            this.okor = new System.Windows.Forms.Label();
            this.ohateve = new System.Windows.Forms.Label();
            this.osszlegidos = new System.Windows.Forms.TextBox();
            this.osszkor = new System.Windows.Forms.TextBox();
            this.osszhateve = new System.Windows.Forms.TextBox();
            this.akor = new System.Windows.Forms.Label();
            this.amiota = new System.Windows.Forms.Label();
            this.adatkor = new System.Windows.Forms.TextBox();
            this.adatmiota = new System.Windows.Forms.TextBox();
            this.mind = new System.Windows.Forms.CheckBox();
            this.ment = new System.Windows.Forms.Button();
            this.ossz.SuspendLayout();
            this.adat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lany
            // 
            this.lany.FormattingEnabled = true;
            this.lany.Location = new System.Drawing.Point(63, 24);
            this.lany.Name = "lany";
            this.lany.Size = new System.Drawing.Size(141, 21);
            this.lany.TabIndex = 0;
            this.lany.SelectedIndexChanged += new System.EventHandler(this.lany_SelectedIndexChanged);
            // 
            // fiu
            // 
            this.fiu.FormattingEnabled = true;
            this.fiu.Location = new System.Drawing.Point(302, 24);
            this.fiu.Name = "fiu";
            this.fiu.Size = new System.Drawing.Size(136, 21);
            this.fiu.TabIndex = 1;
            this.fiu.SelectedIndexChanged += new System.EventHandler(this.fiu_SelectedIndexChanged);
            // 
            // lany1
            // 
            this.lany1.AutoSize = true;
            this.lany1.Location = new System.Drawing.Point(12, 32);
            this.lany1.Name = "lany1";
            this.lany1.Size = new System.Drawing.Size(45, 13);
            this.lany1.TabIndex = 2;
            this.lany1.Text = "Lányok:";
            // 
            // fiu1
            // 
            this.fiu1.AutoSize = true;
            this.fiu1.Location = new System.Drawing.Point(266, 32);
            this.fiu1.Name = "fiu1";
            this.fiu1.Size = new System.Drawing.Size(30, 13);
            this.fiu1.TabIndex = 3;
            this.fiu1.Text = "Fiúk:";
            // 
            // ossz
            // 
            this.ossz.Controls.Add(this.osszhateve);
            this.ossz.Controls.Add(this.osszkor);
            this.ossz.Controls.Add(this.osszlegidos);
            this.ossz.Controls.Add(this.ohateve);
            this.ossz.Controls.Add(this.okor);
            this.ossz.Controls.Add(this.oidos);
            this.ossz.Controls.Add(this.osszfiu);
            this.ossz.Controls.Add(this.osszlany);
            this.ossz.Location = new System.Drawing.Point(15, 94);
            this.ossz.Name = "ossz";
            this.ossz.Size = new System.Drawing.Size(238, 175);
            this.ossz.TabIndex = 4;
            this.ossz.TabStop = false;
            this.ossz.Text = "Összesítő";
            // 
            // adat
            // 
            this.adat.Controls.Add(this.adatmiota);
            this.adat.Controls.Add(this.adatkor);
            this.adat.Controls.Add(this.amiota);
            this.adat.Controls.Add(this.akor);
            this.adat.Location = new System.Drawing.Point(269, 94);
            this.adat.Name = "adat";
            this.adat.Size = new System.Drawing.Size(200, 108);
            this.adat.TabIndex = 5;
            this.adat.TabStop = false;
            this.adat.Text = "Adatok";
            // 
            // osszlany
            // 
            this.osszlany.AutoSize = true;
            this.osszlany.Location = new System.Drawing.Point(22, 20);
            this.osszlany.Name = "osszlany";
            this.osszlany.Size = new System.Drawing.Size(44, 17);
            this.osszlany.TabIndex = 0;
            this.osszlany.TabStop = true;
            this.osszlany.Text = "lány";
            this.osszlany.UseVisualStyleBackColor = true;
            this.osszlany.CheckedChanged += new System.EventHandler(this.osszlany_CheckedChanged);
            // 
            // osszfiu
            // 
            this.osszfiu.AutoSize = true;
            this.osszfiu.Location = new System.Drawing.Point(130, 20);
            this.osszfiu.Name = "osszfiu";
            this.osszfiu.Size = new System.Drawing.Size(36, 17);
            this.osszfiu.TabIndex = 1;
            this.osszfiu.TabStop = true;
            this.osszfiu.Text = "fiú";
            this.osszfiu.UseVisualStyleBackColor = true;
            this.osszfiu.CheckedChanged += new System.EventHandler(this.osszfiu_CheckedChanged);
            // 
            // oidos
            // 
            this.oidos.AutoSize = true;
            this.oidos.Location = new System.Drawing.Point(19, 61);
            this.oidos.Name = "oidos";
            this.oidos.Size = new System.Drawing.Size(58, 13);
            this.oidos.TabIndex = 2;
            this.oidos.Text = "legidősebb";
            // 
            // okor
            // 
            this.okor.AutoSize = true;
            this.okor.Location = new System.Drawing.Point(19, 105);
            this.okor.Name = "okor";
            this.okor.Size = new System.Drawing.Size(57, 13);
            this.okor.TabIndex = 3;
            this.okor.Text = "összes kor";
            // 
            // ohateve
            // 
            this.ohateve.AutoSize = true;
            this.ohateve.Location = new System.Drawing.Point(19, 144);
            this.ohateve.Name = "ohateve";
            this.ohateve.Size = new System.Drawing.Size(74, 13);
            this.ohateve.TabIndex = 4;
            this.ohateve.Text = "6 éve dolgozó";
            // 
            // osszlegidos
            // 
            this.osszlegidos.Location = new System.Drawing.Point(106, 54);
            this.osszlegidos.Name = "osszlegidos";
            this.osszlegidos.Size = new System.Drawing.Size(100, 20);
            this.osszlegidos.TabIndex = 5;
            // 
            // osszkor
            // 
            this.osszkor.Location = new System.Drawing.Point(106, 98);
            this.osszkor.Name = "osszkor";
            this.osszkor.Size = new System.Drawing.Size(100, 20);
            this.osszkor.TabIndex = 6;
            // 
            // osszhateve
            // 
            this.osszhateve.Location = new System.Drawing.Point(106, 137);
            this.osszhateve.Name = "osszhateve";
            this.osszhateve.Size = new System.Drawing.Size(100, 20);
            this.osszhateve.TabIndex = 7;
            // 
            // akor
            // 
            this.akor.AutoSize = true;
            this.akor.Location = new System.Drawing.Point(6, 43);
            this.akor.Name = "akor";
            this.akor.Size = new System.Drawing.Size(22, 13);
            this.akor.TabIndex = 0;
            this.akor.Text = "kor";
            // 
            // amiota
            // 
            this.amiota.AutoSize = true;
            this.amiota.Location = new System.Drawing.Point(4, 84);
            this.amiota.Name = "amiota";
            this.amiota.Size = new System.Drawing.Size(74, 13);
            this.amiota.TabIndex = 1;
            this.amiota.Text = "mióta dolgozik";
            // 
            // adatkor
            // 
            this.adatkor.Location = new System.Drawing.Point(84, 36);
            this.adatkor.Name = "adatkor";
            this.adatkor.Size = new System.Drawing.Size(100, 20);
            this.adatkor.TabIndex = 2;
            // 
            // adatmiota
            // 
            this.adatmiota.Location = new System.Drawing.Point(84, 77);
            this.adatmiota.Name = "adatmiota";
            this.adatmiota.Size = new System.Drawing.Size(100, 20);
            this.adatmiota.TabIndex = 3;
            // 
            // mind
            // 
            this.mind.AutoSize = true;
            this.mind.Location = new System.Drawing.Point(269, 208);
            this.mind.Name = "mind";
            this.mind.Size = new System.Drawing.Size(97, 17);
            this.mind.TabIndex = 6;
            this.mind.Text = "mindkettő elem";
            this.mind.UseVisualStyleBackColor = true;
            // 
            // ment
            // 
            this.ment.Location = new System.Drawing.Point(290, 246);
            this.ment.Name = "ment";
            this.ment.Size = new System.Drawing.Size(148, 23);
            this.ment.TabIndex = 7;
            this.ment.Text = "Mentés";
            this.ment.UseVisualStyleBackColor = true;
            this.ment.Click += new System.EventHandler(this.ment_Click);
            // 
            // Dolgozok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.ment);
            this.Controls.Add(this.mind);
            this.Controls.Add(this.adat);
            this.Controls.Add(this.ossz);
            this.Controls.Add(this.fiu1);
            this.Controls.Add(this.lany1);
            this.Controls.Add(this.fiu);
            this.Controls.Add(this.lany);
            this.Name = "Dolgozok";
            this.Text = "Dolgozók";
            this.ossz.ResumeLayout(false);
            this.ossz.PerformLayout();
            this.adat.ResumeLayout(false);
            this.adat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lany;
        private System.Windows.Forms.ComboBox fiu;
        private System.Windows.Forms.Label lany1;
        private System.Windows.Forms.Label fiu1;
        private System.Windows.Forms.GroupBox ossz;
        private System.Windows.Forms.TextBox osszhateve;
        private System.Windows.Forms.TextBox osszkor;
        private System.Windows.Forms.TextBox osszlegidos;
        private System.Windows.Forms.Label ohateve;
        private System.Windows.Forms.Label okor;
        private System.Windows.Forms.Label oidos;
        private System.Windows.Forms.RadioButton osszfiu;
        private System.Windows.Forms.RadioButton osszlany;
        private System.Windows.Forms.GroupBox adat;
        private System.Windows.Forms.TextBox adatmiota;
        private System.Windows.Forms.TextBox adatkor;
        private System.Windows.Forms.Label amiota;
        private System.Windows.Forms.Label akor;
        private System.Windows.Forms.CheckBox mind;
        private System.Windows.Forms.Button ment;
    }
}

