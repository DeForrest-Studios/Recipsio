namespace Recipsio
{
    partial class ApplicationSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationSettingsForm));
            SettingsLayout = new System.Windows.Forms.TableLayoutPanel();
            ApplicationSettingsButton = new System.Windows.Forms.Button();
            EditorSettingsButton = new System.Windows.Forms.Button();
            SettingsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsLayout
            // 
            SettingsLayout.ColumnCount = 2;
            SettingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.9502258F));
            SettingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.0497742F));
            SettingsLayout.Controls.Add(ApplicationSettingsButton, 0, 0);
            SettingsLayout.Controls.Add(EditorSettingsButton, 0, 1);
            SettingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            SettingsLayout.Location = new System.Drawing.Point(0, 0);
            SettingsLayout.Name = "SettingsLayout";
            SettingsLayout.RowCount = 3;
            SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            SettingsLayout.Size = new System.Drawing.Size(884, 811);
            SettingsLayout.TabIndex = 0;
            // 
            // ApplicationSettingsButton
            // 
            ApplicationSettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            ApplicationSettingsButton.Location = new System.Drawing.Point(3, 3);
            ApplicationSettingsButton.Name = "ApplicationSettingsButton";
            ApplicationSettingsButton.Size = new System.Drawing.Size(135, 39);
            ApplicationSettingsButton.TabIndex = 0;
            ApplicationSettingsButton.Text = "Application";
            ApplicationSettingsButton.UseVisualStyleBackColor = true;
            ApplicationSettingsButton.Click += Load_Application_Settings;
            // 
            // EditorSettingsButton
            // 
            EditorSettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            EditorSettingsButton.Location = new System.Drawing.Point(3, 48);
            EditorSettingsButton.Name = "EditorSettingsButton";
            EditorSettingsButton.Size = new System.Drawing.Size(135, 39);
            EditorSettingsButton.TabIndex = 1;
            EditorSettingsButton.Text = "Editor";
            EditorSettingsButton.UseVisualStyleBackColor = true;
            EditorSettingsButton.Click += Load_Editor_Settings;
            // 
            // ApplicationSettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(884, 811);
            Controls.Add(SettingsLayout);
            Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ApplicationSettingsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Settings";
            KeyDown += Form_KeyDown;
            SettingsLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SettingsLayout;
        private System.Windows.Forms.Button ApplicationSettingsButton;
        private System.Windows.Forms.Button EditorSettingsButton;
    }
}