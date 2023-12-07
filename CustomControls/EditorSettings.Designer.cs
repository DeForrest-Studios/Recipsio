namespace Recipsio
{
    partial class EditorSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            FontSizeLabel = new System.Windows.Forms.Label();
            FontSizeControl = new System.Windows.Forms.NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FontSizeControl).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.833F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.167F));
            tableLayoutPanel1.Controls.Add(FontSizeLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(FontSizeControl, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(503, 466);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // FontSizeLabel
            // 
            FontSizeLabel.AutoSize = true;
            FontSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            FontSizeLabel.Location = new System.Drawing.Point(3, 0);
            FontSizeLabel.Name = "FontSizeLabel";
            FontSizeLabel.Size = new System.Drawing.Size(133, 30);
            FontSizeLabel.TabIndex = 0;
            FontSizeLabel.Text = "Application Font Size";
            FontSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FontSizeControl
            // 
            FontSizeControl.DecimalPlaces = 2;
            FontSizeControl.Location = new System.Drawing.Point(142, 3);
            FontSizeControl.Maximum = new decimal(new int[] { 13, 0, 0, 0 });
            FontSizeControl.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            FontSizeControl.Name = "FontSizeControl";
            FontSizeControl.Size = new System.Drawing.Size(52, 21);
            FontSizeControl.TabIndex = 3;
            FontSizeControl.Value = new decimal(new int[] { 5, 0, 0, 0 });
            FontSizeControl.ValueChanged += Font_Size_Changed;
            // 
            // EditorSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "EditorSettings";
            Size = new System.Drawing.Size(503, 466);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FontSizeControl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label FontSizeLabel;
        private System.Windows.Forms.NumericUpDown FontSizeControl;
    }
}
