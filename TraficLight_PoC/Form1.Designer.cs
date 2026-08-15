namespace TraficLight_PoC
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
            this.ctrlTraficLight1 = new TraficLight_PoC.ctrlTraficLight();
            this.ctrlTraficLight2 = new TraficLight_PoC.ctrlTraficLight();
            this.ctrlTraficLight3 = new TraficLight_PoC.ctrlTraficLight();
            this.SuspendLayout();
            // 
            // ctrlTraficLight1
            // 
            this.ctrlTraficLight1.CurrentLight = TraficLight_PoC.ctrlTraficLight.enLights.Orange;
            this.ctrlTraficLight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTraficLight1.GreenTime = ((byte)(5));
            this.ctrlTraficLight1.Location = new System.Drawing.Point(60, 34);
            this.ctrlTraficLight1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlTraficLight1.Name = "ctrlTraficLight1";
            this.ctrlTraficLight1.OrangeTime = ((byte)(3));
            this.ctrlTraficLight1.RedTime = ((byte)(2));
            this.ctrlTraficLight1.Size = new System.Drawing.Size(170, 283);
            this.ctrlTraficLight1.TabIndex = 0;
            this.ctrlTraficLight1.OnColorChanged += new System.Action<TraficLight_PoC.ctrlTraficLight.EventData>(this.ctrlTraficLight1_OnColorChanged);
            // 
            // ctrlTraficLight2
            // 
            this.ctrlTraficLight2.CurrentLight = TraficLight_PoC.ctrlTraficLight.enLights.Red;
            this.ctrlTraficLight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTraficLight2.GreenTime = ((byte)(10));
            this.ctrlTraficLight2.Location = new System.Drawing.Point(339, 53);
            this.ctrlTraficLight2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlTraficLight2.Name = "ctrlTraficLight2";
            this.ctrlTraficLight2.OrangeTime = ((byte)(6));
            this.ctrlTraficLight2.RedTime = ((byte)(7));
            this.ctrlTraficLight2.Size = new System.Drawing.Size(170, 283);
            this.ctrlTraficLight2.TabIndex = 0;
            this.ctrlTraficLight2.OnColorChanged += new System.Action<TraficLight_PoC.ctrlTraficLight.EventData>(this.ctrlTraficLight1_OnColorChanged);
            // 
            // ctrlTraficLight3
            // 
            this.ctrlTraficLight3.CurrentLight = TraficLight_PoC.ctrlTraficLight.enLights.Red;
            this.ctrlTraficLight3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTraficLight3.GreenTime = ((byte)(10));
            this.ctrlTraficLight3.Location = new System.Drawing.Point(594, 53);
            this.ctrlTraficLight3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlTraficLight3.Name = "ctrlTraficLight3";
            this.ctrlTraficLight3.OrangeTime = ((byte)(6));
            this.ctrlTraficLight3.RedTime = ((byte)(7));
            this.ctrlTraficLight3.Size = new System.Drawing.Size(170, 283);
            this.ctrlTraficLight3.TabIndex = 0;
            this.ctrlTraficLight3.OnColorChanged += new System.Action<TraficLight_PoC.ctrlTraficLight.EventData>(this.ctrlTraficLight1_OnColorChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 420);
            this.Controls.Add(this.ctrlTraficLight3);
            this.Controls.Add(this.ctrlTraficLight2);
            this.Controls.Add(this.ctrlTraficLight1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTraficLight ctrlTraficLight1;
        private ctrlTraficLight ctrlTraficLight2;
        private ctrlTraficLight ctrlTraficLight3;
    }
}

