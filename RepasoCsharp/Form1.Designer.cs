namespace RepasoCsharp
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lbPantalla = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.btnPosicion = new System.Windows.Forms.Button();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.btnMedia = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.txtContar = new System.Windows.Forms.TextBox();
            this.lblContar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.MaskedTextBox();
            this.lblPos = new System.Windows.Forms.Label();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.btnContar25 = new System.Windows.Forms.Button();
            this.btnContarX = new System.Windows.Forms.Button();
            this.tbContarX = new System.Windows.Forms.TextBox();
            this.lblContar25 = new System.Windows.Forms.Label();
            this.lblContarX = new System.Windows.Forms.Label();
            this.btnArray2 = new System.Windows.Forms.Button();
            this.btnArray3 = new System.Windows.Forms.Button();
            this.btn3Array = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.Maroon;
            this.btnGenerar.Location = new System.Drawing.Point(12, 15);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(133, 30);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Vector";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lbPantalla
            // 
            this.lbPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPantalla.ForeColor = System.Drawing.Color.Maroon;
            this.lbPantalla.FormattingEnabled = true;
            this.lbPantalla.ItemHeight = 24;
            this.lbPantalla.Location = new System.Drawing.Point(12, 59);
            this.lbPantalla.Name = "lbPantalla";
            this.lbPantalla.Size = new System.Drawing.Size(417, 196);
            this.lbPantalla.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Maroon;
            this.btnBuscar.Location = new System.Drawing.Point(12, 310);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(151, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Mayor y Menor";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Enabled = false;
            this.lblMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor.ForeColor = System.Drawing.Color.White;
            this.lblMayor.Location = new System.Drawing.Point(191, 312);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(60, 24);
            this.lblMayor.TabIndex = 3;
            this.lblMayor.Text = "label1";
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Enabled = false;
            this.lblMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.ForeColor = System.Drawing.Color.White;
            this.lblMenor.Location = new System.Drawing.Point(291, 312);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(60, 24);
            this.lblMenor.TabIndex = 4;
            this.lblMenor.Text = "label2";
            // 
            // btnPosicion
            // 
            this.btnPosicion.Enabled = false;
            this.btnPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosicion.ForeColor = System.Drawing.Color.Maroon;
            this.btnPosicion.Location = new System.Drawing.Point(12, 398);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(151, 28);
            this.btnPosicion.TabIndex = 5;
            this.btnPosicion.Text = "Buscar por Posicion";
            this.btnPosicion.UseVisualStyleBackColor = true;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // txtPosicion
            // 
            this.txtPosicion.Enabled = false;
            this.txtPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicion.ForeColor = System.Drawing.Color.Maroon;
            this.txtPosicion.Location = new System.Drawing.Point(195, 398);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(46, 29);
            this.txtPosicion.TabIndex = 6;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Enabled = false;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.ForeColor = System.Drawing.Color.White;
            this.lblPosicion.Location = new System.Drawing.Point(247, 403);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(60, 24);
            this.lblPosicion.TabIndex = 7;
            this.lblPosicion.Text = "label1";
            // 
            // btnMedia
            // 
            this.btnMedia.Enabled = false;
            this.btnMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.ForeColor = System.Drawing.Color.Maroon;
            this.btnMedia.Location = new System.Drawing.Point(12, 355);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(151, 28);
            this.btnMedia.TabIndex = 8;
            this.btnMedia.Text = "Media Vector";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Enabled = false;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.ForeColor = System.Drawing.Color.White;
            this.lblMedia.Location = new System.Drawing.Point(191, 359);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(60, 24);
            this.lblMedia.TabIndex = 9;
            this.lblMedia.Text = "label1";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Enabled = false;
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.Maroon;
            this.btnOrdenar.Location = new System.Drawing.Point(295, 15);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(134, 30);
            this.btnOrdenar.TabIndex = 10;
            this.btnOrdenar.Text = "Ordenar Vector";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnContar
            // 
            this.btnContar.Enabled = false;
            this.btnContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.ForeColor = System.Drawing.Color.Maroon;
            this.btnContar.Location = new System.Drawing.Point(12, 444);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(151, 28);
            this.btnContar.TabIndex = 11;
            this.btnContar.Text = "Contar Numero";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // txtContar
            // 
            this.txtContar.Enabled = false;
            this.txtContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContar.ForeColor = System.Drawing.Color.Maroon;
            this.txtContar.Location = new System.Drawing.Point(195, 442);
            this.txtContar.Name = "txtContar";
            this.txtContar.Size = new System.Drawing.Size(46, 29);
            this.txtContar.TabIndex = 12;
            // 
            // lblContar
            // 
            this.lblContar.AutoSize = true;
            this.lblContar.Enabled = false;
            this.lblContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContar.ForeColor = System.Drawing.Color.White;
            this.lblContar.Location = new System.Drawing.Point(247, 448);
            this.lblContar.Name = "lblContar";
            this.lblContar.Size = new System.Drawing.Size(60, 24);
            this.lblContar.TabIndex = 13;
            this.lblContar.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(435, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Criterio de ordenación";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Enabled = false;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.ForeColor = System.Drawing.Color.White;
            this.rb1.Location = new System.Drawing.Point(448, 59);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(155, 28);
            this.rb1.TabIndex = 15;
            this.rb1.TabStop = true;
            this.rb1.Text = "Menor a mayor";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Enabled = false;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.ForeColor = System.Drawing.Color.White;
            this.rb2.Location = new System.Drawing.Point(448, 92);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(155, 28);
            this.rb2.TabIndex = 16;
            this.rb2.Text = "Mayor a menor";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Location = new System.Drawing.Point(744, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 116);
            this.label2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSalmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(755, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSalmon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(756, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "NIF:";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.ForeColor = System.Drawing.Color.White;
            this.lblNIF.Location = new System.Drawing.Point(807, 175);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(0, 24);
            this.lblNIF.TabIndex = 20;
            // 
            // btnConvertir
            // 
            this.btnConvertir.ForeColor = System.Drawing.Color.Maroon;
            this.btnConvertir.Location = new System.Drawing.Point(807, 142);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 22;
            this.btnConvertir.Text = "convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click_1);
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.Color.Maroon;
            this.txtDNI.Location = new System.Drawing.Point(807, 109);
            this.txtDNI.Mask = "00000000";
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 29);
            this.txtDNI.TabIndex = 23;
            this.txtDNI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDNI_MaskInputRejected);
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Enabled = false;
            this.lblPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(13, 273);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(60, 24);
            this.lblPos.TabIndex = 24;
            this.lblPos.Text = "label5";
            // 
            // btnInvertir
            // 
            this.btnInvertir.Enabled = false;
            this.btnInvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvertir.ForeColor = System.Drawing.Color.Maroon;
            this.btnInvertir.Location = new System.Drawing.Point(448, 137);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(155, 28);
            this.btnInvertir.TabIndex = 25;
            this.btnInvertir.Text = "Invertir Vector";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnRepetidos_Click);
            // 
            // btnContar25
            // 
            this.btnContar25.Enabled = false;
            this.btnContar25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar25.ForeColor = System.Drawing.Color.Maroon;
            this.btnContar25.Location = new System.Drawing.Point(12, 488);
            this.btnContar25.Name = "btnContar25";
            this.btnContar25.Size = new System.Drawing.Size(151, 28);
            this.btnContar25.TabIndex = 27;
            this.btnContar25.Text = "Contar sobre 25";
            this.btnContar25.UseVisualStyleBackColor = true;
            this.btnContar25.Click += new System.EventHandler(this.btnContar25_Click);
            // 
            // btnContarX
            // 
            this.btnContarX.Enabled = false;
            this.btnContarX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContarX.ForeColor = System.Drawing.Color.Maroon;
            this.btnContarX.Location = new System.Drawing.Point(12, 533);
            this.btnContarX.Name = "btnContarX";
            this.btnContarX.Size = new System.Drawing.Size(151, 28);
            this.btnContarX.TabIndex = 28;
            this.btnContarX.Text = "Contar sobre X";
            this.btnContarX.UseVisualStyleBackColor = true;
            this.btnContarX.Click += new System.EventHandler(this.btnContarX_Click);
            // 
            // tbContarX
            // 
            this.tbContarX.Enabled = false;
            this.tbContarX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContarX.ForeColor = System.Drawing.Color.Maroon;
            this.tbContarX.Location = new System.Drawing.Point(195, 533);
            this.tbContarX.Name = "tbContarX";
            this.tbContarX.Size = new System.Drawing.Size(46, 29);
            this.tbContarX.TabIndex = 29;
            // 
            // lblContar25
            // 
            this.lblContar25.AutoSize = true;
            this.lblContar25.Enabled = false;
            this.lblContar25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContar25.Location = new System.Drawing.Point(191, 489);
            this.lblContar25.Name = "lblContar25";
            this.lblContar25.Size = new System.Drawing.Size(60, 24);
            this.lblContar25.TabIndex = 30;
            this.lblContar25.Text = "label5";
            // 
            // lblContarX
            // 
            this.lblContarX.AutoSize = true;
            this.lblContarX.Enabled = false;
            this.lblContarX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContarX.Location = new System.Drawing.Point(250, 542);
            this.lblContarX.Name = "lblContarX";
            this.lblContarX.Size = new System.Drawing.Size(60, 24);
            this.lblContarX.TabIndex = 31;
            this.lblContarX.Text = "label6";
            // 
            // btnArray2
            // 
            this.btnArray2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArray2.ForeColor = System.Drawing.Color.Maroon;
            this.btnArray2.Location = new System.Drawing.Point(586, 322);
            this.btnArray2.Name = "btnArray2";
            this.btnArray2.Size = new System.Drawing.Size(147, 33);
            this.btnArray2.TabIndex = 32;
            this.btnArray2.Text = "Array -100,+200";
            this.btnArray2.UseVisualStyleBackColor = true;
            this.btnArray2.Click += new System.EventHandler(this.btnArray2_Click);
            // 
            // btnArray3
            // 
            this.btnArray3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArray3.ForeColor = System.Drawing.Color.Maroon;
            this.btnArray3.Location = new System.Drawing.Point(586, 403);
            this.btnArray3.Name = "btnArray3";
            this.btnArray3.Size = new System.Drawing.Size(147, 33);
            this.btnArray3.TabIndex = 33;
            this.btnArray3.Text = "50 numeros";
            this.btnArray3.UseVisualStyleBackColor = true;
            this.btnArray3.Click += new System.EventHandler(this.btnArray3_Click);
            // 
            // btn3Array
            // 
            this.btn3Array.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Array.ForeColor = System.Drawing.Color.Maroon;
            this.btn3Array.Location = new System.Drawing.Point(586, 487);
            this.btn3Array.Name = "btn3Array";
            this.btn3Array.Size = new System.Drawing.Size(147, 33);
            this.btn3Array.TabIndex = 34;
            this.btn3Array.Text = "3 Arrays";
            this.btn3Array.UseVisualStyleBackColor = true;
            this.btn3Array.Click += new System.EventHandler(this.btn3Array_Click);
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.Maroon;
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 24;
            this.lb2.Location = new System.Drawing.Point(747, 322);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(268, 244);
            this.lb2.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1063, 658);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btn3Array);
            this.Controls.Add(this.btnArray3);
            this.Controls.Add(this.btnArray2);
            this.Controls.Add(this.lblContarX);
            this.Controls.Add(this.lblContar25);
            this.Controls.Add(this.tbContarX);
            this.Controls.Add(this.btnContarX);
            this.Controls.Add(this.btnContar25);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContar);
            this.Controls.Add(this.txtContar);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbPantalla);
            this.Controls.Add(this.btnGenerar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListBox lbPantalla;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox txtContar;
        private System.Windows.Forms.Label lblContar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.MaskedTextBox txtDNI;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Button btnContar25;
        private System.Windows.Forms.Button btnContarX;
        private System.Windows.Forms.TextBox tbContarX;
        private System.Windows.Forms.Label lblContar25;
        private System.Windows.Forms.Label lblContarX;
        private System.Windows.Forms.Button btnArray2;
        private System.Windows.Forms.Button btnArray3;
        private System.Windows.Forms.Button btn3Array;
        private System.Windows.Forms.ListBox lb2;
    }
}

