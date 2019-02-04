namespace oop_lab1
{
    partial class FormSelectFigure
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColor = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(12, 39);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(186, 23);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Цвет";
            this.buttonColor.UseVisualStyleBackColor = true;
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(214, 40);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(23, 22);
            this.panelColor.TabIndex = 2;
            // 
            // FormSelectFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 75);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.buttonColor);
            this.Name = "FormSelectFigure";
            this.Text = "Выбор фигуры";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Panel panelColor;
    }
}