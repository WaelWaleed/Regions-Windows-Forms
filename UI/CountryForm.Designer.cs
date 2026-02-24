namespace UI
{
    partial class CountryForm
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
            dgvCountries = new DataGridView();
            CreateCountryButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCountries).BeginInit();
            SuspendLayout();
            // 
            // dgvCountries
            // 
            dgvCountries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCountries.Location = new Point(0, 51);
            dgvCountries.Name = "dgvCountries";
            dgvCountries.RowHeadersWidth = 51;
            dgvCountries.Size = new Size(800, 399);
            dgvCountries.TabIndex = 0;
            // 
            // CreateCountryButton
            // 
            CreateCountryButton.Location = new Point(12, 12);
            CreateCountryButton.Name = "CreateCountryButton";
            CreateCountryButton.Size = new Size(128, 33);
            CreateCountryButton.TabIndex = 1;
            CreateCountryButton.Text = "Create";
            CreateCountryButton.UseVisualStyleBackColor = true;
            CreateCountryButton.Click += CreateCountryButton_Click;
            // 
            // CountryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateCountryButton);
            Controls.Add(dgvCountries);
            Name = "CountryForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCountries).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCountries;
        private Button CreateCountryButton;
    }
}