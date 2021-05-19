
namespace Maths_Problems
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
            this.BtnVolumeOfRectangle = new System.Windows.Forms.Button();
            this.BtnPricePerPound = new System.Windows.Forms.Button();
            this.BtnCarpetArea = new System.Windows.Forms.Button();
            this.BtnMarkupCalculator = new System.Windows.Forms.Button();
            this.BtnCommisionCalculator = new System.Windows.Forms.Button();
            this.BtnEmployeeTaxCalculator = new System.Windows.Forms.Button();
            this.BtnWineCalculator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVolumeOfRectangle
            // 
            this.BtnVolumeOfRectangle.Location = new System.Drawing.Point(12, 12);
            this.BtnVolumeOfRectangle.Name = "BtnVolumeOfRectangle";
            this.BtnVolumeOfRectangle.Size = new System.Drawing.Size(195, 43);
            this.BtnVolumeOfRectangle.TabIndex = 0;
            this.BtnVolumeOfRectangle.Text = "Volume of Rectangle";
            this.BtnVolumeOfRectangle.UseVisualStyleBackColor = true;
            this.BtnVolumeOfRectangle.Click += new System.EventHandler(this.BtnVolumeOfRectangle_Click);
            // 
            // BtnPricePerPound
            // 
            this.BtnPricePerPound.Location = new System.Drawing.Point(12, 61);
            this.BtnPricePerPound.Name = "BtnPricePerPound";
            this.BtnPricePerPound.Size = new System.Drawing.Size(195, 43);
            this.BtnPricePerPound.TabIndex = 1;
            this.BtnPricePerPound.Text = "Price per Pound";
            this.BtnPricePerPound.UseVisualStyleBackColor = true;
            this.BtnPricePerPound.Click += new System.EventHandler(this.BtnPricePerPound_Click);
            // 
            // BtnCarpetArea
            // 
            this.BtnCarpetArea.Location = new System.Drawing.Point(12, 110);
            this.BtnCarpetArea.Name = "BtnCarpetArea";
            this.BtnCarpetArea.Size = new System.Drawing.Size(195, 43);
            this.BtnCarpetArea.TabIndex = 2;
            this.BtnCarpetArea.Text = "Carpet Area";
            this.BtnCarpetArea.UseVisualStyleBackColor = true;
            this.BtnCarpetArea.Click += new System.EventHandler(this.BtnCarpetArea_Click);
            // 
            // BtnMarkupCalculator
            // 
            this.BtnMarkupCalculator.Location = new System.Drawing.Point(12, 159);
            this.BtnMarkupCalculator.Name = "BtnMarkupCalculator";
            this.BtnMarkupCalculator.Size = new System.Drawing.Size(195, 43);
            this.BtnMarkupCalculator.TabIndex = 3;
            this.BtnMarkupCalculator.Text = "Markup Calculator";
            this.BtnMarkupCalculator.UseVisualStyleBackColor = true;
            this.BtnMarkupCalculator.Click += new System.EventHandler(this.BtnMarkupCalculator_Click);
            // 
            // BtnCommisionCalculator
            // 
            this.BtnCommisionCalculator.Location = new System.Drawing.Point(12, 208);
            this.BtnCommisionCalculator.Name = "BtnCommisionCalculator";
            this.BtnCommisionCalculator.Size = new System.Drawing.Size(195, 43);
            this.BtnCommisionCalculator.TabIndex = 4;
            this.BtnCommisionCalculator.Text = "Commission Calculator";
            this.BtnCommisionCalculator.UseVisualStyleBackColor = true;
            this.BtnCommisionCalculator.Click += new System.EventHandler(this.BtnCommisionCalculator_Click);
            // 
            // BtnEmployeeTaxCalculator
            // 
            this.BtnEmployeeTaxCalculator.Location = new System.Drawing.Point(12, 257);
            this.BtnEmployeeTaxCalculator.Name = "BtnEmployeeTaxCalculator";
            this.BtnEmployeeTaxCalculator.Size = new System.Drawing.Size(195, 43);
            this.BtnEmployeeTaxCalculator.TabIndex = 5;
            this.BtnEmployeeTaxCalculator.Text = "Calculate Tax";
            this.BtnEmployeeTaxCalculator.UseVisualStyleBackColor = true;
            this.BtnEmployeeTaxCalculator.Click += new System.EventHandler(this.BtnEmployeeTaxCalculator_Click);
            // 
            // BtnWineCalculator
            // 
            this.BtnWineCalculator.Location = new System.Drawing.Point(12, 306);
            this.BtnWineCalculator.Name = "BtnWineCalculator";
            this.BtnWineCalculator.Size = new System.Drawing.Size(195, 43);
            this.BtnWineCalculator.TabIndex = 6;
            this.BtnWineCalculator.Text = "Wine Calculator";
            this.BtnWineCalculator.UseVisualStyleBackColor = true;
            this.BtnWineCalculator.Click += new System.EventHandler(this.BtnWineCalculator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 363);
            this.Controls.Add(this.BtnWineCalculator);
            this.Controls.Add(this.BtnEmployeeTaxCalculator);
            this.Controls.Add(this.BtnCommisionCalculator);
            this.Controls.Add(this.BtnMarkupCalculator);
            this.Controls.Add(this.BtnCarpetArea);
            this.Controls.Add(this.BtnPricePerPound);
            this.Controls.Add(this.BtnVolumeOfRectangle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVolumeOfRectangle;
        private System.Windows.Forms.Button BtnPricePerPound;
        private System.Windows.Forms.Button BtnCarpetArea;
        private System.Windows.Forms.Button BtnMarkupCalculator;
        private System.Windows.Forms.Button BtnCommisionCalculator;
        private System.Windows.Forms.Button BtnEmployeeTaxCalculator;
        private System.Windows.Forms.Button BtnWineCalculator;
    }
}

