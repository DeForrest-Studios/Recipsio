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
            RecipeIcon = new System.Windows.Forms.PictureBox();
            RecipeListLayout = new System.Windows.Forms.TableLayoutPanel();
            RecipeList = new System.Windows.Forms.ListBox();
            Search = new System.Windows.Forms.RichTextBox();
            Header = new RecipeHeader();
            Information = new RecipeInformation();
            Tools = new Toolstrip();
            FormLayout.SuspendLayout();
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
            FormLayout.Controls.Add(RecipeIcon, 2, 0);
            FormLayout.Controls.Add(RecipeListLayout, 0, 1);
            FormLayout.Controls.Add(Header, 1, 0);
            FormLayout.Controls.Add(Information, 1, 3);
            FormLayout.Controls.Add(Tools, 0, 0);
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
            // Information
            // 
            Information.BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            FormLayout.SetColumnSpan(Information, 2);
            Information.Dock = System.Windows.Forms.DockStyle.Fill;
            Information.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Information.Location = new System.Drawing.Point(250, 131);
            Information.Name = "Information";
            Information.Size = new System.Drawing.Size(938, 574);
            Information.TabIndex = 7;
            // 
            // Tools
            // 
            Tools.BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            Tools.Dock = System.Windows.Forms.DockStyle.Fill;
            Tools.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Tools.Location = new System.Drawing.Point(3, 3);
            Tools.Name = "Tools";
            Tools.Size = new System.Drawing.Size(241, 22);
            Tools.TabIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)RecipeIcon).EndInit();
            RecipeListLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel FormLayout;

        public System.Windows.Forms.TableLayoutPanel RecipeListLayout;
        public System.Windows.Forms.RichTextBox Search;
        public System.Windows.Forms.ListBox RecipeList;
        public System.Windows.Forms.PictureBox RecipeIcon;
        public RecipeHeader Header;
        public RecipeInformation Information;
        private Toolstrip Tools;
    }
}

