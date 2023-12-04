namespace Recipsio
{
    partial class RecipeDirectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeDirectionForm));
            RecipeDirection = new System.Windows.Forms.RichTextBox();
            RecipeDirectionLayout = new System.Windows.Forms.TableLayoutPanel();
            SubmitRecipe = new System.Windows.Forms.Button();
            RecipeDirectionLayout.SuspendLayout();
            SuspendLayout();
            // 
            // RecipeDirection
            // 
            RecipeDirection.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeDirection.Location = new System.Drawing.Point(3, 3);
            RecipeDirection.Name = "RecipeDirection";
            RecipeDirection.Size = new System.Drawing.Size(337, 144);
            RecipeDirection.TabIndex = 1;
            RecipeDirection.Text = "";
            // 
            // RecipeDirectionLayout
            // 
            RecipeDirectionLayout.ColumnCount = 1;
            RecipeDirectionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            RecipeDirectionLayout.Controls.Add(RecipeDirection, 0, 0);
            RecipeDirectionLayout.Controls.Add(SubmitRecipe, 0, 1);
            RecipeDirectionLayout.Location = new System.Drawing.Point(0, 0);
            RecipeDirectionLayout.Name = "RecipeDirectionLayout";
            RecipeDirectionLayout.RowCount = 2;
            RecipeDirectionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.3333359F));
            RecipeDirectionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
            RecipeDirectionLayout.Size = new System.Drawing.Size(343, 181);
            RecipeDirectionLayout.TabIndex = 2;
            // 
            // SubmitRecipe
            // 
            SubmitRecipe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            SubmitRecipe.Location = new System.Drawing.Point(134, 155);
            SubmitRecipe.Name = "SubmitRecipe";
            SubmitRecipe.Size = new System.Drawing.Size(75, 23);
            SubmitRecipe.TabIndex = 2;
            SubmitRecipe.Text = "Submit";
            SubmitRecipe.UseVisualStyleBackColor = true;
            SubmitRecipe.Click += Submit_Recipe_Direction_Click;
            // 
            // RecipeDirectionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(343, 181);
            Controls.Add(RecipeDirectionLayout);
            Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "RecipeDirectionForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Description";
            KeyDown += Form_KeyDown;
            RecipeDirectionLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox RecipeDirection;
        private System.Windows.Forms.TableLayoutPanel RecipeDirectionLayout;
        private System.Windows.Forms.Button SubmitRecipe;
    }
}