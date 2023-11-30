namespace Recipsio
{
    partial class AddIngredientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIngredientForm));
            button1 = new System.Windows.Forms.Button();
            IngredientChoice = new System.Windows.Forms.ComboBox();
            MeasurementChoice = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(93, 74);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 25);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // IngredientChoice
            // 
            IngredientChoice.FormattingEnabled = true;
            IngredientChoice.Location = new System.Drawing.Point(101, 26);
            IngredientChoice.Name = "IngredientChoice";
            IngredientChoice.Size = new System.Drawing.Size(162, 23);
            IngredientChoice.TabIndex = 1;
            // 
            // MeasurementChoice
            // 
            MeasurementChoice.FormattingEnabled = true;
            MeasurementChoice.Items.AddRange(new object[] { "Tsp (Teaspoon)", "Tbsp (Tablespoon)", "Cup (Cup)", "Fl oz (Fluid Ounce)", "Pt (Pint)", "Qt (Quart)", "Gal (Gallon)", "Ml (Milliliter)", "L (Liter)", "G (Gram)", "Kg (Kilogram)", "Oz (Ounce)", "Lb (Pound)", "Pinch", "Dash", "Drop", "Mg (Milligram)", "Cm (Centimeter)", "In (Inch)", "Mm (Millimeter)", "Slice", "Whole", "Handful", "Clove", "Sprig", "Stick", "Head", "Packet", "Can", "Jar", "Bunch", "Stalk", "Bulb", "Square", "Round", "Cupcake liner", "Sheet", "Leaf", "Fillet", "Slab", "Cube", "Wedge", "Segment", "Portion", "Grain", "Scoop", "Dollop" });
            MeasurementChoice.Location = new System.Drawing.Point(12, 26);
            MeasurementChoice.Name = "MeasurementChoice";
            MeasurementChoice.Size = new System.Drawing.Size(83, 23);
            MeasurementChoice.TabIndex = 2;
            // 
            // AddIngredientForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(275, 111);
            Controls.Add(MeasurementChoice);
            Controls.Add(IngredientChoice);
            Controls.Add(button1);
            Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AddIngredientForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add Ingredient";
            KeyDown += Form_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox IngredientChoice;
        private System.Windows.Forms.ComboBox MeasurementChoice;
    }
}