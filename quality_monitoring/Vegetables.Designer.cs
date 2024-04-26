namespace RecommendedFertilizers
{
    partial class Vegetables
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
            this.buttontomato = new System.Windows.Forms.Button();
            this.buttoncucumber = new System.Windows.Forms.Button();
            this.buttoncarrot = new System.Windows.Forms.Button();
            this.buttonbeet = new System.Windows.Forms.Button();
            this.buttoncabbage = new System.Windows.Forms.Button();
            this.buttonzucchini = new System.Windows.Forms.Button();
            this.labelvegetables = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttontomato
            // 
            this.buttontomato.BackColor = System.Drawing.Color.LightGray;
            this.buttontomato.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttontomato.Location = new System.Drawing.Point(133, 239);
            this.buttontomato.Name = "buttontomato";
            this.buttontomato.Size = new System.Drawing.Size(260, 60);
            this.buttontomato.TabIndex = 0;
            this.buttontomato.Text = "Помидор";
            this.buttontomato.UseVisualStyleBackColor = false;
            this.buttontomato.Click += new System.EventHandler(this.buttonTomato_Click);
            // 
            // buttoncucumber
            // 
            this.buttoncucumber.BackColor = System.Drawing.Color.LightGray;
            this.buttoncucumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoncucumber.Location = new System.Drawing.Point(423, 239);
            this.buttoncucumber.Name = "buttoncucumber";
            this.buttoncucumber.Size = new System.Drawing.Size(260, 60);
            this.buttoncucumber.TabIndex = 1;
            this.buttoncucumber.Text = "Oгурец";
            this.buttoncucumber.UseVisualStyleBackColor = false;
            this.buttoncucumber.Click += new System.EventHandler(this.buttonCucumber_Click);
            // 
            // buttoncarrot
            // 
            this.buttoncarrot.BackColor = System.Drawing.Color.LightGray;
            this.buttoncarrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoncarrot.Location = new System.Drawing.Point(133, 339);
            this.buttoncarrot.Name = "buttoncarrot";
            this.buttoncarrot.Size = new System.Drawing.Size(260, 60);
            this.buttoncarrot.TabIndex = 2;
            this.buttoncarrot.Text = "Морковь";
            this.buttoncarrot.UseVisualStyleBackColor = false;
            this.buttoncarrot.Click += new System.EventHandler(this.buttoncarrot_Click);
            // 
            // buttonbeet
            // 
            this.buttonbeet.BackColor = System.Drawing.Color.LightGray;
            this.buttonbeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonbeet.Location = new System.Drawing.Point(423, 339);
            this.buttonbeet.Name = "buttonbeet";
            this.buttonbeet.Size = new System.Drawing.Size(260, 60);
            this.buttonbeet.TabIndex = 3;
            this.buttonbeet.Text = "Свёкла";
            this.buttonbeet.UseVisualStyleBackColor = false;
            this.buttonbeet.Click += new System.EventHandler(this.buttonbeet_Click);
            // 
            // buttoncabbage
            // 
            this.buttoncabbage.BackColor = System.Drawing.Color.LightGray;
            this.buttoncabbage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoncabbage.Location = new System.Drawing.Point(423, 139);
            this.buttoncabbage.Name = "buttoncabbage";
            this.buttoncabbage.Size = new System.Drawing.Size(260, 60);
            this.buttoncabbage.TabIndex = 4;
            this.buttoncabbage.Text = "Капуста";
            this.buttoncabbage.UseVisualStyleBackColor = false;
            this.buttoncabbage.Click += new System.EventHandler(this.buttoncabbage_Click);
            // 
            // buttonzucchini
            // 
            this.buttonzucchini.BackColor = System.Drawing.Color.LightGray;
            this.buttonzucchini.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonzucchini.Location = new System.Drawing.Point(133, 139);
            this.buttonzucchini.Name = "buttonzucchini";
            this.buttonzucchini.Size = new System.Drawing.Size(260, 60);
            this.buttonzucchini.TabIndex = 5;
            this.buttonzucchini.Text = "Кабачок";
            this.buttonzucchini.UseVisualStyleBackColor = false;
            this.buttonzucchini.Click += new System.EventHandler(this.buttonzucchini_Click);
            // 
            // labelvegetables
            // 
            this.labelvegetables.AutoSize = true;
            this.labelvegetables.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelvegetables.Location = new System.Drawing.Point(200, 45);
            this.labelvegetables.Name = "labelvegetables";
            this.labelvegetables.Size = new System.Drawing.Size(416, 54);
            this.labelvegetables.TabIndex = 6;
            this.labelvegetables.Text = "Культуры овощей";
            // 
            // Vegetables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelvegetables);
            this.Controls.Add(this.buttonzucchini);
            this.Controls.Add(this.buttoncabbage);
            this.Controls.Add(this.buttonbeet);
            this.Controls.Add(this.buttoncarrot);
            this.Controls.Add(this.buttoncucumber);
            this.Controls.Add(this.buttontomato);
            this.Name = "Vegetables";
            this.Text = "Vegetables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttontomato;
        private System.Windows.Forms.Button buttoncucumber;
        private System.Windows.Forms.Button buttoncarrot;
        private System.Windows.Forms.Button buttonbeet;
        private System.Windows.Forms.Button buttoncabbage;
        private System.Windows.Forms.Button buttonzucchini;
        private System.Windows.Forms.Label labelvegetables;
    }
}