
namespace Final_Calc_App
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.conv_btn = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.currency_amt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.currency_to = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.currency_from = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.total_days = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.currencyConverterToolStripMenuItem,
            this.dateCalculatorToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.calculatorToolStripMenuItem.Text = "Standard Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // currencyConverterToolStripMenuItem
            // 
            this.currencyConverterToolStripMenuItem.Name = "currencyConverterToolStripMenuItem";
            this.currencyConverterToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.currencyConverterToolStripMenuItem.Text = "Currency Converter";
            this.currencyConverterToolStripMenuItem.Click += new System.EventHandler(this.currencyConverterToolStripMenuItem_Click);
            // 
            // dateCalculatorToolStripMenuItem
            // 
            this.dateCalculatorToolStripMenuItem.Name = "dateCalculatorToolStripMenuItem";
            this.dateCalculatorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.dateCalculatorToolStripMenuItem.Text = "Date Calculator";
            this.dateCalculatorToolStripMenuItem.Click += new System.EventHandler(this.dateCalculatorToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.history);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.text);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator";
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(12, 110);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(147, 62);
            this.text.TabIndex = 17;
            this.text.Text = "0";
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 46);
            this.label3.TabIndex = 19;
            this.label3.Text = "STANDARD CALCULATOR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 38);
            this.label2.TabIndex = 18;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button17.Location = new System.Drawing.Point(165, 69);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(47, 51);
            this.button17.TabIndex = 16;
            this.button17.Text = "C";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button16.Location = new System.Drawing.Point(165, 178);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(47, 51);
            this.button16.TabIndex = 15;
            this.button16.Text = "+";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button15.Location = new System.Drawing.Point(165, 235);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(47, 51);
            this.button15.TabIndex = 14;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button16_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button14.Location = new System.Drawing.Point(165, 292);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(47, 51);
            this.button14.TabIndex = 13;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button16_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button13.Location = new System.Drawing.Point(165, 349);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(47, 51);
            this.button13.TabIndex = 12;
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button16_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button12.Location = new System.Drawing.Point(112, 178);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(47, 51);
            this.button12.TabIndex = 11;
            this.button12.Text = "9";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button4_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button11.Location = new System.Drawing.Point(59, 178);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(47, 51);
            this.button11.TabIndex = 10;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button4_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button10.Location = new System.Drawing.Point(6, 178);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(47, 51);
            this.button10.TabIndex = 9;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button9.Location = new System.Drawing.Point(112, 235);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(47, 51);
            this.button9.TabIndex = 8;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button8.Location = new System.Drawing.Point(59, 235);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(47, 51);
            this.button8.TabIndex = 7;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button7.Location = new System.Drawing.Point(6, 235);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(47, 51);
            this.button7.TabIndex = 6;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button6.Location = new System.Drawing.Point(112, 292);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 51);
            this.button6.TabIndex = 5;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button4_Click);
            this.button6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(59, 292);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "2";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(6, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(112, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "=";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(59, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(6, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Result);
            this.groupBox2.Controls.Add(this.conv_btn);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.currency_amt);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.currency_to);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.currency_from);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(508, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 410);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Currency";
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(6, 86);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(243, 63);
            this.Result.TabIndex = 16;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // conv_btn
            // 
            this.conv_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.conv_btn.Location = new System.Drawing.Point(29, 286);
            this.conv_btn.Name = "conv_btn";
            this.conv_btn.Size = new System.Drawing.Size(183, 23);
            this.conv_btn.TabIndex = 15;
            this.conv_btn.Text = "Convert";
            this.conv_btn.UseVisualStyleBackColor = false;
            this.conv_btn.Click += new System.EventHandler(this.conv_btn_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(29, 198);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(56, 13);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "Amount : ";
            // 
            // currency_amt
            // 
            this.currency_amt.Location = new System.Drawing.Point(91, 198);
            this.currency_amt.Name = "currency_amt";
            this.currency_amt.Size = new System.Drawing.Size(121, 20);
            this.currency_amt.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(29, 244);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 13);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "To :";
            // 
            // currency_to
            // 
            this.currency_to.AutoCompleteCustomSource.AddRange(new string[] {
            "Indian Rupee",
            "US Dollar",
            "AUS Dollar",
            "CHN Yuan",
            "Japan Yen"});
            this.currency_to.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.currency_to.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.currency_to.FormattingEnabled = true;
            this.currency_to.Items.AddRange(new object[] {
            "Indian Rupee",
            "US Dollar",
            "AUS Dollar",
            "CHN Yuan",
            "Japan Yen"});
            this.currency_to.Location = new System.Drawing.Point(91, 244);
            this.currency_to.Name = "currency_to";
            this.currency_to.Size = new System.Drawing.Size(121, 21);
            this.currency_to.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(29, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 13);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "From :";
            // 
            // currency_from
            // 
            this.currency_from.AutoCompleteCustomSource.AddRange(new string[] {
            "Indian Rupee",
            "US Dollar",
            "AUS Dollar",
            "CHN Yuan",
            "Japan Yen"});
            this.currency_from.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.currency_from.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.currency_from.FormattingEnabled = true;
            this.currency_from.Items.AddRange(new object[] {
            "Indian Rupee",
            "US Dollar",
            "AUS Dollar",
            "CHN Yuan",
            "Japan Yen"});
            this.currency_from.Location = new System.Drawing.Point(91, 160);
            this.currency_from.Name = "currency_from";
            this.currency_from.Size = new System.Drawing.Size(121, 21);
            this.currency_from.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(251, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Currency Converter";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.total_days);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.button18);
            this.groupBox3.Controls.Add(this.ToDate);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.FromDate);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Location = new System.Drawing.Point(769, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 410);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(15, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 15);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "Difference";
            // 
            // total_days
            // 
            this.total_days.BackColor = System.Drawing.SystemColors.MenuBar;
            this.total_days.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_days.Location = new System.Drawing.Point(6, 337);
            this.total_days.Multiline = true;
            this.total_days.Name = "total_days";
            this.total_days.Size = new System.Drawing.Size(231, 62);
            this.total_days.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(6, 257);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(228, 74);
            this.textBox6.TabIndex = 14;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(15, 182);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 13;
            this.button18.Text = "Difference";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(15, 134);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(200, 20);
            this.ToDate.TabIndex = 12;
            this.ToDate.Value = new System.DateTime(2021, 1, 20, 0, 0, 0, 0);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox7.Location = new System.Drawing.Point(15, 106);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(32, 13);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "To";
            this.textBox7.WordWrap = false;
            // 
            // FromDate
            // 
            this.FromDate.Location = new System.Drawing.Point(15, 67);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(200, 20);
            this.FromDate.TabIndex = 10;
            this.FromDate.Value = new System.DateTime(2021, 1, 20, 0, 0, 0, 0);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox8.Location = new System.Drawing.Point(15, 39);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(32, 13);
            this.textBox8.TabIndex = 9;
            this.textBox8.Text = "From";
            this.textBox8.WordWrap = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button19.Location = new System.Drawing.Point(165, 121);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(47, 51);
            this.button19.TabIndex = 20;
            this.button19.Text = "⌫";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Location = new System.Drawing.Point(218, 9);
            this.history.Multiline = true;
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(278, 391);
            this.history.TabIndex = 21;
            this.history.Text = "History";
            this.history.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateCalculatorToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button conv_btn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox currency_amt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox currency_to;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox currency_from;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox total_days;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TextBox history;
    }
}

