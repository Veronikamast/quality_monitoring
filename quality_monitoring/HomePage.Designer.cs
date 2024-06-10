namespace RecommendedFertilizers
{
    partial class HomePage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonvegetables = new System.Windows.Forms.Button();
            this.buttonfruits = new System.Windows.Forms.Button();
            this.buttonberries = new System.Windows.Forms.Button();
            this.labelplant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonvegetables
            // 
            this.buttonvegetables.BackColor = System.Drawing.Color.LightGray;
            this.buttonvegetables.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonvegetables.Location = new System.Drawing.Point(278, 139);
            this.buttonvegetables.Name = "buttonvegetables";
            this.buttonvegetables.Size = new System.Drawing.Size(260, 60);
            this.buttonvegetables.TabIndex = 0;
            this.buttonvegetables.Text = "Овощи";
            this.buttonvegetables.UseVisualStyleBackColor = false;
            this.buttonvegetables.Click += new System.EventHandler(this.buttonvegetables_Click);
            // 
            // buttonfruits
            // 
            this.buttonfruits.BackColor = System.Drawing.Color.LightGray;
            this.buttonfruits.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonfruits.Location = new System.Drawing.Point(278, 239);
            this.buttonfruits.Name = "buttonfruits";
            this.buttonfruits.Size = new System.Drawing.Size(260, 60);
            this.buttonfruits.TabIndex = 1;
            this.buttonfruits.Text = "Фрукты";
            this.buttonfruits.UseVisualStyleBackColor = false;
            this.buttonfruits.Click += new System.EventHandler(this.buttonfruits_Click);
            // 
            // buttonberries
            // 
            this.buttonberries.BackColor = System.Drawing.Color.LightGray;
            this.buttonberries.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonberries.Location = new System.Drawing.Point(278, 339);
            this.buttonberries.Name = "buttonberries";
            this.buttonberries.Size = new System.Drawing.Size(260, 60);
            this.buttonberries.TabIndex = 2;
            this.buttonberries.Text = "Ягоды";
            this.buttonberries.UseVisualStyleBackColor = false;
            this.buttonberries.Click += new System.EventHandler(this.buttonberries_Click);
            // 
            // labelplant
            // 
            this.labelplant.AutoSize = true;
            this.labelplant.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelplant.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelplant.Location = new System.Drawing.Point(231, 45);
            this.labelplant.Name = "labelplant";
            this.labelplant.Size = new System.Drawing.Size(355, 54);
            this.labelplant.TabIndex = 3;
            this.labelplant.Text = "Виды растений";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelplant);
            this.Controls.Add(this.buttonberries);
            this.Controls.Add(this.buttonfruits);
            this.Controls.Add(this.buttonvegetables);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonvegetables;
        private System.Windows.Forms.Button buttonfruits;
        private System.Windows.Forms.Button buttonberries;
        private System.Windows.Forms.Label labelplant;
    }
}

