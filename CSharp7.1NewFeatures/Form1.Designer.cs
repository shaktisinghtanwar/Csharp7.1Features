namespace CSharp7._1NewFeatures
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
            this.btnDefaultExpressions = new System.Windows.Forms.Button();
            this.btnTupleEnhancement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDefaultExpressions
            // 
            this.btnDefaultExpressions.Location = new System.Drawing.Point(177, 88);
            this.btnDefaultExpressions.Name = "btnDefaultExpressions";
            this.btnDefaultExpressions.Size = new System.Drawing.Size(227, 49);
            this.btnDefaultExpressions.TabIndex = 0;
            this.btnDefaultExpressions.Text = "Default Literal Expressions";
            this.btnDefaultExpressions.UseVisualStyleBackColor = true;
            this.btnDefaultExpressions.Click += new System.EventHandler(this.btnDefaultExpressions_Click);
            // 
            // btnTupleEnhancement
            // 
            this.btnTupleEnhancement.Location = new System.Drawing.Point(491, 88);
            this.btnTupleEnhancement.Name = "btnTupleEnhancement";
            this.btnTupleEnhancement.Size = new System.Drawing.Size(227, 49);
            this.btnTupleEnhancement.TabIndex = 1;
            this.btnTupleEnhancement.Text = "Tuple Enhancement";
            this.btnTupleEnhancement.UseVisualStyleBackColor = true;
            this.btnTupleEnhancement.Click += new System.EventHandler(this.btnTupleEnhancement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 564);
            this.Controls.Add(this.btnTupleEnhancement);
            this.Controls.Add(this.btnDefaultExpressions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDefaultExpressions;
        private System.Windows.Forms.Button btnTupleEnhancement;
    }
}

