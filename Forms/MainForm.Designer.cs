﻿namespace Recipsio
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
            FormLayout = new System.Windows.Forms.TableLayoutPanel();
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
            MainToolStrip = new System.Windows.Forms.ToolStrip();
            ApplicationActions = new System.Windows.Forms.ToolStripDropDownButton();
            NewRecipeAction = new System.Windows.Forms.ToolStripMenuItem();
            SaveRecipeAction = new System.Windows.Forms.ToolStripMenuItem();
            DeleteRecipeAction = new System.Windows.Forms.ToolStripMenuItem();
            ApplicationActionsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ApplicationIngredientsAction = new System.Windows.Forms.ToolStripMenuItem();
            ApplicationTagsAction = new System.Windows.Forms.ToolStripMenuItem();
            ApplicationActionsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            SettingsAction = new System.Windows.Forms.ToolStripMenuItem();
            HelpAction = new System.Windows.Forms.ToolStripMenuItem();
            MainToolstripSeparator = new System.Windows.Forms.ToolStripSeparator();
            RecipeActions = new System.Windows.Forms.ToolStripDropDownButton();
            RecipeTagsAction = new System.Windows.Forms.ToolStripMenuItem();
            RecipeImagesAction = new System.Windows.Forms.ToolStripMenuItem();
            ExportShoppingListAction = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            RecipeIcon = new System.Windows.Forms.PictureBox();
            RecipeListLayout = new System.Windows.Forms.TableLayoutPanel();
            RecipeList = new System.Windows.Forms.ListBox();
            Search = new System.Windows.Forms.RichTextBox();
            Header = new RecipeHeader();
            FormLayout.SuspendLayout();
            RecipeInformationLayout.SuspendLayout();
            IngredientControlsLayout.SuspendLayout();
            DirectionsControlsLayout.SuspendLayout();
            MainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RecipeIcon).BeginInit();
            RecipeListLayout.SuspendLayout();
            SuspendLayout();
            // 
            // FormLayout
            // 
            FormLayout.ColumnCount = 3;
            FormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.28767F));
            FormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.712326F));
            FormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            FormLayout.Controls.Add(RecipeInformationLayout, 1, 3);
            FormLayout.Controls.Add(MainToolStrip, 0, 0);
            FormLayout.Controls.Add(RecipeIcon, 2, 0);
            FormLayout.Controls.Add(RecipeListLayout, 0, 1);
            FormLayout.Controls.Add(Header, 1, 0);
            FormLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            FormLayout.Location = new System.Drawing.Point(0, 0);
            FormLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FormLayout.Name = "FormLayout";
            FormLayout.RowCount = 4;
            FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            FormLayout.Size = new System.Drawing.Size(1191, 708);
            FormLayout.TabIndex = 0;
            FormLayout.MouseClick += Control_Mouse_Click;
            // 
            // RecipeInformationLayout
            // 
            RecipeInformationLayout.ColumnCount = 2;
            FormLayout.SetColumnSpan(RecipeInformationLayout, 2);
            RecipeInformationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            RecipeInformationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            RecipeInformationLayout.Controls.Add(DescriptionLabel, 0, 0);
            RecipeInformationLayout.Controls.Add(RecipeDescription, 1, 0);
            RecipeInformationLayout.Controls.Add(IngredientControlsLayout, 0, 1);
            RecipeInformationLayout.Controls.Add(RecipeIngredients, 1, 1);
            RecipeInformationLayout.Controls.Add(RecipeDirections, 1, 2);
            RecipeInformationLayout.Controls.Add(DirectionsControlsLayout, 0, 2);
            RecipeInformationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeInformationLayout.Location = new System.Drawing.Point(251, 131);
            RecipeInformationLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeInformationLayout.Name = "RecipeInformationLayout";
            RecipeInformationLayout.RowCount = 4;
            RecipeInformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            RecipeInformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            RecipeInformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            RecipeInformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            RecipeInformationLayout.Size = new System.Drawing.Size(936, 574);
            RecipeInformationLayout.TabIndex = 0;
            RecipeInformationLayout.MouseClick += Control_Mouse_Click;
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
            RecipeDescription.Size = new System.Drawing.Size(837, 178);
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
            IngredientControlsLayout.Location = new System.Drawing.Point(0, 184);
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
            RecipeIngredients.Location = new System.Drawing.Point(98, 187);
            RecipeIngredients.Name = "RecipeIngredients";
            RecipeIngredients.Size = new System.Drawing.Size(835, 178);
            RecipeIngredients.TabIndex = 23;
            RecipeIngredients.Tag = "Ingredients";
            // 
            // RecipeDirections
            // 
            RecipeDirections.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeDirections.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RecipeDirections.FormattingEnabled = true;
            RecipeDirections.ItemHeight = 15;
            RecipeDirections.Location = new System.Drawing.Point(98, 371);
            RecipeDirections.Name = "RecipeDirections";
            RecipeDirections.Size = new System.Drawing.Size(835, 178);
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
            DirectionsControlsLayout.Location = new System.Drawing.Point(3, 371);
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
            // MainToolStrip
            // 
            MainToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            MainToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ApplicationActions, MainToolstripSeparator, RecipeActions, toolStripSeparator1 });
            MainToolStrip.Location = new System.Drawing.Point(0, 0);
            MainToolStrip.Name = "MainToolStrip";
            MainToolStrip.Size = new System.Drawing.Size(247, 28);
            MainToolStrip.TabIndex = 4;
            MainToolStrip.Text = "toolStrip1";
            // 
            // ApplicationActions
            // 
            ApplicationActions.AutoSize = false;
            ApplicationActions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            ApplicationActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { NewRecipeAction, SaveRecipeAction, DeleteRecipeAction, ApplicationActionsSeparator1, ApplicationIngredientsAction, ApplicationTagsAction, ApplicationActionsSeparator2, SettingsAction, HelpAction });
            ApplicationActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            ApplicationActions.Name = "ApplicationActions";
            ApplicationActions.Size = new System.Drawing.Size(81, 25);
            ApplicationActions.Text = "Application";
            // 
            // NewRecipeAction
            // 
            NewRecipeAction.AutoSize = false;
            NewRecipeAction.Name = "NewRecipeAction";
            NewRecipeAction.Size = new System.Drawing.Size(180, 22);
            NewRecipeAction.Text = "New Recipe";
            NewRecipeAction.Click += Create_New_Recipe_Click;
            // 
            // SaveRecipeAction
            // 
            SaveRecipeAction.AutoSize = false;
            SaveRecipeAction.Name = "SaveRecipeAction";
            SaveRecipeAction.Size = new System.Drawing.Size(180, 22);
            SaveRecipeAction.Text = "Save Recipe";
            SaveRecipeAction.Click += Save_Recipe_Click;
            // 
            // DeleteRecipeAction
            // 
            DeleteRecipeAction.AutoSize = false;
            DeleteRecipeAction.Name = "DeleteRecipeAction";
            DeleteRecipeAction.Size = new System.Drawing.Size(180, 22);
            DeleteRecipeAction.Text = "Delete Recipe";
            DeleteRecipeAction.Click += Delete_Recipe_Click;
            // 
            // ApplicationActionsSeparator1
            // 
            ApplicationActionsSeparator1.Name = "ApplicationActionsSeparator1";
            ApplicationActionsSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // ApplicationIngredientsAction
            // 
            ApplicationIngredientsAction.Name = "ApplicationIngredientsAction";
            ApplicationIngredientsAction.Size = new System.Drawing.Size(145, 22);
            ApplicationIngredientsAction.Text = "Ingredients";
            ApplicationIngredientsAction.Click += Options_Click;
            // 
            // ApplicationTagsAction
            // 
            ApplicationTagsAction.Name = "ApplicationTagsAction";
            ApplicationTagsAction.Size = new System.Drawing.Size(145, 22);
            ApplicationTagsAction.Text = "Tags";
            ApplicationTagsAction.Click += Options_Click;
            // 
            // ApplicationActionsSeparator2
            // 
            ApplicationActionsSeparator2.Name = "ApplicationActionsSeparator2";
            ApplicationActionsSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // SettingsAction
            // 
            SettingsAction.Name = "SettingsAction";
            SettingsAction.Size = new System.Drawing.Size(145, 22);
            SettingsAction.Text = "Settings";
            SettingsAction.Click += Options_Click;
            // 
            // HelpAction
            // 
            HelpAction.Name = "HelpAction";
            HelpAction.Size = new System.Drawing.Size(145, 22);
            HelpAction.Text = "Help";
            HelpAction.Click += Options_Click;
            // 
            // MainToolstripSeparator
            // 
            MainToolstripSeparator.Name = "MainToolstripSeparator";
            MainToolstripSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // RecipeActions
            // 
            RecipeActions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            RecipeActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { RecipeTagsAction, RecipeImagesAction, ExportShoppingListAction });
            RecipeActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            RecipeActions.Name = "RecipeActions";
            RecipeActions.Size = new System.Drawing.Size(55, 25);
            RecipeActions.Text = "Recipe";
            // 
            // RecipeTagsAction
            // 
            RecipeTagsAction.Name = "RecipeTagsAction";
            RecipeTagsAction.Size = new System.Drawing.Size(183, 22);
            RecipeTagsAction.Text = "Tags";
            // 
            // RecipeImagesAction
            // 
            RecipeImagesAction.Name = "RecipeImagesAction";
            RecipeImagesAction.Size = new System.Drawing.Size(183, 22);
            RecipeImagesAction.Text = "Images";
            // 
            // ExportShoppingListAction
            // 
            ExportShoppingListAction.Name = "ExportShoppingListAction";
            ExportShoppingListAction.Size = new System.Drawing.Size(183, 22);
            ExportShoppingListAction.Text = "Export Shopping List";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // RecipeIcon
            // 
            RecipeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            RecipeIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeIcon.Image = (System.Drawing.Image)resources.GetObject("RecipeIcon.Image");
            RecipeIcon.InitialImage = (System.Drawing.Image)resources.GetObject("RecipeIcon.InitialImage");
            RecipeIcon.Location = new System.Drawing.Point(1065, 3);
            RecipeIcon.Name = "RecipeIcon";
            FormLayout.SetRowSpan(RecipeIcon, 3);
            RecipeIcon.Size = new System.Drawing.Size(123, 122);
            RecipeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            RecipeIcon.TabIndex = 5;
            RecipeIcon.TabStop = false;
            // 
            // RecipeListLayout
            // 
            RecipeListLayout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeListLayout.ColumnCount = 1;
            RecipeListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            RecipeListLayout.Controls.Add(RecipeList, 0, 1);
            RecipeListLayout.Controls.Add(Search, 0, 0);
            RecipeListLayout.Location = new System.Drawing.Point(5, 28);
            RecipeListLayout.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            RecipeListLayout.Name = "RecipeListLayout";
            RecipeListLayout.RowCount = 2;
            FormLayout.SetRowSpan(RecipeListLayout, 3);
            RecipeListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            RecipeListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            RecipeListLayout.Size = new System.Drawing.Size(242, 675);
            RecipeListLayout.TabIndex = 3;
            // 
            // RecipeList
            // 
            RecipeList.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeList.ForeColor = System.Drawing.SystemColors.WindowText;
            RecipeList.FormattingEnabled = true;
            RecipeList.ItemHeight = 15;
            RecipeList.Location = new System.Drawing.Point(0, 29);
            RecipeList.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            RecipeList.Name = "RecipeList";
            RecipeList.Size = new System.Drawing.Size(242, 646);
            RecipeList.TabIndex = 1;
            RecipeList.TabStop = false;
            RecipeList.SelectedValueChanged += RecipeList_Selected_Value_Changed;
            // 
            // Search
            // 
            Search.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            Search.Location = new System.Drawing.Point(0, 3);
            Search.Margin = new System.Windows.Forms.Padding(0, 3, 0, 1);
            Search.Name = "Search";
            Search.Size = new System.Drawing.Size(242, 23);
            Search.TabIndex = 0;
            Search.Text = "Search...";
            Search.TextChanged += Search_Text_Changed;
            Search.Enter += Search_Enter;
            Search.Leave += Search_Leave;
            // 
            // Header
            // 
            Header.BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            Header.Dock = System.Windows.Forms.DockStyle.Fill;
            Header.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Header.Location = new System.Drawing.Point(250, 3);
            Header.Name = "Header";
            FormLayout.SetRowSpan(Header, 3);
            Header.Size = new System.Drawing.Size(809, 122);
            Header.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(1191, 708);
            Controls.Add(FormLayout);
            Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            MinimumSize = new System.Drawing.Size(800, 600);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Recipsio";
            KeyDown += Recipsio_Key_Down;
            MouseClick += Control_Mouse_Click;
            FormLayout.ResumeLayout(false);
            FormLayout.PerformLayout();
            RecipeInformationLayout.ResumeLayout(false);
            IngredientControlsLayout.ResumeLayout(false);
            DirectionsControlsLayout.ResumeLayout(false);
            MainToolStrip.ResumeLayout(false);
            MainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RecipeIcon).EndInit();
            RecipeListLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel FormLayout;

        private System.Windows.Forms.ToolStrip MainToolStrip;

        private System.Windows.Forms.ToolStripDropDownButton ApplicationActions;

        private System.Windows.Forms.ToolStripMenuItem NewRecipeAction;
        private System.Windows.Forms.ToolStripMenuItem SaveRecipeAction;
        private System.Windows.Forms.ToolStripMenuItem DeleteRecipeAction;

        private System.Windows.Forms.ToolStripSeparator ApplicationActionsSeparator1;

        private System.Windows.Forms.ToolStripMenuItem ApplicationIngredientsAction;
        private System.Windows.Forms.ToolStripMenuItem ApplicationTagsAction;

        private System.Windows.Forms.ToolStripSeparator ApplicationActionsSeparator2;

        private System.Windows.Forms.ToolStripMenuItem SettingsAction;
        private System.Windows.Forms.ToolStripMenuItem HelpAction;

        private System.Windows.Forms.ToolStripSeparator MainToolstripSeparator;

        private System.Windows.Forms.ToolStripDropDownButton RecipeActions;
        private System.Windows.Forms.ToolStripMenuItem RecipeTagsAction;
        private System.Windows.Forms.ToolStripMenuItem RecipeImagesAction;
        private System.Windows.Forms.ToolStripMenuItem ExportShoppingListAction;

        public System.Windows.Forms.TableLayoutPanel RecipeListLayout;
        public System.Windows.Forms.RichTextBox Search;
        public System.Windows.Forms.ListBox RecipeList;

        public System.Windows.Forms.TableLayoutPanel RecipeInformationLayout;

        public System.Windows.Forms.Label DescriptionLabel;
        public System.Windows.Forms.RichTextBox RecipeDescription;

        public System.Windows.Forms.TableLayoutPanel IngredientControlsLayout;
        public System.Windows.Forms.Label IngredientsLabel;
        public System.Windows.Forms.Button AddIngredient;
        public System.Windows.Forms.Button RemoveIngredient;
        public System.Windows.Forms.ListBox RecipeIngredients;

        public System.Windows.Forms.TableLayoutPanel DirectionsControlsLayout;
        public System.Windows.Forms.Label DirectionsLabel;
        public System.Windows.Forms.Button AddDirection;
        public System.Windows.Forms.Button RemoveDirection;
        public System.Windows.Forms.ListBox RecipeDirections;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.PictureBox RecipeIcon;
        public RecipeHeader Header;
    }
}

