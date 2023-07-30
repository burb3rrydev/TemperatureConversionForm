namespace Activity2
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
            lbCelcius = new Label();
            tbCelcius = new TextBox();
            lbFarenheit = new Label();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // lbCelcius
            // 
            lbCelcius.AutoSize = true;
            lbCelcius.Location = new Point(12, 12);
            lbCelcius.Name = "lbCelcius";
            lbCelcius.Size = new Size(124, 15);
            lbCelcius.TabIndex = 0;
            lbCelcius.Text = "Temprature In Celcius:";

            // 
            // tbCelcius
            // 
            tbCelcius.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCelcius.Location = new Point(136, 9);
            tbCelcius.Name = "tbCelcius";
            tbCelcius.Size = new Size(289, 23);
            tbCelcius.TabIndex = 1;
            // 
            // lbFarenheit
            // 
            lbFarenheit.AutoSize = true;
            lbFarenheit.Location = new Point(18, 56);
            lbFarenheit.Name = "lbFarenheit";
            lbFarenheit.Size = new Size(38, 15);
            lbFarenheit.TabIndex = 2;
            lbFarenheit.Text = "label1";
            // 
            // btnConvert
            // 
            btnConvert.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnConvert.Location = new Point(18, 272);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(407, 23);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Convert to Farenheit";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 301);
            Controls.Add(btnConvert);
            Controls.Add(lbFarenheit);
            Controls.Add(tbCelcius);
            Controls.Add(lbCelcius);
            Name = "Form1";
            Text = "Temprature Conversion";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCelcius;
        private TextBox tbCelcius;
        private Label lbFarenheit;
        private Button btnConvert;
    }
}