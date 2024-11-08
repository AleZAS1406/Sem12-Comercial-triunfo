namespace Comercial_El_triunfo_Bonificaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LBL0 = new System.Windows.Forms.Label();
            this.LBL1 = new System.Windows.Forms.Label();
            this.TXT1 = new System.Windows.Forms.TextBox();
            this.LBL2 = new System.Windows.Forms.Label();
            this.TXT2 = new System.Windows.Forms.TextBox();
            this.LBL3 = new System.Windows.Forms.Label();
            this.RDBTN1 = new System.Windows.Forms.RadioButton();
            this.RDBTN2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RDBTN3 = new System.Windows.Forms.RadioButton();
            this.LBL4 = new System.Windows.Forms.Label();
            this.TXT3 = new System.Windows.Forms.TextBox();
            this.LBL5 = new System.Windows.Forms.Label();
            this.TXT4 = new System.Windows.Forms.TextBox();
            this.LBL6 = new System.Windows.Forms.Label();
            this.TXT5 = new System.Windows.Forms.TextBox();
            this.LBL7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN3 = new System.Windows.Forms.Button();
            this.BTN2 = new System.Windows.Forms.Button();
            this.BTN1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL0
            // 
            this.LBL0.AutoSize = true;
            this.LBL0.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL0.Location = new System.Drawing.Point(165, 9);
            this.LBL0.Name = "LBL0";
            this.LBL0.Size = new System.Drawing.Size(307, 31);
            this.LBL0.TabIndex = 0;
            this.LBL0.Text = "Cálculo de Bonificaciones";
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL1.Location = new System.Drawing.Point(32, 81);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(206, 24);
            this.LBL1.TabIndex = 1;
            this.LBL1.Text = "Nombre del Empleado:";
            this.LBL1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXT1
            // 
            this.TXT1.Location = new System.Drawing.Point(244, 81);
            this.TXT1.Name = "TXT1";
            this.TXT1.Size = new System.Drawing.Size(175, 22);
            this.TXT1.TabIndex = 2;
            // 
            // LBL2
            // 
            this.LBL2.AutoSize = true;
            this.LBL2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL2.Location = new System.Drawing.Point(67, 130);
            this.LBL2.Name = "LBL2";
            this.LBL2.Size = new System.Drawing.Size(133, 24);
            this.LBL2.TabIndex = 3;
            this.LBL2.Text = "Sueldo Básico:";
            // 
            // TXT2
            // 
            this.TXT2.Location = new System.Drawing.Point(244, 132);
            this.TXT2.Name = "TXT2";
            this.TXT2.Size = new System.Drawing.Size(175, 22);
            this.TXT2.TabIndex = 4;
            // 
            // LBL3
            // 
            this.LBL3.AutoSize = true;
            this.LBL3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL3.Location = new System.Drawing.Point(3, 0);
            this.LBL3.Name = "LBL3";
            this.LBL3.Size = new System.Drawing.Size(116, 24);
            this.LBL3.TabIndex = 5;
            this.LBL3.Text = "Bonificación";
            // 
            // RDBTN1
            // 
            this.RDBTN1.AutoSize = true;
            this.RDBTN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBTN1.Location = new System.Drawing.Point(14, 27);
            this.RDBTN1.Name = "RDBTN1";
            this.RDBTN1.Size = new System.Drawing.Size(58, 22);
            this.RDBTN1.TabIndex = 6;
            this.RDBTN1.TabStop = true;
            this.RDBTN1.Text = "10%";
            this.RDBTN1.UseVisualStyleBackColor = true;
            this.RDBTN1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RDBTN2
            // 
            this.RDBTN2.AutoSize = true;
            this.RDBTN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBTN2.Location = new System.Drawing.Point(14, 69);
            this.RDBTN2.Name = "RDBTN2";
            this.RDBTN2.Size = new System.Drawing.Size(62, 22);
            this.RDBTN2.TabIndex = 7;
            this.RDBTN2.TabStop = true;
            this.RDBTN2.Text = "20% ";
            this.RDBTN2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RDBTN3);
            this.panel1.Controls.Add(this.LBL3);
            this.panel1.Controls.Add(this.RDBTN2);
            this.panel1.Controls.Add(this.RDBTN1);
            this.panel1.Location = new System.Drawing.Point(60, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 146);
            this.panel1.TabIndex = 8;
            // 
            // RDBTN3
            // 
            this.RDBTN3.AutoSize = true;
            this.RDBTN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBTN3.Location = new System.Drawing.Point(14, 108);
            this.RDBTN3.Name = "RDBTN3";
            this.RDBTN3.Size = new System.Drawing.Size(58, 22);
            this.RDBTN3.TabIndex = 8;
            this.RDBTN3.TabStop = true;
            this.RDBTN3.Text = "35%";
            this.RDBTN3.UseVisualStyleBackColor = true;
            // 
            // LBL4
            // 
            this.LBL4.AutoSize = true;
            this.LBL4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL4.Location = new System.Drawing.Point(41, 335);
            this.LBL4.Name = "LBL4";
            this.LBL4.Size = new System.Drawing.Size(121, 24);
            this.LBL4.TabIndex = 9;
            this.LBL4.Text = "Bonificación:";
            // 
            // TXT3
            // 
            this.TXT3.Location = new System.Drawing.Point(185, 335);
            this.TXT3.Name = "TXT3";
            this.TXT3.Size = new System.Drawing.Size(144, 22);
            this.TXT3.TabIndex = 10;
            // 
            // LBL5
            // 
            this.LBL5.AutoSize = true;
            this.LBL5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL5.Location = new System.Drawing.Point(32, 387);
            this.LBL5.Name = "LBL5";
            this.LBL5.Size = new System.Drawing.Size(132, 24);
            this.LBL5.TabIndex = 11;
            this.LBL5.Text = "Retención 5%:";
            // 
            // TXT4
            // 
            this.TXT4.Location = new System.Drawing.Point(185, 387);
            this.TXT4.Name = "TXT4";
            this.TXT4.Size = new System.Drawing.Size(144, 22);
            this.TXT4.TabIndex = 12;
            // 
            // LBL6
            // 
            this.LBL6.AutoSize = true;
            this.LBL6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL6.Location = new System.Drawing.Point(30, 440);
            this.LBL6.Name = "LBL6";
            this.LBL6.Size = new System.Drawing.Size(187, 31);
            this.LBL6.TabIndex = 13;
            this.LBL6.Text = "Total a Recibir:";
            // 
            // TXT5
            // 
            this.TXT5.Location = new System.Drawing.Point(223, 446);
            this.TXT5.Name = "TXT5";
            this.TXT5.Size = new System.Drawing.Size(135, 22);
            this.TXT5.TabIndex = 14;
            // 
            // LBL7
            // 
            this.LBL7.AutoSize = true;
            this.LBL7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL7.Location = new System.Drawing.Point(21, 0);
            this.LBL7.Name = "LBL7";
            this.LBL7.Size = new System.Drawing.Size(86, 24);
            this.LBL7.TabIndex = 15;
            this.LBL7.Text = "Acciones";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTN3);
            this.panel2.Controls.Add(this.BTN2);
            this.panel2.Controls.Add(this.BTN1);
            this.panel2.Controls.Add(this.LBL7);
            this.panel2.Location = new System.Drawing.Point(459, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 166);
            this.panel2.TabIndex = 16;
            // 
            // BTN3
            // 
            this.BTN3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3.Location = new System.Drawing.Point(25, 117);
            this.BTN3.Name = "BTN3";
            this.BTN3.Size = new System.Drawing.Size(82, 29);
            this.BTN3.TabIndex = 18;
            this.BTN3.Text = "Salir";
            this.BTN3.UseVisualStyleBackColor = true;
            // 
            // BTN2
            // 
            this.BTN2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2.Location = new System.Drawing.Point(25, 70);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(82, 29);
            this.BTN2.TabIndex = 17;
            this.BTN2.Text = "Limpiar";
            this.BTN2.UseVisualStyleBackColor = true;
            this.BTN2.Click += new System.EventHandler(this.BTN2_Click);
            // 
            // BTN1
            // 
            this.BTN1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN1.Location = new System.Drawing.Point(25, 27);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(82, 29);
            this.BTN1.TabIndex = 16;
            this.BTN1.Text = "Calcular";
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(657, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TXT5);
            this.Controls.Add(this.LBL6);
            this.Controls.Add(this.TXT4);
            this.Controls.Add(this.LBL5);
            this.Controls.Add(this.TXT3);
            this.Controls.Add(this.LBL4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TXT2);
            this.Controls.Add(this.LBL2);
            this.Controls.Add(this.TXT1);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.LBL0);
            this.Name = "Form1";
            this.Text = "Comercial El Triunfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL0;
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.TextBox TXT1;
        private System.Windows.Forms.Label LBL2;
        private System.Windows.Forms.TextBox TXT2;
        private System.Windows.Forms.Label LBL3;
        private System.Windows.Forms.RadioButton RDBTN1;
        private System.Windows.Forms.RadioButton RDBTN2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RDBTN3;
        private System.Windows.Forms.Label LBL4;
        private System.Windows.Forms.TextBox TXT3;
        private System.Windows.Forms.Label LBL5;
        private System.Windows.Forms.TextBox TXT4;
        private System.Windows.Forms.Label LBL6;
        private System.Windows.Forms.TextBox TXT5;
        private System.Windows.Forms.Label LBL7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.Button BTN3;
        private System.Windows.Forms.Button BTN2;
    }
}

