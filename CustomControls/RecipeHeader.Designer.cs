namespace Recipsio
{
    partial class RecipeHeader
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
            RecipeNameBox = new System.Windows.Forms.GroupBox();
            RecipeName = new System.Windows.Forms.RichTextBox();
            RecipeAuthorBox = new System.Windows.Forms.GroupBox();
            RecipeAuthor = new System.Windows.Forms.RichTextBox();
            PrepTimeBox = new System.Windows.Forms.GroupBox();
            PrepTimeLayout = new System.Windows.Forms.TableLayoutPanel();
            PrepHoursLabel = new System.Windows.Forms.Label();
            PrepDaysLabel = new System.Windows.Forms.Label();
            PrepMinutesLabel = new System.Windows.Forms.Label();
            CookTimeBox = new System.Windows.Forms.GroupBox();
            CookTimeLayout = new System.Windows.Forms.TableLayoutPanel();
            CookTimeDaysLabel = new System.Windows.Forms.Label();
            CookTimeHoursLabel = new System.Windows.Forms.Label();
            CookTimeMinuteLabel = new System.Windows.Forms.Label();
            TotalTimeBox = new System.Windows.Forms.GroupBox();
            TotalTimeValue = new System.Windows.Forms.Label();
            RecipeHeaderLayout.SuspendLayout();
            RecipeNameBox.SuspendLayout();
            RecipeAuthorBox.SuspendLayout();
            PrepTimeBox.SuspendLayout();
            PrepTimeLayout.SuspendLayout();
            CookTimeBox.SuspendLayout();
            CookTimeLayout.SuspendLayout();
            TotalTimeBox.SuspendLayout();
            SuspendLayout();
            // 
            // RecipeHeaderLayout
            // 
            RecipeHeaderLayout.ColumnCount = 3;
            RecipeHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            RecipeHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            RecipeHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            RecipeHeaderLayout.Controls.Add(RecipeNameBox, 0, 0);
            RecipeHeaderLayout.Controls.Add(RecipeAuthorBox, 2, 0);
            RecipeHeaderLayout.Controls.Add(PrepTimeBox, 0, 1);
            RecipeHeaderLayout.Controls.Add(CookTimeBox, 1, 1);
            RecipeHeaderLayout.Controls.Add(TotalTimeBox, 2, 1);
            RecipeHeaderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            RecipeHeaderLayout.Location = new System.Drawing.Point(0, 0);
            RecipeHeaderLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeHeaderLayout.Name = "RecipeHeaderLayout";
            RecipeHeaderLayout.RowCount = 2;
            RecipeHeaderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            RecipeHeaderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.000008F));
            RecipeHeaderLayout.Size = new System.Drawing.Size(761, 132);
            RecipeHeaderLayout.TabIndex = 2;
            // 
            // RecipeNameBox
            // 
            RecipeNameBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeHeaderLayout.SetColumnSpan(RecipeNameBox, 2);
            RecipeNameBox.Controls.Add(RecipeName);
            RecipeNameBox.Location = new System.Drawing.Point(4, 3);
            RecipeNameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeNameBox.Name = "RecipeNameBox";
            RecipeNameBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeNameBox.Size = new System.Drawing.Size(498, 54);
            RecipeNameBox.TabIndex = 2;
            RecipeNameBox.TabStop = false;
            RecipeNameBox.Text = "Name";
            // 
            // RecipeName
            // 
            RecipeName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeName.Location = new System.Drawing.Point(8, 20);
            RecipeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeName.Multiline = false;
            RecipeName.Name = "RecipeName";
            RecipeName.Size = new System.Drawing.Size(481, 20);
            RecipeName.TabIndex = 0;
            RecipeName.Tag = "Name";
            RecipeName.Text = "";
            // 
            // RecipeAuthorBox
            // 
            RecipeAuthorBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeAuthorBox.Controls.Add(RecipeAuthor);
            RecipeAuthorBox.Location = new System.Drawing.Point(510, 3);
            RecipeAuthorBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeAuthorBox.Name = "RecipeAuthorBox";
            RecipeAuthorBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeAuthorBox.Size = new System.Drawing.Size(247, 54);
            RecipeAuthorBox.TabIndex = 22;
            RecipeAuthorBox.TabStop = false;
            RecipeAuthorBox.Text = "Author";
            // 
            // RecipeAuthor
            // 
            RecipeAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RecipeAuthor.Location = new System.Drawing.Point(8, 20);
            RecipeAuthor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RecipeAuthor.Name = "RecipeAuthor";
            RecipeAuthor.Size = new System.Drawing.Size(231, 20);
            RecipeAuthor.TabIndex = 0;
            RecipeAuthor.Tag = "Author";
            RecipeAuthor.Text = "";
            // 
            // PrepTimeBox
            // 
            PrepTimeBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PrepTimeBox.Controls.Add(PrepTimeLayout);
            PrepTimeBox.Location = new System.Drawing.Point(2, 63);
            PrepTimeBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            PrepTimeBox.Name = "PrepTimeBox";
            PrepTimeBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            PrepTimeBox.Size = new System.Drawing.Size(249, 66);
            PrepTimeBox.TabIndex = 1;
            PrepTimeBox.TabStop = false;
            PrepTimeBox.Tag = "Preparation Time";
            PrepTimeBox.Text = "Prep Time";
            // 
            // PrepTimeLayout
            // 
            PrepTimeLayout.ColumnCount = 3;
            PrepTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            PrepTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            PrepTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            PrepTimeLayout.Controls.Add(PrepHoursLabel, 0, 0);
            PrepTimeLayout.Controls.Add(PrepDaysLabel, 0, 0);
            PrepTimeLayout.Controls.Add(PrepMinutesLabel, 1, 0);
            PrepTimeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            PrepTimeLayout.Location = new System.Drawing.Point(2, 17);
            PrepTimeLayout.Name = "PrepTimeLayout";
            PrepTimeLayout.RowCount = 1;
            PrepTimeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            PrepTimeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            PrepTimeLayout.Size = new System.Drawing.Size(245, 46);
            PrepTimeLayout.TabIndex = 6;
            // 
            // PrepHoursLabel
            // 
            PrepHoursLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            PrepHoursLabel.Location = new System.Drawing.Point(85, 0);
            PrepHoursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PrepHoursLabel.Name = "PrepHoursLabel";
            PrepHoursLabel.Size = new System.Drawing.Size(73, 46);
            PrepHoursLabel.TabIndex = 6;
            PrepHoursLabel.Tag = "Days";
            PrepHoursLabel.Text = "0 Hours";
            PrepHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PrepHoursLabel.Leave += Time_Leave;
            PrepHoursLabel.MouseClick += Time_Mouse_Click;
            // 
            // PrepDaysLabel
            // 
            PrepDaysLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            PrepDaysLabel.Location = new System.Drawing.Point(4, 0);
            PrepDaysLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PrepDaysLabel.Name = "PrepDaysLabel";
            PrepDaysLabel.Size = new System.Drawing.Size(73, 46);
            PrepDaysLabel.TabIndex = 5;
            PrepDaysLabel.Tag = "Minutes";
            PrepDaysLabel.Text = "0 Days";
            PrepDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PrepDaysLabel.Leave += Time_Leave;
            PrepDaysLabel.MouseClick += Time_Mouse_Click;
            // 
            // PrepMinutesLabel
            // 
            PrepMinutesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            PrepMinutesLabel.Location = new System.Drawing.Point(166, 0);
            PrepMinutesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PrepMinutesLabel.Name = "PrepMinutesLabel";
            PrepMinutesLabel.Size = new System.Drawing.Size(75, 46);
            PrepMinutesLabel.TabIndex = 4;
            PrepMinutesLabel.Tag = "Hours";
            PrepMinutesLabel.Text = "0 Minutes";
            PrepMinutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PrepMinutesLabel.Leave += Time_Leave;
            PrepMinutesLabel.MouseClick += Time_Mouse_Click;
            // 
            // CookTimeBox
            // 
            CookTimeBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            CookTimeBox.Controls.Add(CookTimeLayout);
            CookTimeBox.Location = new System.Drawing.Point(255, 63);
            CookTimeBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            CookTimeBox.Name = "CookTimeBox";
            CookTimeBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            CookTimeBox.Size = new System.Drawing.Size(249, 66);
            CookTimeBox.TabIndex = 19;
            CookTimeBox.TabStop = false;
            CookTimeBox.Tag = "Cook Time";
            CookTimeBox.Text = "Cook Time";
            // 
            // CookTimeLayout
            // 
            CookTimeLayout.ColumnCount = 3;
            CookTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            CookTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            CookTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            CookTimeLayout.Controls.Add(CookTimeDaysLabel, 0, 0);
            CookTimeLayout.Controls.Add(CookTimeHoursLabel, 1, 0);
            CookTimeLayout.Controls.Add(CookTimeMinuteLabel, 2, 0);
            CookTimeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            CookTimeLayout.Location = new System.Drawing.Point(2, 17);
            CookTimeLayout.Name = "CookTimeLayout";
            CookTimeLayout.RowCount = 1;
            CookTimeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            CookTimeLayout.Size = new System.Drawing.Size(245, 46);
            CookTimeLayout.TabIndex = 2;
            // 
            // CookTimeDaysLabel
            // 
            CookTimeDaysLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            CookTimeDaysLabel.Location = new System.Drawing.Point(4, 0);
            CookTimeDaysLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CookTimeDaysLabel.Name = "CookTimeDaysLabel";
            CookTimeDaysLabel.Size = new System.Drawing.Size(73, 46);
            CookTimeDaysLabel.TabIndex = 6;
            CookTimeDaysLabel.Tag = "Days";
            CookTimeDaysLabel.Text = "0 Days";
            CookTimeDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            CookTimeDaysLabel.Leave += Time_Leave;
            CookTimeDaysLabel.MouseClick += Time_Mouse_Click;
            // 
            // CookTimeHoursLabel
            // 
            CookTimeHoursLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            CookTimeHoursLabel.Location = new System.Drawing.Point(85, 0);
            CookTimeHoursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CookTimeHoursLabel.Name = "CookTimeHoursLabel";
            CookTimeHoursLabel.Size = new System.Drawing.Size(73, 46);
            CookTimeHoursLabel.TabIndex = 7;
            CookTimeHoursLabel.Tag = "Hours";
            CookTimeHoursLabel.Text = "0 Hours";
            CookTimeHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            CookTimeHoursLabel.Leave += Time_Leave;
            CookTimeHoursLabel.MouseClick += Time_Mouse_Click;
            // 
            // CookTimeMinuteLabel
            // 
            CookTimeMinuteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            CookTimeMinuteLabel.Location = new System.Drawing.Point(166, 0);
            CookTimeMinuteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CookTimeMinuteLabel.Name = "CookTimeMinuteLabel";
            CookTimeMinuteLabel.Size = new System.Drawing.Size(75, 46);
            CookTimeMinuteLabel.TabIndex = 8;
            CookTimeMinuteLabel.Tag = "Minutes";
            CookTimeMinuteLabel.Text = "0 Minutes";
            CookTimeMinuteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            CookTimeMinuteLabel.Leave += Time_Leave;
            CookTimeMinuteLabel.MouseClick += Time_Mouse_Click;
            // 
            // TotalTimeBox
            // 
            TotalTimeBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TotalTimeBox.Controls.Add(TotalTimeValue);
            TotalTimeBox.Location = new System.Drawing.Point(510, 63);
            TotalTimeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TotalTimeBox.Name = "TotalTimeBox";
            TotalTimeBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TotalTimeBox.Size = new System.Drawing.Size(247, 66);
            TotalTimeBox.TabIndex = 20;
            TotalTimeBox.TabStop = false;
            TotalTimeBox.Text = "Total Time";
            // 
            // TotalTimeValue
            // 
            TotalTimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            TotalTimeValue.Location = new System.Drawing.Point(4, 17);
            TotalTimeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TotalTimeValue.Name = "TotalTimeValue";
            TotalTimeValue.Size = new System.Drawing.Size(239, 46);
            TotalTimeValue.TabIndex = 1;
            TotalTimeValue.Text = "0 Days 0 Hours 0 Minutes";
            TotalTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecipeHeader
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            Controls.Add(RecipeHeaderLayout);
            Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "RecipeHeader";
            Size = new System.Drawing.Size(761, 132);
            RecipeHeaderLayout.ResumeLayout(false);
            RecipeNameBox.ResumeLayout(false);
            RecipeAuthorBox.ResumeLayout(false);
            PrepTimeBox.ResumeLayout(false);
            PrepTimeLayout.ResumeLayout(false);
            CookTimeBox.ResumeLayout(false);
            CookTimeLayout.ResumeLayout(false);
            TotalTimeBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel RecipeHeaderLayout;
        public System.Windows.Forms.GroupBox RecipeAuthorBox;
        public System.Windows.Forms.RichTextBox RecipeAuthor;
        public System.Windows.Forms.GroupBox CookTimeBox;
        public System.Windows.Forms.TableLayoutPanel CookTimeLayout;
        public System.Windows.Forms.Label CookTimeDaysLabel;
        public System.Windows.Forms.Label CookTimeMinuteLabel;
        public System.Windows.Forms.Label CookTimeHoursLabel;
        public System.Windows.Forms.GroupBox TotalTimeBox;
        public System.Windows.Forms.Label TotalTimeValue;
        public System.Windows.Forms.GroupBox RecipeNameBox;
        public System.Windows.Forms.RichTextBox RecipeName;
        public System.Windows.Forms.GroupBox PrepTimeBox;
        public System.Windows.Forms.TableLayoutPanel PrepTimeLayout;
        public System.Windows.Forms.Label PrepMinutesLabel;
        public System.Windows.Forms.Label PrepDaysLabel;
        public System.Windows.Forms.Label PrepHoursLabel;
    }
}
