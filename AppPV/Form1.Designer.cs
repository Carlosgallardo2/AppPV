
namespace AppPV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Nombretxtbox = new System.Windows.Forms.TextBox();
            this.Apellidotxtbox = new System.Windows.Forms.TextBox();
            this.Maternotxtbox = new System.Windows.Forms.TextBox();
            this.Domiciliotxtbox = new System.Windows.Forms.TextBox();
            this.Fechanactxtbox = new System.Windows.Forms.TextBox();
            this.Teltxtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.idtxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AppPV CRUD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Domicilio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha nacimiento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefono";
            // 
            // Nombretxtbox
            // 
            this.Nombretxtbox.Location = new System.Drawing.Point(231, 106);
            this.Nombretxtbox.Name = "Nombretxtbox";
            this.Nombretxtbox.Size = new System.Drawing.Size(146, 20);
            this.Nombretxtbox.TabIndex = 7;
            this.Nombretxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Apellidotxtbox
            // 
            this.Apellidotxtbox.Location = new System.Drawing.Point(231, 152);
            this.Apellidotxtbox.Name = "Apellidotxtbox";
            this.Apellidotxtbox.Size = new System.Drawing.Size(146, 20);
            this.Apellidotxtbox.TabIndex = 8;
            // 
            // Maternotxtbox
            // 
            this.Maternotxtbox.Location = new System.Drawing.Point(231, 189);
            this.Maternotxtbox.Name = "Maternotxtbox";
            this.Maternotxtbox.Size = new System.Drawing.Size(146, 20);
            this.Maternotxtbox.TabIndex = 9;
            // 
            // Domiciliotxtbox
            // 
            this.Domiciliotxtbox.Location = new System.Drawing.Point(231, 234);
            this.Domiciliotxtbox.Name = "Domiciliotxtbox";
            this.Domiciliotxtbox.Size = new System.Drawing.Size(146, 20);
            this.Domiciliotxtbox.TabIndex = 10;
            // 
            // Fechanactxtbox
            // 
            this.Fechanactxtbox.Location = new System.Drawing.Point(231, 276);
            this.Fechanactxtbox.Name = "Fechanactxtbox";
            this.Fechanactxtbox.Size = new System.Drawing.Size(146, 20);
            this.Fechanactxtbox.TabIndex = 11;
            // 
            // Teltxtbox
            // 
            this.Teltxtbox.Location = new System.Drawing.Point(231, 320);
            this.Teltxtbox.Name = "Teltxtbox";
            this.Teltxtbox.Size = new System.Drawing.Size(146, 20);
            this.Teltxtbox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(441, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Lista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(441, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Actualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID ";
            // 
            // idtxtbox
            // 
            this.idtxtbox.Location = new System.Drawing.Point(231, 62);
            this.idtxtbox.Name = "idtxtbox";
            this.idtxtbox.Size = new System.Drawing.Size(100, 20);
            this.idtxtbox.TabIndex = 18;
            this.idtxtbox.TextChanged += new System.EventHandler(this.idtxtbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 410);
            this.Controls.Add(this.idtxtbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Teltxtbox);
            this.Controls.Add(this.Fechanactxtbox);
            this.Controls.Add(this.Domiciliotxtbox);
            this.Controls.Add(this.Maternotxtbox);
            this.Controls.Add(this.Apellidotxtbox);
            this.Controls.Add(this.Nombretxtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "idtxtbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Nombretxtbox;
        private System.Windows.Forms.TextBox Apellidotxtbox;
        private System.Windows.Forms.TextBox Maternotxtbox;
        private System.Windows.Forms.TextBox Domiciliotxtbox;
        private System.Windows.Forms.TextBox Fechanactxtbox;
        private System.Windows.Forms.TextBox Teltxtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idtxtbox;
    }
}

