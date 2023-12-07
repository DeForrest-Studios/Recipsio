namespace Recipsio
{
    partial class RecipeInformation
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
            RecipeHeaderLayout = new System.Windows.Forms.TableLayoutPanel();
            AuthorGroupBox = new System.Windows.Forms.GroupBox();
            RecipeAuthor = new System.Windows.Forms.RichTextBox();
            CookTime = new System.Windows.Forms.GroupBox();
            CookTimeLayout = new System.Windows.Forms.TableLayoutPanel();
            CookDays = new System.Windows.Forms.Label();
            CookMinutes = new System.Windows.Forms.Label();
            CookHours = new System.Windows.Forms.Label();
            TotalTime = new System.Windows.Forms.GroupBox();
            panel1 = new System.Windows.Forms.Panel();
            TotalTimeValue = new System.Windows.Forms.Label();
            NameGroupBox = new System.Windows.Forms.GroupBox();
            RecipeName = new System.Windows.Forms.RichTextBox();
            PrepTime = new System.Windows.Forms.GroupBox();
            PrepTimeLayout = new System.Windows.Forms.TableLayoutPanel();
            PrepHours = new System.Windows.Forms.Label();
            PrepMinutes = new System.Windows.Forms.Label();
            RecipeInformationLayout = new System.Windows.Forms.TableLayoutPanel();
            DescriptionLabel = new System.Windows.Forms.Label();
            RecipeDescription = new System.Windows.Forms.RichTextBox();
            IngredientControlsLayout = new System.Windows.Forms.TableLayoutPanel();
            IngredientsLabel = new System.Windows.Forms.Label();
            AddIngredient = new System.Windows.Forms.Button();
            RemoveIngredient = new System.Windows.Forms.Button();
            RecipeIngredients = new System.Windows.Forms.ListBox();
            RecipeDirections = new System.Windows.Forms.ListBox();
            DirectionsControlsLayout = new System.Windows.Forms.TableLayoutPanel();
            DirectionsLabel = new System.Windows.Forms.Label();
            AddDirection = new System.Windows.Forms.Button();
            RemoveDirection = new System.Windows.Forms.Button();
            RecipeHeaderLayout.SuspendLayout();
            AuthorGroupBox.SuspendLayout();
            CookTime.SuspendLayout();
            CookTimeLayout.SuspendLayout();
            TotalTime.SuspendLayout();
            panel1.SuspendLayout();
            NameGroupBox.SuspendLayout();
            PrepTimeLayout.SuspendLayout();
            RecipeInformationLayout.SuspendLayout();
            IngredientControlsLayout.SuspendLayout();
            DirectionsControlsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // RecipeHeaderLayout
            // 
            RecipeHeaderLayout.ColumnCount = 3;
            RecipeHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            RecipeHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            RecipeHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            RecipeHeaderLayout.Controls.Add(AuthorGroupBox, 2, 0);
            RecipeHeaderLayout.Controls.Add(CookTime, 1, 1);
            RecipeHeaderLayout.Controls.Add(TotalTime, 2, 1);
            RecipeHeaderLayout.Controls.Add(NameGroupBox, 0, 0);
            RecipeHeaderLayout.Location = new System.Drawing.Point(0, 0);
            RecipeHeaderLayout.Name = "RecipeHeaderLayout";
            RecipeHeaderLayout.RowCount = 2;
            RecipeHeaderLayout.Size = new System.Drawing.Size(200, 100);
            RecipeHeaderLayout.TabIndex = 0;
            // 
            // AuthorGroupBox
            // 
            AuthorGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            AuthorGroupBox.Controls.Add(RecipeAuthor);
            AuthorGroupBox.Location = new System.Drawing.Point(136, 3);
            AuthorGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AuthorGroupBox.Name = "AuthorGroupBox";
            AuthorGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AuthorGroupBox.Size = new System.Drawing.Size(60, 49);
            AuthorGroupBox.TabIndex = 22;
            AuthorGroupBox.TabStop = false;
            AuthorGroupBox.Text = "Author";
            // 
            // RecipeAuthor
            // 
            RecipeAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeAuthor.Location = new System.Drawing.Point(9, 16);
            RecipeAuthor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeAuthor.Name = "RecipeAuthor";
            RecipeAuthor.Size = new System.Drawing.Size(104, 0);
            RecipeAuthor.TabIndex = 0;
            RecipeAuthor.Tag = "Author";
            RecipeAuthor.Text = "";
            // 
            // CookTime
            // 
            CookTime.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            CookTime.Controls.Add(CookTimeLayout);
            CookTime.Location = new System.Drawing.Point(68, 58);
            CookTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            CookTime.Name = "CookTime";
            CookTime.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            CookTime.Size = new System.Drawing.Size(62, 41);
            CookTime.TabIndex = 19;
            CookTime.TabStop = false;
            CookTime.Tag = "Cook Time";
            CookTime.Text = "Cook Time";
            // 
            // CookTimeLayout
            // 
            CookTimeLayout.ColumnCount = 3;
            CookTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            CookTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            CookTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            CookTimeLayout.Controls.Add(CookDays, 0, 0);
            CookTimeLayout.Controls.Add(CookMinutes, 2, 0);
            CookTimeLayout.Controls.Add(CookHours, 1, 0);
            CookTimeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            CookTimeLayout.Location = new System.Drawing.Point(2, 19);
            CookTimeLayout.Name = "CookTimeLayout";
            CookTimeLayout.RowCount = 1;
            CookTimeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            CookTimeLayout.Size = new System.Drawing.Size(58, 19);
            CookTimeLayout.TabIndex = 2;
            // 
            // CookDays
            // 
            CookDays.Dock = System.Windows.Forms.DockStyle.Fill;
            CookDays.Location = new System.Drawing.Point(4, 0);
            CookDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CookDays.Name = "CookDays";
            CookDays.Size = new System.Drawing.Size(11, 19);
            CookDays.TabIndex = 6;
            CookDays.Tag = "Days";
            CookDays.Text = "0 Days";
            CookDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CookMinutes
            // 
            CookMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            CookMinutes.Location = new System.Drawing.Point(42, 0);
            CookMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CookMinutes.Name = "CookMinutes";
            CookMinutes.Size = new System.Drawing.Size(12, 19);
            CookMinutes.TabIndex = 8;
            CookMinutes.Tag = "Minutes";
            CookMinutes.Text = "0 Minutes";
            CookMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CookHours
            // 
            CookHours.Dock = System.Windows.Forms.DockStyle.Fill;
            CookHours.Location = new System.Drawing.Point(23, 0);
            CookHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CookHours.Name = "CookHours";
            CookHours.Size = new System.Drawing.Size(11, 19);
            CookHours.TabIndex = 7;
            CookHours.Tag = "Hours";
            CookHours.Text = "0 Hours";
            CookHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalTime
            // 
            TotalTime.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TotalTime.Controls.Add(panel1);
            TotalTime.Location = new System.Drawing.Point(136, 58);
            TotalTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TotalTime.Name = "TotalTime";
            TotalTime.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TotalTime.Size = new System.Drawing.Size(60, 41);
            TotalTime.TabIndex = 20;
            TotalTime.TabStop = false;
            TotalTime.Text = "Total Time";
            // 
            // panel1
            // 
            panel1.Controls.Add(TotalTimeValue);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(4, 19);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(52, 19);
            panel1.TabIndex = 2;
            // 
            // TotalTimeValue
            // 
            TotalTimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            TotalTimeValue.Location = new System.Drawing.Point(0, 0);
            TotalTimeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TotalTimeValue.Name = "TotalTimeValue";
            TotalTimeValue.Size = new System.Drawing.Size(52, 19);
            TotalTimeValue.TabIndex = 1;
            TotalTimeValue.Text = "0 Days 0 Hours 0 Minutes";
            TotalTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameGroupBox
            // 
            NameGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeHeaderLayout.SetColumnSpan(NameGroupBox, 2);
            NameGroupBox.Controls.Add(RecipeName);
            NameGroupBox.Location = new System.Drawing.Point(4, 3);
            NameGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NameGroupBox.Name = "NameGroupBox";
            NameGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NameGroupBox.Size = new System.Drawing.Size(124, 49);
            NameGroupBox.TabIndex = 2;
            NameGroupBox.TabStop = false;
            NameGroupBox.Text = "Name";
            // 
            // RecipeName
            // 
            RecipeName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeName.Location = new System.Drawing.Point(9, 16);
            RecipeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeName.Multiline = false;
            RecipeName.Name = "RecipeName";
            RecipeName.Size = new System.Drawing.Size(435, 0);
            RecipeName.TabIndex = 0;
            RecipeName.Tag = "Name";
            RecipeName.Text = "";
            // 
            // PrepTime
            // 
            PrepTime.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PrepTime.Location = new System.Drawing.Point(0, 0);
            PrepTime.Name = "PrepTime";
            PrepTime.Size = new System.Drawing.Size(200, 100);
            PrepTime.TabIndex = 0;
            PrepTime.TabStop = false;
            // 
            // PrepTimeLayout
            // 
            PrepTimeLayout.ColumnCount = 3;
            PrepTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            PrepTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            PrepTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            PrepTimeLayout.Controls.Add(PrepHours, 0, 0);
            PrepTimeLayout.Location = new System.Drawing.Point(0, 0);
            PrepTimeLayout.Name = "PrepTimeLayout";
            PrepTimeLayout.RowCount = 1;
            PrepTimeLayout.Size = new System.Drawing.Size(200, 100);
            PrepTimeLayout.TabIndex = 0;
            // 
            // PrepHours
            // 
            PrepHours.Dock = System.Windows.Forms.DockStyle.Fill;
            PrepHours.Location = new System.Drawing.Point(4, 0);
            PrepHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PrepHours.Name = "PrepHours";
            PrepHours.Size = new System.Drawing.Size(58, 100);
            PrepHours.TabIndex = 3;
            PrepHours.Tag = "Days";
            PrepHours.Text = "0 Hours";
            PrepHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrepMinutes
            // 
            PrepMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            PrepMinutes.Location = new System.Drawing.Point(70, 0);
            PrepMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PrepMinutes.Name = "PrepMinutes";
            PrepMinutes.Size = new System.Drawing.Size(80, 21);
            PrepMinutes.TabIndex = 4;
            PrepMinutes.Tag = "Hours";
            PrepMinutes.Text = "0 Minutes";
            PrepMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecipeInformationLayout
            // 
            RecipeInformationLayout.ColumnCount = 2;
            RecipeInformationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            RecipeInformationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            RecipeInformationLayout.Controls.Add(DescriptionLabel, 0, 0);
            RecipeInformationLayout.Controls.Add(RecipeDescription, 1, 0);
            RecipeInformationLayout.Controls.Add(IngredientControlsLayout, 0, 1);
            RecipeInformationLayout.Controls.Add(RecipeIngredients, 1, 1);
            RecipeInformationLayout.Controls.Add(RecipeDirections, 1, 2);
            RecipeInformationLayout.Controls.Add(DirectionsControlsLayout, 0, 2);
            RecipeInformationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeInformationLayout.Location = new System.Drawing.Point(0, 0);
            RecipeInformationLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeInformationLayout.Name = "RecipeInformationLayout";
            RecipeInformationLayout.RowCount = 3;
            RecipeInformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            RecipeInformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            RecipeInformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            RecipeInformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            RecipeInformationLayout.Size = new System.Drawing.Size(470, 406);
            RecipeInformationLayout.TabIndex = 1;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DescriptionLabel.Location = new System.Drawing.Point(2, 0);
            DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(88, 18);
            DescriptionLabel.TabIndex = 1;
            DescriptionLabel.Text = "&Description";
            // 
            // RecipeDescription
            // 
            RecipeDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeDescription.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RecipeDescription.Location = new System.Drawing.Point(97, 3);
            RecipeDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            RecipeDescription.Name = "RecipeDescription";
            RecipeDescription.Size = new System.Drawing.Size(371, 129);
            RecipeDescription.TabIndex = 17;
            RecipeDescription.Tag = "Description";
            RecipeDescription.Text = "";
            // 
            // IngredientControlsLayout
            // 
            IngredientControlsLayout.ColumnCount = 1;
            IngredientControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            IngredientControlsLayout.Controls.Add(IngredientsLabel, 0, 0);
            IngredientControlsLayout.Controls.Add(AddIngredient, 0, 1);
            IngredientControlsLayout.Controls.Add(RemoveIngredient, 0, 2);
            IngredientControlsLayout.Location = new System.Drawing.Point(0, 135);
            IngredientControlsLayout.Margin = new System.Windows.Forms.Padding(0);
            IngredientControlsLayout.Name = "IngredientControlsLayout";
            IngredientControlsLayout.RowCount = 3;
            IngredientControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            IngredientControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            IngredientControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            IngredientControlsLayout.Size = new System.Drawing.Size(95, 87);
            IngredientControlsLayout.TabIndex = 22;
            // 
            // IngredientsLabel
            // 
            IngredientsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            IngredientsLabel.Location = new System.Drawing.Point(2, 0);
            IngredientsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            IngredientsLabel.Name = "IngredientsLabel";
            IngredientsLabel.Size = new System.Drawing.Size(84, 18);
            IngredientsLabel.TabIndex = 19;
            IngredientsLabel.Text = "&Ingredients";
            // 
            // AddIngredient
            // 
            AddIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            AddIngredient.Location = new System.Drawing.Point(3, 32);
            AddIngredient.Name = "AddIngredient";
            AddIngredient.Size = new System.Drawing.Size(89, 23);
            AddIngredient.TabIndex = 20;
            AddIngredient.Text = "Add";
            AddIngredient.UseVisualStyleBackColor = true;
            AddIngredient.Click += Add_Recipe_Ingredient_Click;
            // 
            // RemoveIngredient
            // 
            RemoveIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            RemoveIngredient.Location = new System.Drawing.Point(3, 61);
            RemoveIngredient.Name = "RemoveIngredient";
            RemoveIngredient.Size = new System.Drawing.Size(89, 23);
            RemoveIngredient.TabIndex = 21;
            RemoveIngredient.Text = "Remove";
            RemoveIngredient.UseVisualStyleBackColor = true;
            RemoveIngredient.Click += Remove_Ingredient_Click;
            // 
            // RecipeIngredients
            // 
            RecipeIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeIngredients.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RecipeIngredients.FormattingEnabled = true;
            RecipeIngredients.ItemHeight = 15;
            RecipeIngredients.Location = new System.Drawing.Point(98, 138);
            RecipeIngredients.Name = "RecipeIngredients";
            RecipeIngredients.Size = new System.Drawing.Size(369, 129);
            RecipeIngredients.TabIndex = 23;
            RecipeIngredients.Tag = "Ingredients";
            // 
            // RecipeDirections
            // 
            RecipeDirections.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeDirections.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RecipeDirections.FormattingEnabled = true;
            RecipeDirections.ItemHeight = 15;
            RecipeDirections.Location = new System.Drawing.Point(98, 273);
            RecipeDirections.Name = "RecipeDirections";
            RecipeDirections.Size = new System.Drawing.Size(369, 130);
            RecipeDirections.TabIndex = 24;
            RecipeDirections.Tag = "Directions";
            // 
            // DirectionsControlsLayout
            // 
            DirectionsControlsLayout.ColumnCount = 1;
            DirectionsControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            DirectionsControlsLayout.Controls.Add(DirectionsLabel, 0, 0);
            DirectionsControlsLayout.Controls.Add(AddDirection, 0, 1);
            DirectionsControlsLayout.Controls.Add(RemoveDirection, 0, 2);
            DirectionsControlsLayout.Location = new System.Drawing.Point(3, 273);
            DirectionsControlsLayout.Name = "DirectionsControlsLayout";
            DirectionsControlsLayout.RowCount = 3;
            DirectionsControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            DirectionsControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            DirectionsControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            DirectionsControlsLayout.Size = new System.Drawing.Size(89, 87);
            DirectionsControlsLayout.TabIndex = 25;
            // 
            // DirectionsLabel
            // 
            DirectionsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DirectionsLabel.Location = new System.Drawing.Point(2, 0);
            DirectionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            DirectionsLabel.Name = "DirectionsLabel";
            DirectionsLabel.Size = new System.Drawing.Size(79, 18);
            DirectionsLabel.TabIndex = 18;
            DirectionsLabel.Text = "&Directions";
            // 
            // AddDirection
            // 
            AddDirection.Dock = System.Windows.Forms.DockStyle.Fill;
            AddDirection.Location = new System.Drawing.Point(3, 32);
            AddDirection.Name = "AddDirection";
            AddDirection.Size = new System.Drawing.Size(83, 23);
            AddDirection.TabIndex = 19;
            AddDirection.Text = "Add";
            AddDirection.UseVisualStyleBackColor = true;
            AddDirection.Click += Add_Recipe_Description_Click;
            // 
            // RemoveDirection
            // 
            RemoveDirection.Dock = System.Windows.Forms.DockStyle.Fill;
            RemoveDirection.Location = new System.Drawing.Point(3, 61);
            RemoveDirection.Name = "RemoveDirection";
            RemoveDirection.Size = new System.Drawing.Size(83, 23);
            RemoveDirection.TabIndex = 20;
            RemoveDirection.Text = "Remove";
            RemoveDirection.UseVisualStyleBackColor = true;
            RemoveDirection.Click += Remove_Recipe_Description_Click;
            // 
            // RecipeInformation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            Controls.Add(RecipeInformationLayout);
            Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "RecipeInformation";
            Size = new System.Drawing.Size(470, 406);
            RecipeHeaderLayout.ResumeLayout(false);
            AuthorGroupBox.ResumeLayout(false);
            CookTime.ResumeLayout(false);
            CookTimeLayout.ResumeLayout(false);
            TotalTime.ResumeLayout(false);
            panel1.ResumeLayout(false);
            NameGroupBox.ResumeLayout(false);
            PrepTimeLayout.ResumeLayout(false);
            RecipeInformationLayout.ResumeLayout(false);
            IngredientControlsLayout.ResumeLayout(false);
            DirectionsControlsLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel RecipeHeaderLayout;
        public System.Windows.Forms.GroupBox AuthorGroupBox;
        public System.Windows.Forms.RichTextBox RecipeAuthor;
        public System.Windows.Forms.GroupBox CookTime;
        public System.Windows.Forms.TableLayoutPanel CookTimeLayout;
        public System.Windows.Forms.Label CookDays;
        public System.Windows.Forms.Label CookMinutes;
        public System.Windows.Forms.Label CookHours;
        public System.Windows.Forms.GroupBox TotalTime;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label TotalTimeValue;
        public System.Windows.Forms.GroupBox NameGroupBox;
        public System.Windows.Forms.RichTextBox RecipeName;
        private System.Windows.Forms.GroupBox PrepTime;
        private System.Windows.Forms.TableLayoutPanel PrepTimeLayout;
        public System.Windows.Forms.Label PrepHours;
        public System.Windows.Forms.Label PrepMinutes;
        public System.Windows.Forms.TableLayoutPanel RecipeInformationLayout;
        public System.Windows.Forms.Label DescriptionLabel;
        public System.Windows.Forms.RichTextBox RecipeDescription;
        public System.Windows.Forms.TableLayoutPanel IngredientControlsLayout;
        public System.Windows.Forms.Label IngredientsLabel;
        public System.Windows.Forms.Button AddIngredient;
        public System.Windows.Forms.Button RemoveIngredient;
        public System.Windows.Forms.ListBox RecipeIngredients;
        public System.Windows.Forms.ListBox RecipeDirections;
        public System.Windows.Forms.TableLayoutPanel DirectionsControlsLayout;
        public System.Windows.Forms.Label DirectionsLabel;
        public System.Windows.Forms.Button AddDirection;
        public System.Windows.Forms.Button RemoveDirection;
    }
}
