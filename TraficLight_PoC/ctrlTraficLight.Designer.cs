namespace TraficLight_PoC
{
    partial class ctrlTraficLight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCounter = new System.Windows.Forms.Label();
            this.pbTrafficLight = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(70, 254);
            this.lblCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(36, 26);
            this.lblCounter.TabIndex = 0;
            this.lblCounter.Text = "??";
            // 
            // pbTrafficLight
            // 
            this.pbTrafficLight.Image = global::TraficLight_PoC.Properties.Resources.Red;
            this.pbTrafficLight.Location = new System.Drawing.Point(13, 7);
            this.pbTrafficLight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbTrafficLight.Name = "pbTrafficLight";
            this.pbTrafficLight.Size = new System.Drawing.Size(145, 238);
            this.pbTrafficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrafficLight.TabIndex = 1;
            this.pbTrafficLight.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ctrlTraficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbTrafficLight);
            this.Controls.Add(this.lblCounter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlTraficLight";
            this.Size = new System.Drawing.Size(170, 283);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.PictureBox pbTrafficLight;
        private System.Windows.Forms.Timer Timer1;
    }
}
