namespace UI
{
    partial class CityForm
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
            dgvCities = new DataGridView();
            CreateCityButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCities).BeginInit();
            SuspendLayout();
            // 
            // dgvCities
            // 
            dgvCities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCities.Location = new Point(0, 51);
            dgvCities.Name = "dgvCities";
            dgvCities.RowHeadersWidth = 51;
            dgvCities.Size = new Size(800, 399);
            dgvCities.TabIndex = 0;
            // 
            // CreateCityButton
            // 
            CreateCityButton.Location = new Point(12, 12);
            CreateCityButton.Name = "CreateCityButton";
            CreateCityButton.Size = new Size(117, 29);
            CreateCityButton.TabIndex = 1;
            CreateCityButton.Text = "Create";
            CreateCityButton.UseVisualStyleBackColor = true;
            CreateCityButton.Click += CreateCityButton_Click;
            // 
            // CityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateCityButton);
            Controls.Add(dgvCities);
            Name = "CityForm";
            Text = "CityForm";
            ((System.ComponentModel.ISupportInitialize)dgvCities).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCities;
        private Button CreateCityButton;
    }
}