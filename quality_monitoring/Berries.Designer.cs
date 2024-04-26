namespace RecommendedFertilizers
{
    partial class Berries
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
            this.labelberries = new System.Windows.Forms.Label();
            this.buttonstrawberry = new System.Windows.Forms.Button();
            this.buttongooseberry = new System.Windows.Forms.Button();
            this.buttonraspberry = new System.Windows.Forms.Button();
            this.buttonblackberry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelberries
            // 
            this.labelberries.AutoSize = true;
            this.labelberries.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelberries.Location = new System.Drawing.Point(236, 45);
            this.labelberries.Name = "labelberries";
            this.labelberries.Size = new System.Drawing.Size(344, 54);
            this.labelberries.TabIndex = 0;
            this.labelberries.Text = "Культуры ягод";
            // 
            // buttonstrawberry
            // 
            this.buttonstrawberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonstrawberry.Location = new System.Drawing.Point(133, 160);
            this.buttonstrawberry.Name = "buttonstrawberry";
            this.buttonstrawberry.Size = new System.Drawing.Size(260, 60);
            this.buttonstrawberry.TabIndex = 1;
            this.buttonstrawberry.Text = "Клубника";
            this.buttonstrawberry.UseVisualStyleBackColor = true;
            this.buttonstrawberry.Click += new System.EventHandler(this.buttonstrawberry_Click);
            // 
            // buttongooseberry
            // 
            this.buttongooseberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttongooseberry.Location = new System.Drawing.Point(133, 270);
            this.buttongooseberry.Name = "buttongooseberry";
            this.buttongooseberry.Size = new System.Drawing.Size(260, 60);
            this.buttongooseberry.TabIndex = 2;
            this.buttongooseberry.Text = "Крыжовник";
            this.buttongooseberry.UseVisualStyleBackColor = true;
            this.buttongooseberry.Click += new System.EventHandler(this.buttongooseberry_Click);
            // 
            // buttonraspberry
            // 
            this.buttonraspberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonraspberry.Location = new System.Drawing.Point(423, 160);
            this.buttonraspberry.Name = "buttonraspberry";
            this.buttonraspberry.Size = new System.Drawing.Size(260, 60);
            this.buttonraspberry.TabIndex = 3;
            this.buttonraspberry.Text = "Малина";
            this.buttonraspberry.UseVisualStyleBackColor = true;
            this.buttonraspberry.Click += new System.EventHandler(this.buttonraspberry_Click);
            // 
            // buttonblackberry
            // 
            this.buttonblackberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonblackberry.Location = new System.Drawing.Point(423, 270);
            this.buttonblackberry.Name = "buttonblackberry";
            this.buttonblackberry.Size = new System.Drawing.Size(260, 60);
            this.buttonblackberry.TabIndex = 4;
            this.buttonblackberry.Text = "Ежевика";
            this.buttonblackberry.UseVisualStyleBackColor = true;
            this.buttonblackberry.Click += new System.EventHandler(this.buttonblackberry_Click);
            // 
            // Berries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonblackberry);
            this.Controls.Add(this.buttonraspberry);
            this.Controls.Add(this.buttongooseberry);
            this.Controls.Add(this.buttonstrawberry);
            this.Controls.Add(this.labelberries);
            this.Name = "Berries";
            this.Text = "Berries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelberries;
        private System.Windows.Forms.Button buttonstrawberry;
        private System.Windows.Forms.Button buttongooseberry;
        private System.Windows.Forms.Button buttonraspberry;
        private System.Windows.Forms.Button buttonblackberry;
    }
}