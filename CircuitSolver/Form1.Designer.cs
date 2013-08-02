namespace CircuitSolver
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
            this.addResistor = new System.Windows.Forms.Button();
            this.elementCountTextBox = new System.Windows.Forms.TextBox();
            this.canvas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addResistor
            // 
            this.addResistor.Location = new System.Drawing.Point(775, 12);
            this.addResistor.Name = "addResistor";
            this.addResistor.Size = new System.Drawing.Size(91, 32);
            this.addResistor.TabIndex = 0;
            this.addResistor.Text = "Resistor";
            this.addResistor.UseVisualStyleBackColor = true;
            this.addResistor.Click += new System.EventHandler(this.addResistor_Click);
            // 
            // elementCountTextBox
            // 
            this.elementCountTextBox.Enabled = false;
            this.elementCountTextBox.Location = new System.Drawing.Point(775, 61);
            this.elementCountTextBox.Name = "elementCountTextBox";
            this.elementCountTextBox.Size = new System.Drawing.Size(59, 20);
            this.elementCountTextBox.TabIndex = 1;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Gray;
            this.canvas.Location = new System.Drawing.Point(15, 15);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(741, 479);
            this.canvas.TabIndex = 2;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 514);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.elementCountTextBox);
            this.Controls.Add(this.addResistor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addResistor;
        private System.Windows.Forms.TextBox elementCountTextBox;
        private System.Windows.Forms.Panel canvas;
    }
}

