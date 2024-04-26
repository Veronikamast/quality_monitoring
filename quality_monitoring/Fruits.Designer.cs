namespace RecommendedFertilizers
{
    partial class Fruits
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
            this.labelfruits = new System.Windows.Forms.Label();
            this.buttonpear = new System.Windows.Forms.Button();
            this.buttonplum = new System.Windows.Forms.Button();
            this.buttonapple = new System.Windows.Forms.Button();
            this.buttonapricot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelfruits
            // 
            this.labelfruits.AutoSize = true;
            this.labelfruits.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfruits.Location = new System.Drawing.Point(191, 45);
            this.labelfruits.Name = "labelfruits";
            this.labelfruits.Size = new System.Drawing.Size(434, 54);
            this.labelfruits.TabIndex = 0;
            this.labelfruits.Text = "Культуры фруктов";
            // 
            // buttonpear
            // 
            this.buttonpear.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonpear.Location = new System.Drawing.Point(133, 160);
            this.buttonpear.Name = "buttonpear";
            this.buttonpear.Size = new System.Drawing.Size(260, 60);
            this.buttonpear.TabIndex = 1;
            this.buttonpear.Text = "Груша";
            this.buttonpear.UseVisualStyleBackColor = true;
            this.buttonpear.Click += new System.EventHandler(this.buttonpear_Click);
            // 
            // buttonplum
            // 
            this.buttonplum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonplum.Location = new System.Drawing.Point(423, 160);
            this.buttonplum.Name = "buttonplum";
            this.buttonplum.Size = new System.Drawing.Size(260, 60);
            this.buttonplum.TabIndex = 2;
            this.buttonplum.Text = "Слива";
            this.buttonplum.UseVisualStyleBackColor = true;
            this.buttonplum.Click += new System.EventHandler(this.buttonplum_Click);
            // 
            // buttonapple
            // 
            this.buttonapple.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonapple.Location = new System.Drawing.Point(133, 270);
            this.buttonapple.Name = "buttonapple";
            this.buttonapple.Size = new System.Drawing.Size(260, 60);
            this.buttonapple.TabIndex = 3;
            this.buttonapple.Text = "Яблоко";
            this.buttonapple.UseVisualStyleBackColor = true;
            this.buttonapple.Click += new System.EventHandler(this.buttonapple_Click);
            // 
            // buttonapricot
            // 
            this.buttonapricot.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonapricot.Location = new System.Drawing.Point(423, 270);
            this.buttonapricot.Name = "buttonapricot";
            this.buttonapricot.Size = new System.Drawing.Size(260, 60);
            this.buttonapricot.TabIndex = 4;
            this.buttonapricot.Text = "Абрикос";
            this.buttonapricot.UseVisualStyleBackColor = true;
            this.buttonapricot.Click += new System.EventHandler(this.buttonapricot_Click);
            // 
            // Fruits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonapricot);
            this.Controls.Add(this.buttonapple);
            this.Controls.Add(this.buttonplum);
            this.Controls.Add(this.buttonpear);
            this.Controls.Add(this.labelfruits);
            this.Name = "Fruits";
            this.Text = "Fruits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelfruits;
        private System.Windows.Forms.Button buttonpear;
        private System.Windows.Forms.Button buttonplum;
        private System.Windows.Forms.Button buttonapple;
        private System.Windows.Forms.Button buttonapricot;
    }
}