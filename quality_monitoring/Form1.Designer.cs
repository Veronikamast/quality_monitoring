namespace quality_monitoring
{
    partial class home_page
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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxCulture = new System.Windows.Forms.TextBox();
            this.comboBoxCulture = new System.Windows.Forms.ComboBox();
            this.buttonRecommendation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(27, 168);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(529, 39);
            this.comboBoxType.TabIndex = 0;
            // 
            // textBoxType
            // 
            this.textBoxType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxType.Location = new System.Drawing.Point(27, 115);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(314, 38);
            this.textBoxType.TabIndex = 1;
            this.textBoxType.Text = "Выберете вид растения:";
            this.textBoxType.Visible = false;
            // 
            // textBoxCulture
            // 
            this.textBoxCulture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCulture.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCulture.Location = new System.Drawing.Point(27, 244);
            this.textBoxCulture.Name = "textBoxCulture";
            this.textBoxCulture.ReadOnly = true;
            this.textBoxCulture.Size = new System.Drawing.Size(382, 38);
            this.textBoxCulture.TabIndex = 2;
            this.textBoxCulture.Text = "Выберете культуру растения:";
            this.textBoxCulture.Visible = false;
            // 
            // comboBoxCulture
            // 
            this.comboBoxCulture.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCulture.FormattingEnabled = true;
            this.comboBoxCulture.Location = new System.Drawing.Point(27, 301);
            this.comboBoxCulture.Name = "comboBoxCulture";
            this.comboBoxCulture.Size = new System.Drawing.Size(529, 39);
            this.comboBoxCulture.TabIndex = 3;
            // 
            // buttonRecommendation
            // 
            this.buttonRecommendation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRecommendation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRecommendation.Location = new System.Drawing.Point(482, 391);
            this.buttonRecommendation.Name = "buttonRecommendation";
            this.buttonRecommendation.Size = new System.Drawing.Size(306, 47);
            this.buttonRecommendation.TabIndex = 4;
            this.buttonRecommendation.Text = "Подобрать удобрение";
            this.buttonRecommendation.UseVisualStyleBackColor = false;
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRecommendation);
            this.Controls.Add(this.comboBoxCulture);
            this.Controls.Add(this.textBoxCulture);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.comboBoxType);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "home_page";
            this.Text = "home_page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxCulture;
        private System.Windows.Forms.ComboBox comboBoxCulture;
        private System.Windows.Forms.Button buttonRecommendation;
    }
}