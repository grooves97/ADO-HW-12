namespace CityPhone
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewNumbers = new System.Windows.Forms.DataGridView();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNumbers
            // 
            this.dataGridViewNumbers.AllowUserToAddRows = false;
            this.dataGridViewNumbers.AllowUserToDeleteRows = false;
            this.dataGridViewNumbers.AllowUserToResizeColumns = false;
            this.dataGridViewNumbers.AllowUserToResizeRows = false;
            this.dataGridViewNumbers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumbers.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewNumbers.Name = "dataGridViewNumbers";
            this.dataGridViewNumbers.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewNumbers.TabIndex = 0;
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCities.Location = new System.Drawing.Point(419, 63);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCities.TabIndex = 1;
            this.comboBoxCities.Tag = "Cities";
            this.comboBoxCities.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCities_SelectedIndexChanged);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(428, 126);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxCode.TabIndex = 2;
            this.textBoxCode.Text = "XXXX";
            this.textBoxCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(428, 193);
            this.maskedTextBoxNumber.Mask = "00-00-00";
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxNumber.TabIndex = 3;
            this.maskedTextBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(428, 283);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add Number";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 416);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.maskedTextBoxNumber);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.comboBoxCities);
            this.Controls.Add(this.dataGridViewNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNumbers;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Button buttonAdd;
    }
}

