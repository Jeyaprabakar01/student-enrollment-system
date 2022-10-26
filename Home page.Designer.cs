namespace Ditec
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnfacilities = new System.Windows.Forms.Button();
            this.btnupcomingevents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfacilities
            // 
            this.btnfacilities.BackColor = System.Drawing.Color.Plum;
            this.btnfacilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacilities.Location = new System.Drawing.Point(287, 195);
            this.btnfacilities.Name = "btnfacilities";
            this.btnfacilities.Size = new System.Drawing.Size(152, 55);
            this.btnfacilities.TabIndex = 0;
            this.btnfacilities.Text = "FACILITIES";
            this.btnfacilities.UseVisualStyleBackColor = false;
            this.btnfacilities.Click += new System.EventHandler(this.btnfacilities_Click);
            // 
            // btnupcomingevents
            // 
            this.btnupcomingevents.BackColor = System.Drawing.Color.Plum;
            this.btnupcomingevents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupcomingevents.Location = new System.Drawing.Point(241, 287);
            this.btnupcomingevents.Name = "btnupcomingevents";
            this.btnupcomingevents.Size = new System.Drawing.Size(245, 57);
            this.btnupcomingevents.TabIndex = 1;
            this.btnupcomingevents.Text = "UPCOMING EVENTS";
            this.btnupcomingevents.UseVisualStyleBackColor = false;
            this.btnupcomingevents.Click += new System.EventHandler(this.btnupcomingevents_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 442);
            this.Controls.Add(this.btnupcomingevents);
            this.Controls.Add(this.btnfacilities);
            this.Name = "Form2";
            this.Text = "Home Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfacilities;
        private System.Windows.Forms.Button btnupcomingevents;
    }
}