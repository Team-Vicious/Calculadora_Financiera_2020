namespace Calculadora_Financiera_Team_Vicious
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
            this.butt_OP = new System.Windows.Forms.Button();
            this.butt_OUT = new System.Windows.Forms.Button();
            this.butt_DEL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_opf = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_val2opf = new System.Windows.Forms.TextBox();
            this.text_val3opf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_FORMULA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_RESULTADO = new System.Windows.Forms.TextBox();
            this.text_val1opf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butt_OP
            // 
            this.butt_OP.BackColor = System.Drawing.Color.Aqua;
            this.butt_OP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_OP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.butt_OP.Location = new System.Drawing.Point(83, 405);
            this.butt_OP.Name = "butt_OP";
            this.butt_OP.Size = new System.Drawing.Size(116, 41);
            this.butt_OP.TabIndex = 5;
            this.butt_OP.Text = "OPERAR";
            this.butt_OP.UseVisualStyleBackColor = false;
            this.butt_OP.Click += new System.EventHandler(this.butt_OP_Click);
            // 
            // butt_OUT
            // 
            this.butt_OUT.BackColor = System.Drawing.Color.Yellow;
            this.butt_OUT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_OUT.Location = new System.Drawing.Point(372, 405);
            this.butt_OUT.Name = "butt_OUT";
            this.butt_OUT.Size = new System.Drawing.Size(118, 41);
            this.butt_OUT.TabIndex = 6;
            this.butt_OUT.Text = "SALIR";
            this.butt_OUT.UseVisualStyleBackColor = false;
            this.butt_OUT.Click += new System.EventHandler(this.butt_OUT_Click);
            // 
            // butt_DEL
            // 
            this.butt_DEL.BackColor = System.Drawing.Color.Red;
            this.butt_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_DEL.Location = new System.Drawing.Point(227, 405);
            this.butt_DEL.Name = "butt_DEL";
            this.butt_DEL.Size = new System.Drawing.Size(116, 41);
            this.butt_DEL.TabIndex = 7;
            this.butt_DEL.Text = "DEL";
            this.butt_DEL.UseVisualStyleBackColor = false;
            this.butt_DEL.Click += new System.EventHandler(this.butt_DEL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(61, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "VALOR 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(80, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "RESULTADO";
            // 
            // comboBox_opf
            // 
            this.comboBox_opf.FormattingEnabled = true;
            this.comboBox_opf.Items.AddRange(new object[] {
            "INTERES SIMPLE GENERAL",
            "INTERES DE UNA INVERSION",
            "TASA DE INTERES 1",
            "TASA DE INTERES 2",
            "PERIODO DE CAPITALIZACION 1",
            "PERIODO DE CAPITALIZACION 2",
            "DESCUENTO SIMPLE 1",
            "DESCUENTO SIMPLE 2",
            "INTERES COMPUESTO GENERAL",
            "CAPITALIZACION COMPUESTA",
            "VALOR ACTUAL A INTERES COMPUESTO",
            "TASA DEL PERIODO DE CAPITALIZACION ",
            "CALCULO DE LA DURACION DE LA OPERACION FINANCIERA"});
            this.comboBox_opf.Location = new System.Drawing.Point(185, 27);
            this.comboBox_opf.Name = "comboBox_opf";
            this.comboBox_opf.Size = new System.Drawing.Size(320, 21);
            this.comboBox_opf.TabIndex = 15;
            this.comboBox_opf.SelectedIndexChanged += new System.EventHandler(this.comboBox_opf_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "OPERACIONES";
            // 
            // text_val2opf
            // 
            this.text_val2opf.Location = new System.Drawing.Point(185, 118);
            this.text_val2opf.Name = "text_val2opf";
            this.text_val2opf.Size = new System.Drawing.Size(170, 20);
            this.text_val2opf.TabIndex = 18;
            this.text_val2opf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_val2opf_KeyPress);
            // 
            // text_val3opf
            // 
            this.text_val3opf.Location = new System.Drawing.Point(185, 164);
            this.text_val3opf.Name = "text_val3opf";
            this.text_val3opf.Size = new System.Drawing.Size(170, 20);
            this.text_val3opf.TabIndex = 19;
            this.text_val3opf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_val3opf_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(100, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "VALOR 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(100, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "VALOR 1";
            // 
            // textBox_FORMULA
            // 
            this.textBox_FORMULA.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_FORMULA.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FORMULA.ForeColor = System.Drawing.Color.Black;
            this.textBox_FORMULA.Location = new System.Drawing.Point(185, 211);
            this.textBox_FORMULA.Multiline = true;
            this.textBox_FORMULA.Name = "textBox_FORMULA";
            this.textBox_FORMULA.ReadOnly = true;
            this.textBox_FORMULA.Size = new System.Drawing.Size(364, 54);
            this.textBox_FORMULA.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(90, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "FORMULA";
            // 
            // textBox_RESULTADO
            // 
            this.textBox_RESULTADO.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_RESULTADO.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RESULTADO.ForeColor = System.Drawing.Color.Red;
            this.textBox_RESULTADO.Location = new System.Drawing.Point(185, 288);
            this.textBox_RESULTADO.Multiline = true;
            this.textBox_RESULTADO.Name = "textBox_RESULTADO";
            this.textBox_RESULTADO.ReadOnly = true;
            this.textBox_RESULTADO.Size = new System.Drawing.Size(255, 56);
            this.textBox_RESULTADO.TabIndex = 24;
            this.textBox_RESULTADO.TextChanged += new System.EventHandler(this.textBox_RESULTADO_TextChanged);
            // 
            // text_val1opf
            // 
            this.text_val1opf.Location = new System.Drawing.Point(185, 72);
            this.text_val1opf.Name = "text_val1opf";
            this.text_val1opf.Size = new System.Drawing.Size(170, 20);
            this.text_val1opf.TabIndex = 26;
            this.text_val1opf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_val1opf_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(372, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "⌫";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(372, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "⌫";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(372, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "⌫";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 500);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_val1opf);
            this.Controls.Add(this.textBox_RESULTADO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_FORMULA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_val3opf);
            this.Controls.Add(this.text_val2opf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_opf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butt_DEL);
            this.Controls.Add(this.butt_OUT);
            this.Controls.Add(this.butt_OP);
            this.Name = "Form1";
            this.Text = "CALCULADORA FINANCIERA 2020";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butt_OP;
        private System.Windows.Forms.Button butt_OUT;
        private System.Windows.Forms.Button butt_DEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_opf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_val2opf;
        private System.Windows.Forms.TextBox text_val3opf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_FORMULA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_RESULTADO;
        private System.Windows.Forms.TextBox text_val1opf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

