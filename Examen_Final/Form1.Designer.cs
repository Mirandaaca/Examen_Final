namespace Examen_Final
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblPila = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBase = new TextBox();
            txtAltura = new TextBox();
            txtNombre = new TextBox();
            btnAgregar = new Button();
            btnMostrarPila = new Button();
            tabPage2 = new TabPage();
            lblPilaRect = new Label();
            txtNombreRect = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBaseRect = new TextBox();
            txtAlturaRect = new TextBox();
            btnIngresarRect = new Button();
            btnMostrarPilaRect = new Button();
            tabPage3 = new TabPage();
            lblPilaParal = new Label();
            txtNombreParal = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtBaseParal = new TextBox();
            txtAlturaParal = new TextBox();
            btnIngresarParal = new Button();
            btnMostrarPilaParal = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1060, 568);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblPila);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtBase);
            tabPage1.Controls.Add(txtAltura);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(btnAgregar);
            tabPage1.Controls.Add(btnMostrarPila);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1052, 540);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Triangulo";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblPila
            // 
            lblPila.AutoSize = true;
            lblPila.Location = new Point(77, 198);
            lblPila.Name = "lblPila";
            lblPila.Size = new Size(38, 15);
            lblPila.TabIndex = 6;
            lblPila.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 103);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 62);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Altura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(53, 121);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(53, 77);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(53, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(172, 63);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 49);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Ingresar Atributos";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMostrarPila
            // 
            btnMostrarPila.Location = new Point(53, 150);
            btnMostrarPila.Name = "btnMostrarPila";
            btnMostrarPila.Size = new Size(100, 45);
            btnMostrarPila.TabIndex = 0;
            btnMostrarPila.Text = "Mostrar Pila";
            btnMostrarPila.UseVisualStyleBackColor = true;
            btnMostrarPila.Click += btnMostrarPila_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblPilaRect);
            tabPage2.Controls.Add(txtNombreRect);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtBaseRect);
            tabPage2.Controls.Add(txtAlturaRect);
            tabPage2.Controls.Add(btnIngresarRect);
            tabPage2.Controls.Add(btnMostrarPilaRect);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1052, 540);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Rectangulo";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPilaRect
            // 
            lblPilaRect.AutoSize = true;
            lblPilaRect.Location = new Point(67, 231);
            lblPilaRect.Name = "lblPilaRect";
            lblPilaRect.Size = new Size(38, 15);
            lblPilaRect.TabIndex = 15;
            lblPilaRect.Text = "label4";
            // 
            // txtNombreRect
            // 
            txtNombreRect.Location = new Point(43, 45);
            txtNombreRect.Name = "txtNombreRect";
            txtNombreRect.Size = new Size(100, 23);
            txtNombreRect.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 112);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 13;
            label4.Text = "Base";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 71);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 12;
            label5.Text = "Altura";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 27);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 11;
            label6.Text = "Nombre";
            // 
            // txtBaseRect
            // 
            txtBaseRect.Location = new Point(43, 130);
            txtBaseRect.Name = "txtBaseRect";
            txtBaseRect.Size = new Size(100, 23);
            txtBaseRect.TabIndex = 8;
            // 
            // txtAlturaRect
            // 
            txtAlturaRect.Location = new Point(43, 86);
            txtAlturaRect.Name = "txtAlturaRect";
            txtAlturaRect.Size = new Size(100, 23);
            txtAlturaRect.TabIndex = 9;
            // 
            // btnIngresarRect
            // 
            btnIngresarRect.Location = new Point(149, 71);
            btnIngresarRect.Name = "btnIngresarRect";
            btnIngresarRect.Size = new Size(97, 49);
            btnIngresarRect.TabIndex = 7;
            btnIngresarRect.Text = "Ingresar Atributos";
            btnIngresarRect.UseVisualStyleBackColor = true;
            btnIngresarRect.Click += btnIngresarRect_Click;
            // 
            // btnMostrarPilaRect
            // 
            btnMostrarPilaRect.Location = new Point(43, 159);
            btnMostrarPilaRect.Name = "btnMostrarPilaRect";
            btnMostrarPilaRect.Size = new Size(100, 49);
            btnMostrarPilaRect.TabIndex = 6;
            btnMostrarPilaRect.Text = "Mostrar Pila";
            btnMostrarPilaRect.UseVisualStyleBackColor = true;
            btnMostrarPilaRect.Click += btnMostrarPilaRect_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblPilaParal);
            tabPage3.Controls.Add(txtNombreParal);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(txtBaseParal);
            tabPage3.Controls.Add(txtAlturaParal);
            tabPage3.Controls.Add(btnIngresarParal);
            tabPage3.Controls.Add(btnMostrarPilaParal);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1052, 540);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Paralelogramo";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblPilaParal
            // 
            lblPilaParal.AutoSize = true;
            lblPilaParal.Location = new Point(89, 211);
            lblPilaParal.Name = "lblPilaParal";
            lblPilaParal.Size = new Size(38, 15);
            lblPilaParal.TabIndex = 23;
            lblPilaParal.Text = "label4";
            // 
            // txtNombreParal
            // 
            txtNombreParal.Location = new Point(53, 44);
            txtNombreParal.Name = "txtNombreParal";
            txtNombreParal.Size = new Size(100, 23);
            txtNombreParal.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 111);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 21;
            label7.Text = "Base";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 70);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 20;
            label8.Text = "Altura";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(76, 26);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 19;
            label9.Text = "Nombre";
            // 
            // txtBaseParal
            // 
            txtBaseParal.Location = new Point(53, 129);
            txtBaseParal.Name = "txtBaseParal";
            txtBaseParal.Size = new Size(100, 23);
            txtBaseParal.TabIndex = 17;
            // 
            // txtAlturaParal
            // 
            txtAlturaParal.Location = new Point(53, 85);
            txtAlturaParal.Name = "txtAlturaParal";
            txtAlturaParal.Size = new Size(100, 23);
            txtAlturaParal.TabIndex = 18;
            // 
            // btnIngresarParal
            // 
            btnIngresarParal.Location = new Point(180, 59);
            btnIngresarParal.Name = "btnIngresarParal";
            btnIngresarParal.Size = new Size(97, 49);
            btnIngresarParal.TabIndex = 16;
            btnIngresarParal.Text = "Ingresar Atributos";
            btnIngresarParal.UseVisualStyleBackColor = true;
            btnIngresarParal.Click += btnIngresarParal_Click;
            // 
            // btnMostrarPilaParal
            // 
            btnMostrarPilaParal.Location = new Point(53, 158);
            btnMostrarPilaParal.Name = "btnMostrarPilaParal";
            btnMostrarPilaParal.Size = new Size(100, 50);
            btnMostrarPilaParal.TabIndex = 15;
            btnMostrarPilaParal.Text = "Mostrar Pila";
            btnMostrarPilaParal.UseVisualStyleBackColor = true;
            btnMostrarPilaParal.Click += btnMostrarPilaParal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 610);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBase;
        private TextBox txtAltura;
        private TextBox txtNombre;
        private Button btnAgregar;
        private Button btnMostrarPila;
        private Label lblPila;
        private TextBox txtNombreRect;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBaseRect;
        private TextBox txtAlturaRect;
        private Button btnIngresarRect;
        private Button btnMostrarPilaRect;
        private TextBox txtNombreParal;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtBaseParal;
        private TextBox txtAlturaParal;
        private Button btnIngresarParal;
        private Button btnMostrarPilaParal;
        private Label lblPilaRect;
        private Label lblPilaParal;
    }
}