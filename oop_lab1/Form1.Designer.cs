namespace oop_lab1
{
    partial class mainform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonRandomMove = new System.Windows.Forms.Button();
            this.buttonArrowMove = new System.Windows.Forms.Button();
            this.labelCursor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxLine = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDop = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lineWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBoxLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(780, 16);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.buttonClose_PreviewKeyDown);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(524, 16);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(80, 53);
            this.buttonDraw.TabIndex = 4;
            this.buttonDraw.Text = "Нарисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            this.buttonDraw.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.buttonDraw_PreviewKeyDown);
            // 
            // buttonRandomMove
            // 
            this.buttonRandomMove.Location = new System.Drawing.Point(610, 16);
            this.buttonRandomMove.Name = "buttonRandomMove";
            this.buttonRandomMove.Size = new System.Drawing.Size(154, 23);
            this.buttonRandomMove.TabIndex = 5;
            this.buttonRandomMove.Text = "Случаное перемещение";
            this.buttonRandomMove.UseVisualStyleBackColor = true;
            this.buttonRandomMove.Click += new System.EventHandler(this.buttonRandomMove_Click);
            this.buttonRandomMove.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.buttonRandomMove_PreviewKeyDown);
            // 
            // buttonArrowMove
            // 
            this.buttonArrowMove.Location = new System.Drawing.Point(610, 47);
            this.buttonArrowMove.Name = "buttonArrowMove";
            this.buttonArrowMove.Size = new System.Drawing.Size(154, 23);
            this.buttonArrowMove.TabIndex = 6;
            this.buttonArrowMove.Text = "Перемещение стрелками";
            this.buttonArrowMove.UseVisualStyleBackColor = true;
            this.buttonArrowMove.Click += new System.EventHandler(this.buttonArrowMove_Click);
            this.buttonArrowMove.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.buttonArrowMove_PreviewKeyDown);
            // 
            // labelCursor
            // 
            this.labelCursor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCursor.AutoSize = true;
            this.labelCursor.Location = new System.Drawing.Point(13, 455);
            this.labelCursor.Name = "labelCursor";
            this.labelCursor.Size = new System.Drawing.Size(150, 13);
            this.labelCursor.TabIndex = 7;
            this.labelCursor.Text = "Положение курсора: X= ; Y=";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Отрезок",
            "Треугольник",
            "Прямоугольник",
            "Окружность",
            "Эллипс"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Выберите фигуру";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 21);
            this.panel1.TabIndex = 10;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Цвет";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxLine
            // 
            this.groupBoxLine.Controls.Add(this.label8);
            this.groupBoxLine.Controls.Add(this.label9);
            this.groupBoxLine.Controls.Add(this.labelDop);
            this.groupBoxLine.Controls.Add(this.textBox5);
            this.groupBoxLine.Controls.Add(this.textBox6);
            this.groupBoxLine.Controls.Add(this.label7);
            this.groupBoxLine.Controls.Add(this.label6);
            this.groupBoxLine.Controls.Add(this.label5);
            this.groupBoxLine.Controls.Add(this.textBox4);
            this.groupBoxLine.Controls.Add(this.label4);
            this.groupBoxLine.Controls.Add(this.labelEnd);
            this.groupBoxLine.Controls.Add(this.labelStart);
            this.groupBoxLine.Controls.Add(this.textBox3);
            this.groupBoxLine.Controls.Add(this.textBox2);
            this.groupBoxLine.Controls.Add(this.textBox1);
            this.groupBoxLine.Location = new System.Drawing.Point(176, 10);
            this.groupBoxLine.Name = "groupBoxLine";
            this.groupBoxLine.Size = new System.Drawing.Size(321, 60);
            this.groupBoxLine.TabIndex = 11;
            this.groupBoxLine.TabStop = false;
            this.groupBoxLine.Text = "Координаты фигуры";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(234, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(192, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "X";
            // 
            // labelDop
            // 
            this.labelDop.AutoSize = true;
            this.labelDop.Location = new System.Drawing.Point(206, 19);
            this.labelDop.Name = "labelDop";
            this.labelDop.Size = new System.Drawing.Size(38, 13);
            this.labelDop.TabIndex = 12;
            this.labelDop.Text = "Конец";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(208, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(26, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "550";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(249, 36);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(26, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "400";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(44, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(138, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(96, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "X";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 35);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(26, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "400";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(111, 19);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(38, 13);
            this.labelEnd.TabIndex = 5;
            this.labelEnd.Text = "Конец";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(3, 19);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(44, 13);
            this.labelStart.TabIndex = 4;
            this.labelStart.Text = "Начало";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(26, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "250";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "200";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "400";
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Толщина";
            // 
            // lineWidth
            // 
            this.lineWidth.Location = new System.Drawing.Point(113, 42);
            this.lineWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lineWidth.Name = "lineWidth";
            this.lineWidth.Size = new System.Drawing.Size(38, 20);
            this.lineWidth.TabIndex = 13;
            this.lineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "px";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(867, 376);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lineWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxLine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelCursor);
            this.Controls.Add(this.buttonArrowMove);
            this.Controls.Add(this.buttonRandomMove);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.buttonClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Points";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainform_Load);
            this.Shown += new System.EventHandler(this.mainform_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainform_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainform_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainform_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxLine.ResumeLayout(false);
            this.groupBoxLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonRandomMove;
        private System.Windows.Forms.Button buttonArrowMove;
        private System.Windows.Forms.Label labelCursor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxLine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDop;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lineWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

