namespace UI
{
    partial class CityEditForm
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
            CityNameLabel = new Label();
            CityNameInput = new TextBox();
            CountryIdLabel = new Label();
            CitySaveButton = new Button();
            CountriesDropdownList = new ComboBox();
            SuspendLayout();
            // 
            // CityNameLabel
            // 
            CityNameLabel.AutoSize = true;
            CityNameLabel.Location = new Point(113, 163);
            CityNameLabel.Name = "CityNameLabel";
            CityNameLabel.Size = new Size(49, 20);
            CityNameLabel.TabIndex = 0;
            CityNameLabel.Text = "Name";
            // 
            // CityNameInput
            // 
            CityNameInput.Location = new Point(231, 156);
            CityNameInput.Name = "CityNameInput";
            CityNameInput.Size = new Size(322, 27);
            CityNameInput.TabIndex = 1;
            // 
            // CountryIdLabel
            // 
            CountryIdLabel.AutoSize = true;
            CountryIdLabel.Location = new Point(112, 219);
            CountryIdLabel.Name = "CountryIdLabel";
            CountryIdLabel.Size = new Size(60, 20);
            CountryIdLabel.TabIndex = 3;
            CountryIdLabel.Text = "Country";
            // 
            // CitySaveButton
            // 
            CitySaveButton.Location = new Point(330, 361);
            CitySaveButton.Name = "CitySaveButton";
            CitySaveButton.Size = new Size(94, 29);
            CitySaveButton.TabIndex = 4;
            CitySaveButton.Text = "Save";
            CitySaveButton.UseVisualStyleBackColor = true;
            CitySaveButton.Click += CitySaveButton_Click;
            // 
            // CountriesDropdownList
            // 
            CountriesDropdownList.FormattingEnabled = true;
            CountriesDropdownList.Location = new Point(231, 223);
            CountriesDropdownList.Name = "CountriesDropdownList";
            CountriesDropdownList.Size = new Size(322, 28);
            CountriesDropdownList.TabIndex = 5;
            // 
            // CityEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CountriesDropdownList);
            Controls.Add(CitySaveButton);
            Controls.Add(CountryIdLabel);
            Controls.Add(CityNameInput);
            Controls.Add(CityNameLabel);
            Name = "CityEditForm";
            Text = "CityEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CityNameLabel;
        private TextBox CityNameInput;
        private Label CountryIdLabel;
        private Button CitySaveButton;
        private ComboBox CountriesDropdownList;
    }
}