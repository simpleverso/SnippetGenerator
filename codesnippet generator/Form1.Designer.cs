namespace codesnippet_generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Txt_predeterminado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.Txt_accesodirecto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_comentario = new System.Windows.Forms.TextBox();
            this.cmb_lenguajes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_usings = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.check_final = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(19, 195);
            this.txt_Codigo.Multiline = true;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(394, 196);
            this.txt_Codigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Herramienta que genera codigos tipo snippetcode para c# de visual studio";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(16, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generar snippetcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresa el codigo de c# aqui.";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(429, 188);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(243, 32);
            this.txt_ID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripcion";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(429, 253);
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(243, 78);
            this.Txt_descripcion.TabIndex = 7;
            // 
            // Txt_predeterminado
            // 
            this.Txt_predeterminado.Location = new System.Drawing.Point(429, 357);
            this.Txt_predeterminado.Multiline = true;
            this.Txt_predeterminado.Name = "Txt_predeterminado";
            this.Txt_predeterminado.Size = new System.Drawing.Size(243, 53);
            this.Txt_predeterminado.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Predeterminado";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(31, 106);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(353, 58);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Location = new System.Drawing.Point(247, 397);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(151, 20);
            this.txt_Titulo.TabIndex = 11;
            // 
            // Txt_accesodirecto
            // 
            this.Txt_accesodirecto.Location = new System.Drawing.Point(298, 423);
            this.Txt_accesodirecto.Name = "Txt_accesodirecto";
            this.Txt_accesodirecto.Size = new System.Drawing.Size(100, 20);
            this.Txt_accesodirecto.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Titulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Acceso directo**";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Comentario";
            // 
            // Txt_comentario
            // 
            this.Txt_comentario.Location = new System.Drawing.Point(247, 449);
            this.Txt_comentario.Multiline = true;
            this.Txt_comentario.Name = "Txt_comentario";
            this.Txt_comentario.Size = new System.Drawing.Size(151, 52);
            this.Txt_comentario.TabIndex = 15;
            // 
            // cmb_lenguajes
            // 
            this.cmb_lenguajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_lenguajes.FormattingEnabled = true;
            this.cmb_lenguajes.Items.AddRange(new object[] {
            "VB",
            "csharp",
            "css",
            "html",
            "JavaScript",
            "SQL_SSDT",
            "TypeScript",
            "cpp",
            "XAML",
            "XML"});
            this.cmb_lenguajes.Location = new System.Drawing.Point(426, 106);
            this.cmb_lenguajes.Name = "cmb_lenguajes";
            this.cmb_lenguajes.Size = new System.Drawing.Size(241, 21);
            this.cmb_lenguajes.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Lenguaje";
            // 
            // txt_usings
            // 
            this.txt_usings.Location = new System.Drawing.Point(429, 439);
            this.txt_usings.Multiline = true;
            this.txt_usings.Name = "txt_usings";
            this.txt_usings.Size = new System.Drawing.Size(243, 74);
            this.txt_usings.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(429, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Using";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Direccion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 47);
            this.button2.TabIndex = 23;
            this.button2.Text = "Abrir Snippet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Enabled = false;
            this.txt_direccion.Location = new System.Drawing.Point(93, 25);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(426, 20);
            this.txt_direccion.TabIndex = 24;
            // 
            // check_final
            // 
            this.check_final.AutoSize = true;
            this.check_final.Location = new System.Drawing.Point(429, 139);
            this.check_final.Name = "check_final";
            this.check_final.Size = new System.Drawing.Size(124, 17);
            this.check_final.TabIndex = 25;
            this.check_final.Text = "Final predeterminado";
            this.check_final.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 519);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "**Se guarda con este nombre";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 548);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.check_final);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_usings);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_lenguajes);
            this.Controls.Add(this.Txt_comentario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_accesodirecto);
            this.Controls.Add(this.txt_Titulo);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Txt_predeterminado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Codigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Generador de codigos tipo snippet para visual studio.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form1_DragOver);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.TextBox Txt_predeterminado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.TextBox Txt_accesodirecto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_comentario;
        private System.Windows.Forms.ComboBox cmb_lenguajes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_usings;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.CheckBox check_final;
        private System.Windows.Forms.Label label12;
    }
}

