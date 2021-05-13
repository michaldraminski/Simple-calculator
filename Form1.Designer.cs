
namespace projekt_kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.display = new System.Windows.Forms.TextBox();
            this.ce = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.changesign = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zegarek = new System.Windows.Forms.Label();
            this.blue_mode = new System.Windows.Forms.RadioButton();
            this.night_mode = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(322, 47);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ce
            // 
            this.ce.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ce.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ce.Location = new System.Drawing.Point(94, 86);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(76, 44);
            this.ce.TabIndex = 1;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = false;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.SystemColors.MenuBar;
            this.backspace.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.backspace.Location = new System.Drawing.Point(12, 86);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(76, 44);
            this.backspace.TabIndex = 2;
            this.backspace.Text = "";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.SystemColors.MenuBar;
            this.c.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c.Location = new System.Drawing.Point(176, 86);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(76, 44);
            this.c.TabIndex = 3;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // changesign
            // 
            this.changesign.BackColor = System.Drawing.SystemColors.MenuBar;
            this.changesign.Font = new System.Drawing.Font("Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.changesign.Location = new System.Drawing.Point(258, 86);
            this.changesign.Name = "changesign";
            this.changesign.Size = new System.Drawing.Size(76, 44);
            this.changesign.TabIndex = 4;
            this.changesign.Text = "";
            this.changesign.UseVisualStyleBackColor = false;
            this.changesign.Click += new System.EventHandler(this.changesign_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.MenuBar;
            this.add.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.Location = new System.Drawing.Point(258, 142);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(76, 44);
            this.add.TabIndex = 8;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Operation_Function);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button9.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(176, 142);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 44);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Value);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button8.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(94, 142);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 44);
            this.button8.TabIndex = 5;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Value);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button7.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(12, 142);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 44);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Value);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(12, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 44);
            this.button4.TabIndex = 13;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Value);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.SystemColors.MenuBar;
            this.subtract.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subtract.Location = new System.Drawing.Point(258, 192);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(76, 44);
            this.subtract.TabIndex = 12;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.Operation_Function);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(176, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 44);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Value);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(94, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 44);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Value);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button0.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button0.Location = new System.Drawing.Point(12, 292);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(76, 44);
            this.button0.TabIndex = 21;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.Value);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.MenuBar;
            this.divide.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divide.Location = new System.Drawing.Point(258, 292);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(76, 44);
            this.divide.TabIndex = 20;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.Operation_Function);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.MenuBar;
            this.equals.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equals.Location = new System.Drawing.Point(176, 292);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(76, 44);
            this.equals.TabIndex = 19;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // comma
            // 
            this.comma.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comma.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comma.Location = new System.Drawing.Point(94, 292);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(76, 44);
            this.comma.TabIndex = 18;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = false;
            this.comma.Click += new System.EventHandler(this.Value);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Value);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.MenuBar;
            this.multiply.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiply.Location = new System.Drawing.Point(258, 242);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(76, 44);
            this.multiply.TabIndex = 16;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.Operation_Function);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(176, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Value);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(94, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Value);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zegarek
            // 
            this.zegarek.AutoSize = true;
            this.zegarek.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zegarek.Location = new System.Drawing.Point(238, 341);
            this.zegarek.Name = "zegarek";
            this.zegarek.Size = new System.Drawing.Size(36, 27);
            this.zegarek.TabIndex = 22;
            this.zegarek.Text = "...";
            // 
            // blue_mode
            // 
            this.blue_mode.AutoSize = true;
            this.blue_mode.Checked = true;
            this.blue_mode.Location = new System.Drawing.Point(176, 65);
            this.blue_mode.Name = "blue_mode";
            this.blue_mode.Size = new System.Drawing.Size(74, 17);
            this.blue_mode.TabIndex = 23;
            this.blue_mode.TabStop = true;
            this.blue_mode.Text = "blue mode";
            this.blue_mode.UseVisualStyleBackColor = true;
            this.blue_mode.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // night_mode
            // 
            this.night_mode.AutoSize = true;
            this.night_mode.Location = new System.Drawing.Point(258, 65);
            this.night_mode.Name = "night_mode";
            this.night_mode.Size = new System.Drawing.Size(77, 17);
            this.night_mode.TabIndex = 24;
            this.night_mode.Text = "night mode";
            this.night_mode.UseVisualStyleBackColor = true;
            this.night_mode.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(343, 377);
            this.Controls.Add(this.night_mode);
            this.Controls.Add(this.blue_mode);
            this.Controls.Add(this.zegarek);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.changesign);
            this.Controls.Add(this.c);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.ce);
            this.Controls.Add(this.display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button changesign;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label zegarek;
        private System.Windows.Forms.RadioButton blue_mode;
        private System.Windows.Forms.RadioButton night_mode;
    }
}

