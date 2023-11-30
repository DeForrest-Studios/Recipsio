namespace Recipsio
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
            RecipeHeaderLayout = new System.Windows.Forms.TableLayoutPanel();
            AuthorGroupBox = new System.Windows.Forms.GroupBox();
            RecipeAuthor = new System.Windows.Forms.RichTextBox();
            CookTimeGroup = new System.Windows.Forms.GroupBox();
            CookDays = new System.Windows.Forms.Label();
            CookHours = new System.Windows.Forms.Label();
            CookMInutes = new System.Windows.Forms.Label();
            TotalTimeBox = new System.Windows.Forms.GroupBox();
            TotalTime = new System.Windows.Forms.Label();
            NameGroupBox = new System.Windows.Forms.GroupBox();
            RecipeName = new System.Windows.Forms.RichTextBox();
            PrepTimeGroup = new System.Windows.Forms.GroupBox();
            PrepDays = new System.Windows.Forms.Label();
            PrepHours = new System.Windows.Forms.Label();
            PrepMinutes = new System.Windows.Forms.Label();
            RecipeInformationLayout = new System.Windows.Forms.TableLayoutPanel();
            DescriptionLabel = new System.Windows.Forms.Label();
            RecipeDescription = new System.Windows.Forms.RichTextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            IngredientsLabel = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            RecipeIngredients = new System.Windows.Forms.ListBox();
            RecipeDirections = new System.Windows.Forms.ListBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            DirectionsLabel = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            Toolstrip = new System.Windows.Forms.ToolStripDropDownButton();
            newRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ingredientsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            tagsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            tagsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            imagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportShoppingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            RecipeListLayout = new System.Windows.Forms.TableLayoutPanel();
            RecipeList = new System.Windows.Forms.ListBox();
            Search = new System.Windows.Forms.RichTextBox();
            Actions = new System.Windows.Forms.ToolStripMenuItem();
            CreateNew = new System.Windows.Forms.ToolStripMenuItem();
            Save = new System.Windows.Forms.ToolStripMenuItem();
            Delete = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ingredientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Help = new System.Windows.Forms.ToolStripMenuItem();
            FormLayout.SuspendLayout();
            RecipeHeaderLayout.SuspendLayout();
            AuthorGroupBox.SuspendLayout();
            CookTimeGroup.SuspendLayout();
            TotalTimeBox.SuspendLayout();
            NameGroupBox.SuspendLayout();
            PrepTimeGroup.SuspendLayout();
            RecipeInformationLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            RecipeListLayout.SuspendLayout();
            SuspendLayout();
            // 
            // FormLayout
            // 
            FormLayout.ColumnCount = 3;
            FormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            FormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.35294F));
            FormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            FormLayout.Controls.Add(RecipeHeaderLayout, 1, 0);
            FormLayout.Controls.Add(RecipeInformationLayout, 1, 3);
            FormLayout.Controls.Add(toolStrip1, 0, 0);
            FormLayout.Controls.Add(pictureBox1, 2, 0);
            FormLayout.Controls.Add(RecipeListLayout, 0, 1);
            FormLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            FormLayout.Location = new System.Drawing.Point(0, 0);
            FormLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FormLayout.Name = "FormLayout";
            FormLayout.RowCount = 4;
            FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            FormLayout.Size = new System.Drawing.Size(1191, 708);
            FormLayout.TabIndex = 0;
            FormLayout.MouseClick += Control_MouseClick;
            // 
            // RecipeHeaderLayout
            // 
            RecipeHeaderLayout.ColumnCount = 3;
            RecipeHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            RecipeHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            RecipeHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            RecipeHeaderLayout.Controls.Add(AuthorGroupBox, 2, 0);
            RecipeHeaderLayout.Controls.Add(CookTimeGroup, 1, 1);
            RecipeHeaderLayout.Controls.Add(TotalTimeBox, 2, 1);
            RecipeHeaderLayout.Controls.Add(NameGroupBox, 0, 0);
            RecipeHeaderLayout.Controls.Add(PrepTimeGroup, 0, 1);
            RecipeHeaderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeHeaderLayout.Location = new System.Drawing.Point(191, 3);
            RecipeHeaderLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeHeaderLayout.Name = "RecipeHeaderLayout";
            RecipeHeaderLayout.RowCount = 2;
            FormLayout.SetRowSpan(RecipeHeaderLayout, 2);
            RecipeHeaderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.5454559F));
            RecipeHeaderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.4545441F));
            RecipeHeaderLayout.Size = new System.Drawing.Size(867, 94);
            RecipeHeaderLayout.TabIndex = 1;
            RecipeHeaderLayout.MouseClick += Control_MouseClick;
            // 
            // AuthorGroupBox
            // 
            AuthorGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            AuthorGroupBox.Controls.Add(RecipeAuthor);
            AuthorGroupBox.Location = new System.Drawing.Point(581, 3);
            AuthorGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AuthorGroupBox.Name = "AuthorGroupBox";
            AuthorGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AuthorGroupBox.Size = new System.Drawing.Size(282, 45);
            AuthorGroupBox.TabIndex = 22;
            AuthorGroupBox.TabStop = false;
            AuthorGroupBox.Text = "Author";
            AuthorGroupBox.MouseClick += Control_MouseClick;
            // 
            // RecipeAuthor
            // 
            RecipeAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeAuthor.Location = new System.Drawing.Point(8, 16);
            RecipeAuthor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeAuthor.Name = "RecipeAuthor";
            RecipeAuthor.Size = new System.Drawing.Size(266, 23);
            RecipeAuthor.TabIndex = 0;
            RecipeAuthor.Tag = "Author";
            RecipeAuthor.Text = "";
            // 
            // CookTimeGroup
            // 
            CookTimeGroup.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            CookTimeGroup.Controls.Add(CookDays);
            CookTimeGroup.Controls.Add(CookHours);
            CookTimeGroup.Controls.Add(CookMInutes);
            CookTimeGroup.Location = new System.Drawing.Point(290, 54);
            CookTimeGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            CookTimeGroup.Name = "CookTimeGroup";
            CookTimeGroup.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            CookTimeGroup.Size = new System.Drawing.Size(285, 37);
            CookTimeGroup.TabIndex = 19;
            CookTimeGroup.TabStop = false;
            CookTimeGroup.Text = "Cook Time";
            CookTimeGroup.MouseClick += Control_MouseClick;
            // 
            // CookDays
            // 
            CookDays.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            CookDays.AutoSize = true;
            CookDays.Location = new System.Drawing.Point(104, 17);
            CookDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CookDays.Name = "CookDays";
            CookDays.Size = new System.Drawing.Size(45, 15);
            CookDays.TabIndex = 6;
            CookDays.Tag = "Days";
            CookDays.Text = "0 Days";
            CookDays.MouseClick += Time_MouseClick;
            // 
            // CookHours
            // 
            CookHours.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            CookHours.AutoSize = true;
            CookHours.Location = new System.Drawing.Point(159, 17);
            CookHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CookHours.Name = "CookHours";
            CookHours.Size = new System.Drawing.Size(51, 15);
            CookHours.TabIndex = 7;
            CookHours.Tag = "Hours";
            CookHours.Text = "0 Hours";
            CookHours.MouseClick += Time_MouseClick;
            // 
            // CookMInutes
            // 
            CookMInutes.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            CookMInutes.AutoSize = true;
            CookMInutes.Location = new System.Drawing.Point(219, 17);
            CookMInutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CookMInutes.Name = "CookMInutes";
            CookMInutes.Size = new System.Drawing.Size(60, 15);
            CookMInutes.TabIndex = 8;
            CookMInutes.Tag = "Minutes";
            CookMInutes.Text = "0 Minutes";
            CookMInutes.MouseClick += Time_MouseClick;
            // 
            // TotalTimeBox
            // 
            TotalTimeBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TotalTimeBox.Controls.Add(TotalTime);
            TotalTimeBox.Location = new System.Drawing.Point(581, 54);
            TotalTimeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TotalTimeBox.Name = "TotalTimeBox";
            TotalTimeBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TotalTimeBox.Size = new System.Drawing.Size(282, 37);
            TotalTimeBox.TabIndex = 20;
            TotalTimeBox.TabStop = false;
            TotalTimeBox.Text = "Total Time";
            TotalTimeBox.MouseClick += Control_MouseClick;
            // 
            // TotalTime
            // 
            TotalTime.AutoSize = true;
            TotalTime.Dock = System.Windows.Forms.DockStyle.Right;
            TotalTime.Location = new System.Drawing.Point(127, 17);
            TotalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TotalTime.Name = "TotalTime";
            TotalTime.Size = new System.Drawing.Size(151, 15);
            TotalTime.TabIndex = 1;
            TotalTime.Text = "0 Days 0 Hours 0  Minutes";
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
            NameGroupBox.Size = new System.Drawing.Size(569, 45);
            NameGroupBox.TabIndex = 2;
            NameGroupBox.TabStop = false;
            NameGroupBox.Text = "Name";
            NameGroupBox.MouseClick += Control_MouseClick;
            // 
            // RecipeName
            // 
            RecipeName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeName.Location = new System.Drawing.Point(8, 16);
            RecipeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeName.Multiline = false;
            RecipeName.Name = "RecipeName";
            RecipeName.Size = new System.Drawing.Size(553, 23);
            RecipeName.TabIndex = 0;
            RecipeName.Tag = "Name";
            RecipeName.Text = "";
            // 
            // PrepTimeGroup
            // 
            PrepTimeGroup.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PrepTimeGroup.Controls.Add(PrepDays);
            PrepTimeGroup.Controls.Add(PrepHours);
            PrepTimeGroup.Controls.Add(PrepMinutes);
            PrepTimeGroup.Location = new System.Drawing.Point(2, 54);
            PrepTimeGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            PrepTimeGroup.Name = "PrepTimeGroup";
            PrepTimeGroup.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            PrepTimeGroup.Size = new System.Drawing.Size(284, 37);
            PrepTimeGroup.TabIndex = 1;
            PrepTimeGroup.TabStop = false;
            PrepTimeGroup.Text = "Prep Time";
            PrepTimeGroup.MouseClick += Control_MouseClick;
            // 
            // PrepDays
            // 
            PrepDays.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            PrepDays.AutoSize = true;
            PrepDays.Location = new System.Drawing.Point(108, 17);
            PrepDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PrepDays.Name = "PrepDays";
            PrepDays.Size = new System.Drawing.Size(45, 15);
            PrepDays.TabIndex = 3;
            PrepDays.Tag = "Days";
            PrepDays.Text = "0 Days";
            PrepDays.MouseClick += Time_MouseClick;
            // 
            // PrepHours
            // 
            PrepHours.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            PrepHours.AutoSize = true;
            PrepHours.Location = new System.Drawing.Point(163, 17);
            PrepHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PrepHours.Name = "PrepHours";
            PrepHours.Size = new System.Drawing.Size(51, 15);
            PrepHours.TabIndex = 4;
            PrepHours.Tag = "Hours";
            PrepHours.Text = "0 Hours";
            PrepHours.MouseClick += Time_MouseClick;
            // 
            // PrepMinutes
            // 
            PrepMinutes.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            PrepMinutes.AutoSize = true;
            PrepMinutes.Location = new System.Drawing.Point(222, 17);
            PrepMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PrepMinutes.Name = "PrepMinutes";
            PrepMinutes.Size = new System.Drawing.Size(60, 15);
            PrepMinutes.TabIndex = 5;
            PrepMinutes.Tag = "Minutes";
            PrepMinutes.Text = "0 Minutes";
            PrepMinutes.MouseClick += Time_MouseClick;
            // 
            // RecipeInformationLayout
            // 
            RecipeInformationLayout.AutoSize = true;
            RecipeInformationLayout.ColumnCount = 2;
            FormLayout.SetColumnSpan(RecipeInformationLayout, 2);
            RecipeInformationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            RecipeInformationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            RecipeInformationLayout.Controls.Add(DescriptionLabel, 0, 0);
            RecipeInformationLayout.Controls.Add(RecipeDescription, 1, 0);
            RecipeInformationLayout.Controls.Add(tableLayoutPanel1, 0, 1);
            RecipeInformationLayout.Controls.Add(RecipeIngredients, 1, 1);
            RecipeInformationLayout.Controls.Add(RecipeDirections, 1, 2);
            RecipeInformationLayout.Controls.Add(tableLayoutPanel2, 0, 2);
            RecipeInformationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeInformationLayout.Location = new System.Drawing.Point(191, 131);
            RecipeInformationLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeInformationLayout.Name = "RecipeInformationLayout";
            RecipeInformationLayout.RowCount = 3;
            RecipeInformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            RecipeInformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            RecipeInformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            RecipeInformationLayout.Size = new System.Drawing.Size(996, 574);
            RecipeInformationLayout.TabIndex = 0;
            RecipeInformationLayout.MouseClick += Control_MouseClick;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
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
            RecipeDescription.Size = new System.Drawing.Size(897, 185);
            RecipeDescription.TabIndex = 17;
            RecipeDescription.Tag = "Description";
            RecipeDescription.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(IngredientsLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 0, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 191);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new System.Drawing.Size(95, 87);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // IngredientsLabel
            // 
            IngredientsLabel.AutoSize = true;
            IngredientsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            IngredientsLabel.Location = new System.Drawing.Point(2, 0);
            IngredientsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            IngredientsLabel.Name = "IngredientsLabel";
            IngredientsLabel.Size = new System.Drawing.Size(84, 18);
            IngredientsLabel.TabIndex = 19;
            IngredientsLabel.Text = "&Ingredients";
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Fill;
            button1.Location = new System.Drawing.Point(3, 32);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(89, 23);
            button1.TabIndex = 20;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Fill;
            button2.Location = new System.Drawing.Point(3, 61);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(89, 23);
            button2.TabIndex = 21;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            // 
            // RecipeIngredients
            // 
            RecipeIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeIngredients.FormattingEnabled = true;
            RecipeIngredients.ItemHeight = 15;
            RecipeIngredients.Location = new System.Drawing.Point(98, 194);
            RecipeIngredients.Name = "RecipeIngredients";
            RecipeIngredients.Size = new System.Drawing.Size(895, 185);
            RecipeIngredients.TabIndex = 23;
            // 
            // RecipeDirections
            // 
            RecipeDirections.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeDirections.FormattingEnabled = true;
            RecipeDirections.ItemHeight = 15;
            RecipeDirections.Location = new System.Drawing.Point(98, 385);
            RecipeDirections.Name = "RecipeDirections";
            RecipeDirections.Size = new System.Drawing.Size(895, 186);
            RecipeDirections.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(DirectionsLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(button3, 0, 1);
            tableLayoutPanel2.Controls.Add(button4, 0, 2);
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 385);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new System.Drawing.Size(89, 87);
            tableLayoutPanel2.TabIndex = 25;
            // 
            // DirectionsLabel
            // 
            DirectionsLabel.AutoSize = true;
            DirectionsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DirectionsLabel.Location = new System.Drawing.Point(2, 0);
            DirectionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            DirectionsLabel.Name = "DirectionsLabel";
            DirectionsLabel.Size = new System.Drawing.Size(79, 18);
            DirectionsLabel.TabIndex = 18;
            DirectionsLabel.Text = "&Directions";
            // 
            // button3
            // 
            button3.Dock = System.Windows.Forms.DockStyle.Fill;
            button3.Location = new System.Drawing.Point(3, 32);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(83, 23);
            button3.TabIndex = 19;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = System.Windows.Forms.DockStyle.Fill;
            button4.Location = new System.Drawing.Point(3, 61);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(83, 23);
            button4.TabIndex = 20;
            button4.Text = "Remove";
            button4.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { Toolstrip, toolStripSeparator3, toolStripButton1 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(145, 20);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // Toolstrip
            // 
            Toolstrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            Toolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newRecipeToolStripMenuItem, saveRecipeToolStripMenuItem, deleteRecipeToolStripMenuItem, toolStripSeparator4, ingredientsToolStripMenuItem1, tagsToolStripMenuItem1, toolStripSeparator5, settingsToolStripMenuItem1, helpToolStripMenuItem });
            Toolstrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            Toolstrip.Name = "Toolstrip";
            Toolstrip.Size = new System.Drawing.Size(81, 17);
            Toolstrip.Text = "Application";
            // 
            // newRecipeToolStripMenuItem
            // 
            newRecipeToolStripMenuItem.Name = "newRecipeToolStripMenuItem";
            newRecipeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            newRecipeToolStripMenuItem.Text = "New Recipe";
            newRecipeToolStripMenuItem.Click += CreateNew_Click;
            // 
            // saveRecipeToolStripMenuItem
            // 
            saveRecipeToolStripMenuItem.Name = "saveRecipeToolStripMenuItem";
            saveRecipeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            saveRecipeToolStripMenuItem.Text = "Save Recipe";
            saveRecipeToolStripMenuItem.Click += Save_Click;
            // 
            // deleteRecipeToolStripMenuItem
            // 
            deleteRecipeToolStripMenuItem.Name = "deleteRecipeToolStripMenuItem";
            deleteRecipeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            deleteRecipeToolStripMenuItem.Text = "Delete Recipe";
            deleteRecipeToolStripMenuItem.Click += Delete_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(142, 6);
            // 
            // ingredientsToolStripMenuItem1
            // 
            ingredientsToolStripMenuItem1.Name = "ingredientsToolStripMenuItem1";
            ingredientsToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            ingredientsToolStripMenuItem1.Text = "Ingredients";
            ingredientsToolStripMenuItem1.Click += Options_Click;
            // 
            // tagsToolStripMenuItem1
            // 
            tagsToolStripMenuItem1.Name = "tagsToolStripMenuItem1";
            tagsToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            tagsToolStripMenuItem1.Text = "Tags";
            tagsToolStripMenuItem1.Click += Options_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(142, 6);
            // 
            // settingsToolStripMenuItem1
            // 
            settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            settingsToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            settingsToolStripMenuItem1.Text = "Settings";
            settingsToolStripMenuItem1.Click += Options_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += Options_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 20);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tagsToolStripMenuItem2, imagesToolStripMenuItem, exportShoppingListToolStripMenuItem });
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(55, 17);
            toolStripButton1.Text = "Recipe";
            // 
            // tagsToolStripMenuItem2
            // 
            tagsToolStripMenuItem2.Name = "tagsToolStripMenuItem2";
            tagsToolStripMenuItem2.Size = new System.Drawing.Size(183, 22);
            tagsToolStripMenuItem2.Text = "Tags";
            // 
            // imagesToolStripMenuItem
            // 
            imagesToolStripMenuItem.Name = "imagesToolStripMenuItem";
            imagesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            imagesToolStripMenuItem.Text = "Images";
            // 
            // exportShoppingListToolStripMenuItem
            // 
            exportShoppingListToolStripMenuItem.Name = "exportShoppingListToolStripMenuItem";
            exportShoppingListToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            exportShoppingListToolStripMenuItem.Text = "Export Shopping List";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (System.Drawing.Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new System.Drawing.Point(1065, 3);
            pictureBox1.Name = "pictureBox1";
            FormLayout.SetRowSpan(pictureBox1, 3);
            pictureBox1.Size = new System.Drawing.Size(123, 122);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // RecipeListLayout
            // 
            RecipeListLayout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeListLayout.ColumnCount = 1;
            RecipeListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            RecipeListLayout.Controls.Add(RecipeList, 0, 1);
            RecipeListLayout.Controls.Add(Search, 0, 0);
            RecipeListLayout.Location = new System.Drawing.Point(5, 20);
            RecipeListLayout.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            RecipeListLayout.Name = "RecipeListLayout";
            RecipeListLayout.RowCount = 2;
            FormLayout.SetRowSpan(RecipeListLayout, 3);
            RecipeListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            RecipeListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            RecipeListLayout.Size = new System.Drawing.Size(182, 683);
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
            RecipeList.Size = new System.Drawing.Size(182, 654);
            RecipeList.TabIndex = 1;
            RecipeList.TabStop = false;
            RecipeList.SelectedValueChanged += RecipeList_SelectedValueChanged;
            // 
            // Search
            // 
            Search.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            Search.Location = new System.Drawing.Point(0, 3);
            Search.Margin = new System.Windows.Forms.Padding(0, 3, 0, 1);
            Search.Name = "Search";
            Search.Size = new System.Drawing.Size(182, 23);
            Search.TabIndex = 0;
            Search.Text = "Search...";
            Search.TextChanged += Search_TextChanged;
            Search.Enter += Search_Enter;
            Search.Leave += Search_Leave;
            // 
            // Actions
            // 
            Actions.Name = "Actions";
            Actions.Size = new System.Drawing.Size(32, 19);
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
            // ingredientsToolStripMenuItem
            // 
            ingredientsToolStripMenuItem.Name = "ingredientsToolStripMenuItem";
            ingredientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            ingredientsToolStripMenuItem.Text = "Ingredients";
            ingredientsToolStripMenuItem.Click += Options_Click;
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
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
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
            Text = "Recipe Toolbox";
            KeyDown += RecipeManager_KeyDown;
            MouseClick += Control_MouseClick;
            FormLayout.ResumeLayout(false);
            FormLayout.PerformLayout();
            RecipeHeaderLayout.ResumeLayout(false);
            AuthorGroupBox.ResumeLayout(false);
            CookTimeGroup.ResumeLayout(false);
            CookTimeGroup.PerformLayout();
            TotalTimeBox.ResumeLayout(false);
            TotalTimeBox.PerformLayout();
            NameGroupBox.ResumeLayout(false);
            PrepTimeGroup.ResumeLayout(false);
            PrepTimeGroup.PerformLayout();
            RecipeInformationLayout.ResumeLayout(false);
            RecipeInformationLayout.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            RecipeListLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel FormLayout;
        public System.Windows.Forms.ToolStripMenuItem Actions;
        public System.Windows.Forms.ToolStripMenuItem CreateNew;
        public System.Windows.Forms.ToolStripMenuItem Save;
        public System.Windows.Forms.ToolStripMenuItem Delete;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem ingredientsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Help;
        public System.Windows.Forms.TableLayoutPanel RecipeListLayout;
        public System.Windows.Forms.ListBox RecipeList;
        public System.Windows.Forms.RichTextBox Search;
        public System.Windows.Forms.TableLayoutPanel RecipeInformationLayout;
        public System.Windows.Forms.RichTextBox RecipeDescription;
        public System.Windows.Forms.Label DirectionsLabel;
        public System.Windows.Forms.Label IngredientsLabel;
        public System.Windows.Forms.Label DescriptionLabel;
        public System.Windows.Forms.TableLayoutPanel RecipeHeaderLayout;
        public System.Windows.Forms.GroupBox AuthorGroupBox;
        public System.Windows.Forms.RichTextBox RecipeAuthor;
        public System.Windows.Forms.GroupBox CookTimeGroup;
        public System.Windows.Forms.Label CookDays;
        public System.Windows.Forms.Label CookHours;
        public System.Windows.Forms.Label CookMInutes;
        public System.Windows.Forms.GroupBox TotalTimeBox;
        public System.Windows.Forms.Label TotalTime;
        public System.Windows.Forms.GroupBox NameGroupBox;
        public System.Windows.Forms.RichTextBox RecipeName;
        public System.Windows.Forms.GroupBox PrepTimeGroup;
        public System.Windows.Forms.Label PrepDays;
        public System.Windows.Forms.Label PrepHours;
        public System.Windows.Forms.Label PrepMinutes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton Toolstrip;
        private System.Windows.Forms.ToolStripMenuItem newRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ingredientsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem imagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportShoppingListToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox RecipeIngredients;
        private System.Windows.Forms.ListBox RecipeDirections;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

