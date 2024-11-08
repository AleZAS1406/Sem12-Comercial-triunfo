namespace Comercial_el_Triunfo
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblcodigop = new System.Windows.Forms.Label();
            this.TxtCodProd = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.Txtname = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.GrupoDescuento = new System.Windows.Forms.GroupBox();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn5 = new System.Windows.Forms.RadioButton();
            this.rbtn10 = new System.Windows.Forms.RadioButton();
            this.rbtn15 = new System.Windows.Forms.RadioButton();
            this.rbtncero = new System.Windows.Forms.RadioButton();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.TxtSubtotaal = new System.Windows.Forms.TextBox();
            this.lbldescuento = new System.Windows.Forms.Label();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.lbliva = new System.Windows.Forms.Label();
            this.TxtIVA = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TxtTotañ = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.GrupoDescuento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(138, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Comercial el Triunfo";
            // 
            // lblcodigop
            // 
            this.lblcodigop.AutoSize = true;
            this.lblcodigop.Location = new System.Drawing.Point(34, 55);
            this.lblcodigop.Name = "lblcodigop";
            this.lblcodigop.Size = new System.Drawing.Size(104, 13);
            this.lblcodigop.TabIndex = 1;
            this.lblcodigop.Text = "Codigo de Producto:";
            // 
            // TxtCodProd
            // 
            this.TxtCodProd.Location = new System.Drawing.Point(151, 52);
            this.TxtCodProd.Name = "TxtCodProd";
            this.TxtCodProd.Size = new System.Drawing.Size(100, 20);
            this.TxtCodProd.TabIndex = 2;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(22, 90);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(116, 13);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Nombre de el Producto";
            // 
            // Txtname
            // 
            this.Txtname.Location = new System.Drawing.Point(151, 90);
            this.Txtname.Name = "Txtname";
            this.Txtname.Size = new System.Drawing.Size(100, 20);
            this.Txtname.TabIndex = 4;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(98, 133);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(40, 13);
            this.lblprecio.TabIndex = 5;
            this.lblprecio.Text = "Precio:";
            this.lblprecio.Click += new System.EventHandler(this.lblprecio_Click);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(151, 133);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecio.TabIndex = 6;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(98, 171);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(55, 13);
            this.lblcantidad.TabIndex = 7;
            this.lblcantidad.Text = "Cantidad :";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(151, 168);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(248, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 39);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GrupoDescuento
            // 
            this.GrupoDescuento.Controls.Add(this.rbtncero);
            this.GrupoDescuento.Controls.Add(this.rbtn15);
            this.GrupoDescuento.Controls.Add(this.rbtn10);
            this.GrupoDescuento.Controls.Add(this.rbtn5);
            this.GrupoDescuento.Controls.Add(this.rbtn1);
            this.GrupoDescuento.Location = new System.Drawing.Point(336, 52);
            this.GrupoDescuento.Name = "GrupoDescuento";
            this.GrupoDescuento.Size = new System.Drawing.Size(107, 149);
            this.GrupoDescuento.TabIndex = 10;
            this.GrupoDescuento.TabStop = false;
            this.GrupoDescuento.Text = "Descuento";
            this.GrupoDescuento.Enter += new System.EventHandler(this.GrupoDescuento_Enter);
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(19, 47);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(39, 17);
            this.rbtn1.TabIndex = 11;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "1%";
            this.rbtn1.UseVisualStyleBackColor = true;
            // 
            // rbtn5
            // 
            this.rbtn5.AutoSize = true;
            this.rbtn5.Location = new System.Drawing.Point(19, 70);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(39, 17);
            this.rbtn5.TabIndex = 11;
            this.rbtn5.TabStop = true;
            this.rbtn5.Text = "5%";
            this.rbtn5.UseVisualStyleBackColor = true;
            // 
            // rbtn10
            // 
            this.rbtn10.AutoSize = true;
            this.rbtn10.Location = new System.Drawing.Point(19, 93);
            this.rbtn10.Name = "rbtn10";
            this.rbtn10.Size = new System.Drawing.Size(45, 17);
            this.rbtn10.TabIndex = 12;
            this.rbtn10.TabStop = true;
            this.rbtn10.Text = "10%";
            this.rbtn10.UseVisualStyleBackColor = true;
            // 
            // rbtn15
            // 
            this.rbtn15.AutoSize = true;
            this.rbtn15.Location = new System.Drawing.Point(19, 116);
            this.rbtn15.Name = "rbtn15";
            this.rbtn15.Size = new System.Drawing.Size(45, 17);
            this.rbtn15.TabIndex = 13;
            this.rbtn15.TabStop = true;
            this.rbtn15.Text = "15%";
            this.rbtn15.UseVisualStyleBackColor = true;
            // 
            // rbtncero
            // 
            this.rbtncero.AutoSize = true;
            this.rbtncero.Location = new System.Drawing.Point(19, 19);
            this.rbtncero.Name = "rbtncero";
            this.rbtncero.Size = new System.Drawing.Size(39, 17);
            this.rbtncero.TabIndex = 14;
            this.rbtncero.TabStop = true;
            this.rbtncero.Text = "0%";
            this.rbtncero.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(89, 203);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(109, 34);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(34, 269);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // TxtSubtotaal
            // 
            this.TxtSubtotaal.Enabled = false;
            this.TxtSubtotaal.Location = new System.Drawing.Point(89, 266);
            this.TxtSubtotaal.Name = "TxtSubtotaal";
            this.TxtSubtotaal.Size = new System.Drawing.Size(100, 20);
            this.TxtSubtotaal.TabIndex = 13;
            this.TxtSubtotaal.TextChanged += new System.EventHandler(this.TxtSubtotaal_TextChanged);
            // 
            // lbldescuento
            // 
            this.lbldescuento.AutoSize = true;
            this.lbldescuento.Location = new System.Drawing.Point(22, 303);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(62, 13);
            this.lbldescuento.TabIndex = 14;
            this.lbldescuento.Text = "Descuento:";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Enabled = false;
            this.TxtDescuento.Location = new System.Drawing.Point(89, 300);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(100, 20);
            this.TxtDescuento.TabIndex = 15;
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Location = new System.Drawing.Point(46, 334);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(27, 13);
            this.lbliva.TabIndex = 16;
            this.lbliva.Text = "IVA:";
            // 
            // TxtIVA
            // 
            this.TxtIVA.Enabled = false;
            this.TxtIVA.Location = new System.Drawing.Point(89, 331);
            this.TxtIVA.Name = "TxtIVA";
            this.TxtIVA.Size = new System.Drawing.Size(100, 20);
            this.TxtIVA.TabIndex = 17;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(46, 368);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total:";
            // 
            // TxtTotañ
            // 
            this.TxtTotañ.Enabled = false;
            this.TxtTotañ.Location = new System.Drawing.Point(89, 368);
            this.TxtTotañ.Name = "TxtTotañ";
            this.TxtTotañ.Size = new System.Drawing.Size(100, 20);
            this.TxtTotañ.TabIndex = 19;
            this.TxtTotañ.TextChanged += new System.EventHandler(this.TxtTotañ_TextChanged);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(248, 300);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(106, 39);
            this.btnlimpiar.TabIndex = 20;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(248, 247);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(106, 39);
            this.btncalcular.TabIndex = 21;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 413);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.TxtTotañ);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.TxtIVA);
            this.Controls.Add(this.lbliva);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.lbldescuento);
            this.Controls.Add(this.TxtSubtotaal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.GrupoDescuento);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.Txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.TxtCodProd);
            this.Controls.Add(this.lblcodigop);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Comercial El Triunfo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrupoDescuento.ResumeLayout(false);
            this.GrupoDescuento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblcodigop;
        private System.Windows.Forms.TextBox TxtCodProd;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox Txtname;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox GrupoDescuento;
        private System.Windows.Forms.RadioButton rbtncero;
        private System.Windows.Forms.RadioButton rbtn15;
        private System.Windows.Forms.RadioButton rbtn10;
        private System.Windows.Forms.RadioButton rbtn5;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox TxtSubtotaal;
        private System.Windows.Forms.Label lbldescuento;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.TextBox TxtIVA;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox TxtTotañ;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncalcular;
    }
}

