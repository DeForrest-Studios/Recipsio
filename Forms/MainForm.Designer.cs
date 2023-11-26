namespace RecipeManager
{
    partial class MainForm
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
        /// Required method for Designer s/upport - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            RecipeList = new System.Windows.Forms.ListBox();
            msOptions = new System.Windows.Forms.MenuStrip();
            Options = new System.Windows.Forms.ToolStripMenuItem();
            CreateNew = new System.Windows.Forms.ToolStripMenuItem();
            Save = new System.Windows.Forms.ToolStripMenuItem();
            Delete = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ingredientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Help = new System.Windows.Forms.ToolStripMenuItem();
            ContentGroupBox = new System.Windows.Forms.GroupBox();
            RecipeDirections = new System.Windows.Forms.RichTextBox();
            DirectionsLabel = new System.Windows.Forms.Label();
            IngredientsLabel = new System.Windows.Forms.Label();
            DescriptionLabel = new System.Windows.Forms.Label();
            RecipeIngredients = new System.Windows.Forms.RichTextBox();
            RecipeDescription = new System.Windows.Forms.RichTextBox();
            TotalTimeBox = new System.Windows.Forms.GroupBox();
            TotalTime = new System.Windows.Forms.Label();
            NameGroupBox = new System.Windows.Forms.GroupBox();
            RecipeName = new System.Windows.Forms.RichTextBox();
            AuthorGroupBox = new System.Windows.Forms.GroupBox();
            RecipeAuthor = new System.Windows.Forms.RichTextBox();
            PrepTimeGroup = new System.Windows.Forms.GroupBox();
            PrepDays = new System.Windows.Forms.Label();
            PrepHours = new System.Windows.Forms.Label();
            PrepMinutes = new System.Windows.Forms.Label();
            CookTimeGroup = new System.Windows.Forms.GroupBox();
            CookDays = new System.Windows.Forms.Label();
            CookHours = new System.Windows.Forms.Label();
            CookMinutes = new System.Windows.Forms.Label();
            Search = new System.Windows.Forms.RichTextBox();
            msOptions.SuspendLayout();
            ContentGroupBox.SuspendLayout();
            TotalTimeBox.SuspendLayout();
            NameGroupBox.SuspendLayout();
            AuthorGroupBox.SuspendLayout();
            PrepTimeGroup.SuspendLayout();
            CookTimeGroup.SuspendLayout();
            SuspendLayout();
            // 
            // RecipeList
            // 
            RecipeList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            RecipeList.ForeColor = System.Drawing.SystemColors.WindowText;
            RecipeList.FormattingEnabled = true;
            RecipeList.ItemHeight = 14;
            RecipeList.Location = new System.Drawing.Point(10, 69);
            RecipeList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            RecipeList.Name = "RecipeList";
            RecipeList.Size = new System.Drawing.Size(154, 718);
            RecipeList.TabIndex = 0;
            RecipeList.TabStop = false;
            RecipeList.SelectedValueChanged += RecipeList_SelectedValueChanged;
            // 
            // msOptions
            // 
            msOptions.AutoSize = false;
            msOptions.BackColor = System.Drawing.Color.OldLace;
            msOptions.Dock = System.Windows.Forms.DockStyle.None;
            msOptions.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            msOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { Options });
            msOptions.Location = new System.Drawing.Point(10, 9);
            msOptions.Name = "msOptions";
            msOptions.Size = new System.Drawing.Size(70, 26);
            msOptions.TabIndex = 0;
            msOptions.Text = "menuStrip1";
            // 
            // Options
            // 
            Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { CreateNew, Save, Delete, toolStripSeparator2, imageToolStripMenuItem, tagsToolStripMenuItem, toolStripSeparator1, ingredientsToolStripMenuItem, settingsToolStripMenuItem, Help });
            Options.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Options.Name = "Options";
            Options.Size = new System.Drawing.Size(56, 22);
            Options.Text = "Options";
            // 
            // CreateNew
            // 
            CreateNew.Name = "CreateNew";
            CreateNew.Size = new System.Drawing.Size(180, 22);
            CreateNew.Text = "Create New";
            CreateNew.Click += CreateNew_Click;
            // 
            // Save
            // 
            Save.Name = "Save";
            Save.Size = new System.Drawing.Size(180, 22);
            Save.Text = "Save";
            Save.Click += Save_Click;
            // 
            // Delete
            // 
            Delete.Name = "Delete";
            Delete.Size = new System.Drawing.Size(180, 22);
            Delete.Text = "Delete";
            Delete.Click += Delete_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            imageToolStripMenuItem.Text = "Images";
            imageToolStripMenuItem.Click += Options_Click;
            // 
            // tagsToolStripMenuItem
            // 
            tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            tagsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            tagsToolStripMenuItem.Text = "Tags";
            tagsToolStripMenuItem.Click += Options_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ingredientsToolStripMenuItem
            // 
            ingredientsToolStripMenuItem.Name = "ingredientsToolStripMenuItem";
            ingredientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            ingredientsToolStripMenuItem.Text = "Ingredients";
            ingredientsToolStripMenuItem.Click += Options_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += Options_Click;
            // 
            // Help
            // 
            Help.Name = "Help";
            Help.Size = new System.Drawing.Size(180, 22);
            Help.Text = "Help";
            Help.Click += Options_Click;
            // 
            // ContentGroupBox
            // 
            ContentGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ContentGroupBox.Controls.Add(RecipeDirections);
            ContentGroupBox.Controls.Add(DirectionsLabel);
            ContentGroupBox.Controls.Add(IngredientsLabel);
            ContentGroupBox.Controls.Add(DescriptionLabel);
            ContentGroupBox.Controls.Add(RecipeIngredients);
            ContentGroupBox.Controls.Add(RecipeDescription);
            ContentGroupBox.Location = new System.Drawing.Point(172, 110);
            ContentGroupBox.Name = "ContentGroupBox";
            ContentGroupBox.Size = new System.Drawing.Size(700, 677);
            ContentGroupBox.TabIndex = 13;
            ContentGroupBox.TabStop = false;
            // 
            // RecipeDirections
            // 
            RecipeDirections.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeDirections.Location = new System.Drawing.Point(95, 475);
            RecipeDirections.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            RecipeDirections.Name = "RecipeDirections";
            RecipeDirections.Size = new System.Drawing.Size(600, 196);
            RecipeDirections.TabIndex = 17;
            RecipeDirections.Tag = "Directions";
            RecipeDirections.Text = "";
            RecipeDirections.KeyDown += RichText_KeyDown;
            // 
            // DirectionsLabel
            // 
            DirectionsLabel.AutoSize = true;
            DirectionsLabel.Location = new System.Drawing.Point(33, 475);
            DirectionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            DirectionsLabel.Name = "DirectionsLabel";
            DirectionsLabel.Size = new System.Drawing.Size(58, 14);
            DirectionsLabel.TabIndex = 12;
            DirectionsLabel.Text = "&Directions:";
            // 
            // IngredientsLabel
            // 
            IngredientsLabel.AutoSize = true;
            IngredientsLabel.Location = new System.Drawing.Point(28, 247);
            IngredientsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            IngredientsLabel.Name = "IngredientsLabel";
            IngredientsLabel.Size = new System.Drawing.Size(63, 14);
            IngredientsLabel.TabIndex = 13;
            IngredientsLabel.Text = "&Ingredients:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new System.Drawing.Point(28, 19);
            DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(64, 14);
            DescriptionLabel.TabIndex = 14;
            DescriptionLabel.Text = "&Description:";
            // 
            // RecipeIngredients
            // 
            RecipeIngredients.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeIngredients.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RecipeIngredients.Location = new System.Drawing.Point(95, 247);
            RecipeIngredients.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            RecipeIngredients.Name = "RecipeIngredients";
            RecipeIngredients.Size = new System.Drawing.Size(600, 196);
            RecipeIngredients.TabIndex = 16;
            RecipeIngredients.Tag = "Ingredients";
            RecipeIngredients.Text = "";
            RecipeIngredients.KeyDown += RichText_KeyDown;
            // 
            // RecipeDescription
            // 
            RecipeDescription.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeDescription.Location = new System.Drawing.Point(95, 19);
            RecipeDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            RecipeDescription.Name = "RecipeDescription";
            RecipeDescription.Size = new System.Drawing.Size(600, 196);
            RecipeDescription.TabIndex = 15;
            RecipeDescription.Tag = "Description";
            RecipeDescription.Text = "";
            // 
            // TotalTimeBox
            // 
            TotalTimeBox.Controls.Add(TotalTime);
            TotalTimeBox.Location = new System.Drawing.Point(685, 69);
            TotalTimeBox.Name = "TotalTimeBox";
            TotalTimeBox.Size = new System.Drawing.Size(186, 35);
            TotalTimeBox.TabIndex = 14;
            TotalTimeBox.TabStop = false;
            TotalTimeBox.Text = "Total Time";
            // 
            // TotalTime
            // 
            TotalTime.AutoSize = true;
            TotalTime.Location = new System.Drawing.Point(6, 16);
            TotalTime.Name = "TotalTime";
            TotalTime.Size = new System.Drawing.Size(0, 14);
            TotalTime.TabIndex = 0;
            // 
            // NameGroupBox
            // 
            NameGroupBox.Controls.Add(RecipeName);
            NameGroupBox.Location = new System.Drawing.Point(181, 9);
            NameGroupBox.Name = "NameGroupBox";
            NameGroupBox.Size = new System.Drawing.Size(471, 52);
            NameGroupBox.TabIndex = 15;
            NameGroupBox.TabStop = false;
            NameGroupBox.Text = "Name";
            // 
            // RecipeName
            // 
            RecipeName.Location = new System.Drawing.Point(6, 19);
            RecipeName.Multiline = false;
            RecipeName.Name = "RecipeName";
            RecipeName.Size = new System.Drawing.Size(459, 20);
            RecipeName.TabIndex = 20;
            RecipeName.Tag = "Name";
            RecipeName.Text = "";
            // 
            // AuthorGroupBox
            // 
            AuthorGroupBox.Controls.Add(RecipeAuthor);
            AuthorGroupBox.Location = new System.Drawing.Point(658, 9);
            AuthorGroupBox.Name = "AuthorGroupBox";
            AuthorGroupBox.Size = new System.Drawing.Size(214, 52);
            AuthorGroupBox.TabIndex = 16;
            AuthorGroupBox.TabStop = false;
            AuthorGroupBox.Text = "Author";
            // 
            // RecipeAuthor
            // 
            RecipeAuthor.Location = new System.Drawing.Point(6, 19);
            RecipeAuthor.Name = "RecipeAuthor";
            RecipeAuthor.Size = new System.Drawing.Size(202, 20);
            RecipeAuthor.TabIndex = 21;
            RecipeAuthor.Tag = "Author";
            RecipeAuthor.Text = "";
            // 
            // PrepTimeGroup
            // 
            PrepTimeGroup.Controls.Add(PrepDays);
            PrepTimeGroup.Controls.Add(PrepHours);
            PrepTimeGroup.Controls.Add(PrepMinutes);
            PrepTimeGroup.Location = new System.Drawing.Point(181, 69);
            PrepTimeGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            PrepTimeGroup.Name = "PrepTimeGroup";
            PrepTimeGroup.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            PrepTimeGroup.Size = new System.Drawing.Size(186, 35);
            PrepTimeGroup.TabIndex = 18;
            PrepTimeGroup.TabStop = false;
            PrepTimeGroup.Text = "Prep Time:";
            // 
            // PrepDays
            // 
            PrepDays.AutoSize = true;
            PrepDays.Location = new System.Drawing.Point(5, 16);
            PrepDays.Name = "PrepDays";
            PrepDays.Size = new System.Drawing.Size(41, 14);
            PrepDays.TabIndex = 0;
            PrepDays.Tag = "Days";
            PrepDays.Text = "0 Days";
            PrepDays.Leave += Time_Leave;
            PrepDays.MouseClick += Time_MouseClick;
            // 
            // PrepHours
            // 
            PrepHours.AutoSize = true;
            PrepHours.Location = new System.Drawing.Point(52, 16);
            PrepHours.Name = "PrepHours";
            PrepHours.Size = new System.Drawing.Size(45, 14);
            PrepHours.TabIndex = 1;
            PrepHours.Tag = "Hours";
            PrepHours.Text = "0 Hours";
            PrepHours.MouseClick += Time_MouseClick;
            // 
            // PrepMinutes
            // 
            PrepMinutes.AutoSize = true;
            PrepMinutes.Location = new System.Drawing.Point(103, 16);
            PrepMinutes.Name = "PrepMinutes";
            PrepMinutes.Size = new System.Drawing.Size(53, 14);
            PrepMinutes.TabIndex = 2;
            PrepMinutes.Tag = "Minutes";
            PrepMinutes.Text = "0 Minutes";
            PrepMinutes.MouseClick += Time_MouseClick;
            // 
            // CookTimeGroup
            // 
            CookTimeGroup.Controls.Add(CookDays);
            CookTimeGroup.Controls.Add(CookHours);
            CookTimeGroup.Controls.Add(CookMinutes);
            CookTimeGroup.Location = new System.Drawing.Point(433, 69);
            CookTimeGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            CookTimeGroup.Name = "CookTimeGroup";
            CookTimeGroup.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            CookTimeGroup.Size = new System.Drawing.Size(186, 35);
            CookTimeGroup.TabIndex = 3;
            CookTimeGroup.TabStop = false;
            CookTimeGroup.Text = "Cook Time:";
            // 
            // CookDays
            // 
            CookDays.AutoSize = true;
            CookDays.Location = new System.Drawing.Point(5, 16);
            CookDays.Name = "CookDays";
            CookDays.Size = new System.Drawing.Size(41, 14);
            CookDays.TabIndex = 3;
            CookDays.Tag = "Days";
            CookDays.Text = "0 Days";
            CookDays.MouseClick += Time_MouseClick;
            // 
            // CookHours
            // 
            CookHours.AutoSize = true;
            CookHours.Location = new System.Drawing.Point(52, 16);
            CookHours.Name = "CookHours";
            CookHours.Size = new System.Drawing.Size(45, 14);
            CookHours.TabIndex = 4;
            CookHours.Tag = "Hours";
            CookHours.Text = "0 Hours";
            CookHours.MouseClick += Time_MouseClick;
            // 
            // CookMinutes
            // 
            CookMinutes.AutoSize = true;
            CookMinutes.Location = new System.Drawing.Point(103, 16);
            CookMinutes.Name = "CookMinutes";
            CookMinutes.Size = new System.Drawing.Size(53, 14);
            CookMinutes.TabIndex = 5;
            CookMinutes.Tag = "Minutes";
            CookMinutes.Text = "0 Minutes";
            CookMinutes.MouseClick += Time_MouseClick;
            // 
            // Search
            // 
            Search.Location = new System.Drawing.Point(10, 43);
            Search.Name = "Search";
            Search.Size = new System.Drawing.Size(154, 20);
            Search.TabIndex = 19;
            Search.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(884, 811);
            Controls.Add(Search);
            Controls.Add(CookTimeGroup);
            Controls.Add(PrepTimeGroup);
            Controls.Add(AuthorGroupBox);
            Controls.Add(NameGroupBox);
            Controls.Add(TotalTimeBox);
            Controls.Add(ContentGroupBox);
            Controls.Add(RecipeList);
            Controls.Add(msOptions);
            Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            MinimumSize = new System.Drawing.Size(700, 400);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Recipe Toolbox";
            KeyDown += RecipeManager_KeyDown;
            msOptions.ResumeLayout(false);
            msOptions.PerformLayout();
            ContentGroupBox.ResumeLayout(false);
            ContentGroupBox.PerformLayout();
            TotalTimeBox.ResumeLayout(false);
            TotalTimeBox.PerformLayout();
            NameGroupBox.ResumeLayout(false);
            AuthorGroupBox.ResumeLayout(false);
            PrepTimeGroup.ResumeLayout(false);
            PrepTimeGroup.PerformLayout();
            CookTimeGroup.ResumeLayout(false);
            CookTimeGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.ListBox RecipeList;
        public System.Windows.Forms.MenuStrip msOptions;
        public System.Windows.Forms.ToolStripMenuItem Options;
        public System.Windows.Forms.ToolStripMenuItem Save;
        public System.Windows.Forms.ToolStripMenuItem CreateNew;
        public System.Windows.Forms.ToolStripMenuItem Delete;
        public System.Windows.Forms.ToolStripMenuItem Help;
        public System.Windows.Forms.GroupBox ContentGroupBox;
        public System.Windows.Forms.RichTextBox RecipeDirections;
        public System.Windows.Forms.Label DirectionsLabel;
        public System.Windows.Forms.Label IngredientsLabel;
        public System.Windows.Forms.Label DescriptionLabel;
        public System.Windows.Forms.RichTextBox RecipeIngredients;
        public System.Windows.Forms.RichTextBox RecipeDescription;
        public System.Windows.Forms.GroupBox TotalTimeBox;
        public System.Windows.Forms.Label TotalTime;
        public System.Windows.Forms.GroupBox NameGroupBox;
        public System.Windows.Forms.GroupBox AuthorGroupBox;
        public System.Windows.Forms.GroupBox PrepTimeGroup;
        public System.Windows.Forms.Label PrepMinutes;
        public System.Windows.Forms.Label PrepHours;
        public System.Windows.Forms.Label PrepDays;
        public System.Windows.Forms.GroupBox CookTimeGroup;
        public System.Windows.Forms.Label CookMinutes;
        public System.Windows.Forms.Label CookDays;
        public System.Windows.Forms.Label CookHours;
        public System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        public System.Windows.Forms.RichTextBox Search;
        public System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.RichTextBox RecipeAuthor;
        public System.Windows.Forms.RichTextBox RecipeName;
        private System.Windows.Forms.ToolStripMenuItem ingredientsToolStripMenuItem;
    }
}

