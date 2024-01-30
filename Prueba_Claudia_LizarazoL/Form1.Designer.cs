namespace Prueba_Claudia_LizarazoL
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TipoDoc = new TextBox();
            NumeroDoc = new TextBox();
            nombres = new TextBox();
            apellidos = new TextBox();
            correo = new TextBox();
            telefono = new TextBox();
            fechanac = new TextBox();
            estadoafili = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 15);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Documento";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 48);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 1;
            label2.Text = "Numero de Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 87);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 122);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Apellidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 155);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 199);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 5;
            label6.Text = "Telefono";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 243);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 6;
            label7.Text = "Fecha de nacimiento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 280);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 7;
            label8.Text = "Esstado de afiliacion";
            // 
            // TipoDoc
            // 
            TipoDoc.Location = new Point(304, 5);
            TipoDoc.Name = "TipoDoc";
            TipoDoc.Size = new Size(125, 27);
            TipoDoc.TabIndex = 8;
            // 
            // NumeroDoc
            // 
            NumeroDoc.Location = new Point(304, 38);
            NumeroDoc.Name = "NumeroDoc";
            NumeroDoc.Size = new Size(125, 27);
            NumeroDoc.TabIndex = 9;
            // 
            // nombres
            // 
            nombres.Location = new Point(304, 71);
            nombres.Name = "nombres";
            nombres.Size = new Size(125, 27);
            nombres.TabIndex = 11;
            // 
            // apellidos
            // 
            apellidos.Location = new Point(304, 104);
            apellidos.Name = "apellidos";
            apellidos.Size = new Size(125, 27);
            apellidos.TabIndex = 12;
            // 
            // correo
            // 
            correo.Location = new Point(304, 148);
            correo.Name = "correo";
            correo.Size = new Size(125, 27);
            correo.TabIndex = 13;
            correo.TextChanged += correo_TextChanged;
            // 
            // telefono
            // 
            telefono.Location = new Point(304, 192);
            telefono.Name = "telefono";
            telefono.Size = new Size(125, 27);
            telefono.TabIndex = 14;
            // 
            // fechanac
            // 
            fechanac.Location = new Point(304, 240);
            fechanac.Name = "fechanac";
            fechanac.Size = new Size(125, 27);
            fechanac.TabIndex = 15;
            // 
            // estadoafili
            // 
            estadoafili.Location = new Point(304, 273);
            estadoafili.Name = "estadoafili";
            estadoafili.Size = new Size(125, 27);
            estadoafili.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(79, 323);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(227, 323);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(361, 323);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 19;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "Datos";
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.SizeAll;
            dataGridView1.Location = new Point(129, 358);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 555);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(estadoafili);
            Controls.Add(fechanac);
            Controls.Add(telefono);
            Controls.Add(correo);
            Controls.Add(apellidos);
            Controls.Add(nombres);
            Controls.Add(NumeroDoc);
            Controls.Add(TipoDoc);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox TipoDoc;
        private TextBox NumeroDoc;
        private TextBox nombres;
        private TextBox apellidos;
        private TextBox correo;
        private TextBox telefono;
        private TextBox fechanac;
        private TextBox estadoafili;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
    }
}
