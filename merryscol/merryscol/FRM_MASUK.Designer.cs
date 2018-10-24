namespace merryscol
{
    partial class FRM_MASUK
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
            this.merryscol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metrocom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // merryscol
            // 
            this.merryscol.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.merryscol.BackgroundImage = global::merryscol.Properties.Resources.Adolf_Hitler_Nazi_Flag__6_1_;
            this.merryscol.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merryscol.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.merryscol.Location = new System.Drawing.Point(3, 42);
            this.merryscol.Name = "merryscol";
            this.merryscol.Size = new System.Drawing.Size(292, 76);
            this.merryscol.TabIndex = 0;
            this.merryscol.Text = "Merry\'s Collection";
            this.merryscol.UseVisualStyleBackColor = false;
            this.merryscol.Click += new System.EventHandler(this.merryscol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Masuk Sebagai?";
            // 
            // metrocom
            // 
            this.metrocom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metrocom.BackgroundImage = global::merryscol.Properties.Resources.Adolf_Hitler_Nazi_Flag__6_1_;
            this.metrocom.Font = new System.Drawing.Font("News706 BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metrocom.ForeColor = System.Drawing.Color.Cyan;
            this.metrocom.Location = new System.Drawing.Point(3, 124);
            this.metrocom.Name = "metrocom";
            this.metrocom.Size = new System.Drawing.Size(292, 76);
            this.metrocom.TabIndex = 3;
            this.metrocom.Text = "MetroCom";
            this.metrocom.UseVisualStyleBackColor = false;
            this.metrocom.Click += new System.EventHandler(this.metrocom_Click);
            // 
            // FRM_MASUK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::merryscol.Properties.Resources.Adolf_Hitler_Nazi_Flag__8_;
            this.ClientSize = new System.Drawing.Size(298, 204);
            this.Controls.Add(this.metrocom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.merryscol);
            this.Name = "FRM_MASUK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_MASUK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button merryscol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button metrocom;
    }
}