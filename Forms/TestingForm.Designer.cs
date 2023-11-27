namespace Recipsio
{
    partial class TestingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestingForm));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            RecipeIngredients = new System.Windows.Forms.RichTextBox();
            DirectionsLabel = new System.Windows.Forms.Label();
            IngredientsLabel = new System.Windows.Forms.Label();
            RecipeDirections = new System.Windows.Forms.RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.7321424F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.26786F));
            tableLayoutPanel1.Controls.Add(RecipeIngredients, 1, 1);
            tableLayoutPanel1.Controls.Add(IngredientsLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(DirectionsLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(RecipeDirections, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(220, 137);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(448, 282);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // RecipeIngredients
            // 
            RecipeIngredients.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeIngredients.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RecipeIngredients.Location = new System.Drawing.Point(68, 144);
            RecipeIngredients.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            RecipeIngredients.Name = "RecipeIngredients";
            RecipeIngredients.Size = new System.Drawing.Size(378, 135);
            RecipeIngredients.TabIndex = 20;
            RecipeIngredients.Tag = "Ingredients";
            RecipeIngredients.Text = "";
            // 
            // DirectionsLabel
            // 
            DirectionsLabel.AutoSize = true;
            DirectionsLabel.Location = new System.Drawing.Point(2, 141);
            DirectionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            DirectionsLabel.Name = "DirectionsLabel";
            DirectionsLabel.Size = new System.Drawing.Size(58, 14);
            DirectionsLabel.TabIndex = 18;
            DirectionsLabel.Text = "&Directions:";
            // 
            // IngredientsLabel
            // 
            IngredientsLabel.AutoSize = true;
            IngredientsLabel.Location = new System.Drawing.Point(2, 0);
            IngredientsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            IngredientsLabel.Name = "IngredientsLabel";
            IngredientsLabel.Size = new System.Drawing.Size(60, 28);
            IngredientsLabel.TabIndex = 19;
            IngredientsLabel.Text = "&Ingredients:";
            // 
            // RecipeDirections
            // 
            RecipeDirections.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeDirections.Location = new System.Drawing.Point(68, 3);
            RecipeDirections.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            RecipeDirections.Name = "RecipeDirections";
            RecipeDirections.Size = new System.Drawing.Size(378, 135);
            RecipeDirections.TabIndex = 21;
            RecipeDirections.Tag = "Directions";
            RecipeDirections.Text = "";
            // 
            // TestingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(884, 811);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "TestingForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Untitled";
            KeyDown += Form_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.RichTextBox RecipeIngredients;
        public System.Windows.Forms.Label IngredientsLabel;
        public System.Windows.Forms.Label DirectionsLabel;
        public System.Windows.Forms.RichTextBox RecipeDirections;
    }
}