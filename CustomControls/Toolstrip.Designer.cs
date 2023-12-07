namespace Recipsio
{
    partial class Toolstrip
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
            RecipeHeaderLayout.SuspendLayout();
            AuthorGroupBox.SuspendLayout();
            CookTime.SuspendLayout();
            CookTimeLayout.SuspendLayout();
            TotalTime.SuspendLayout();
            panel1.SuspendLayout();
            NameGroupBox.SuspendLayout();
            PrepTimeLayout.SuspendLayout();
            MainToolStrip.SuspendLayout();
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
            // MainToolStrip
            // 
            MainToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            MainToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ApplicationActions, MainToolstripSeparator, RecipeActions, toolStripSeparator1 });
            MainToolStrip.Location = new System.Drawing.Point(0, 0);
            MainToolStrip.Name = "MainToolStrip";
            MainToolStrip.Size = new System.Drawing.Size(197, 49);
            MainToolStrip.TabIndex = 5;
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
            ApplicationActionsSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ApplicationIngredientsAction
            // 
            ApplicationIngredientsAction.Name = "ApplicationIngredientsAction";
            ApplicationIngredientsAction.Size = new System.Drawing.Size(180, 22);
            ApplicationIngredientsAction.Text = "Ingredients";
            ApplicationIngredientsAction.Click += Options_Click;
            // 
            // ApplicationTagsAction
            // 
            ApplicationTagsAction.Name = "ApplicationTagsAction";
            ApplicationTagsAction.Size = new System.Drawing.Size(180, 22);
            ApplicationTagsAction.Text = "Tags";
            ApplicationTagsAction.Click += Options_Click;
            // 
            // ApplicationActionsSeparator2
            // 
            ApplicationActionsSeparator2.Name = "ApplicationActionsSeparator2";
            ApplicationActionsSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // SettingsAction
            // 
            SettingsAction.Name = "SettingsAction";
            SettingsAction.Size = new System.Drawing.Size(180, 22);
            SettingsAction.Text = "Settings";
            SettingsAction.Click += Options_Click;
            // 
            // HelpAction
            // 
            HelpAction.Name = "HelpAction";
            HelpAction.Size = new System.Drawing.Size(180, 22);
            HelpAction.Text = "Help";
            HelpAction.Click += Options_Click;
            // 
            // MainToolstripSeparator
            // 
            MainToolstripSeparator.Name = "MainToolstripSeparator";
            MainToolstripSeparator.Size = new System.Drawing.Size(6, 49);
            // 
            // RecipeActions
            // 
            RecipeActions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            RecipeActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { RecipeTagsAction, RecipeImagesAction, ExportShoppingListAction });
            RecipeActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            RecipeActions.Name = "RecipeActions";
            RecipeActions.Size = new System.Drawing.Size(55, 46);
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
            toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // Toolstrip
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            Controls.Add(MainToolStrip);
            Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "Toolstrip";
            Size = new System.Drawing.Size(197, 49);
            RecipeHeaderLayout.ResumeLayout(false);
            AuthorGroupBox.ResumeLayout(false);
            CookTime.ResumeLayout(false);
            CookTimeLayout.ResumeLayout(false);
            TotalTime.ResumeLayout(false);
            panel1.ResumeLayout(false);
            NameGroupBox.ResumeLayout(false);
            PrepTimeLayout.ResumeLayout(false);
            MainToolStrip.ResumeLayout(false);
            MainToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
