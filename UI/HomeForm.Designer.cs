namespace UI
{
    partial class HomeForm
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
            ToCountriesFormButton = new Button();
            ToCitiesFormButton = new Button();
            SuspendLayout();
            // 
            // ToCountriesFormButton
            // 
            ToCountriesFormButton.Location = new Point(109, 103);
            ToCountriesFormButton.Name = "ToCountriesFormButton";
            ToCountriesFormButton.Size = new Size(260, 240);
            ToCountriesFormButton.TabIndex = 0;
            ToCountriesFormButton.Text = "Countries";
            ToCountriesFormButton.UseVisualStyleBackColor = true;
            ToCountriesFormButton.Click += ToCountriesFormButton_Click;
            // 
            // ToCitiesFormButton
            // 
            ToCitiesFormButton.Location = new Point(449, 103);
            ToCitiesFormButton.Name = "ToCitiesFormButton";
            ToCitiesFormButton.Size = new Size(260, 240);
            ToCitiesFormButton.TabIndex = 1;
            ToCitiesFormButton.Text = "Cities";
            ToCitiesFormButton.UseVisualStyleBackColor = true;
            ToCitiesFormButton.Click += ToCitiesFormButton_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ToCitiesFormButton);
            Controls.Add(ToCountriesFormButton);
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button ToCountriesFormButton;
        private Button ToCitiesFormButton;
    }
}