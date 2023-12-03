namespace Recipsio
{
    partial class ApplicationTagsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationTagsForm));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            TagInput = new System.Windows.Forms.RichTextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            AddTag = new System.Windows.Forms.Button();
            RemoveTag = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(TagInput, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(listBox1, 0, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.294117F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.70589F));
            tableLayoutPanel1.Size = new System.Drawing.Size(184, 361);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // TagInput
            // 
            TagInput.Dock = System.Windows.Forms.DockStyle.Fill;
            TagInput.Location = new System.Drawing.Point(3, 3);
            TagInput.Multiline = false;
            TagInput.Name = "TagInput";
            TagInput.Size = new System.Drawing.Size(178, 20);
            TagInput.TabIndex = 1;
            TagInput.Text = "";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            tableLayoutPanel2.Controls.Add(AddTag, 0, 0);
            tableLayoutPanel2.Controls.Add(RemoveTag, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 29);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(178, 28);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // AddTag
            // 
            AddTag.Dock = System.Windows.Forms.DockStyle.Fill;
            AddTag.Location = new System.Drawing.Point(3, 3);
            AddTag.Name = "AddTag";
            AddTag.Size = new System.Drawing.Size(59, 22);
            AddTag.TabIndex = 2;
            AddTag.Text = "Add";
            AddTag.UseVisualStyleBackColor = true;
            // 
            // RemoveTag
            // 
            RemoveTag.Dock = System.Windows.Forms.DockStyle.Fill;
            RemoveTag.Location = new System.Drawing.Point(68, 3);
            RemoveTag.Name = "RemoveTag";
            RemoveTag.Size = new System.Drawing.Size(107, 22);
            RemoveTag.TabIndex = 3;
            RemoveTag.Text = "Remove";
            RemoveTag.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 14;
            listBox1.Location = new System.Drawing.Point(3, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(178, 295);
            listBox1.TabIndex = 0;
            // 
            // TagsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(184, 361);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "TagsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            KeyDown += Form_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox TagInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AddTag;
        private System.Windows.Forms.Button RemoveTag;
        private System.Windows.Forms.ListBox listBox1;
    }
}