namespace Recipsio
{
    partial class RecipeIngredientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeIngredientForm));
            SubmitIngredient = new System.Windows.Forms.Button();
            IngredientChoice = new System.Windows.Forms.ComboBox();
            MeasurementChoice = new System.Windows.Forms.ComboBox();
            MeasurementAmount = new System.Windows.Forms.TextBox();
            AmountLabel = new System.Windows.Forms.Label();
            MeasurementLabel = new System.Windows.Forms.Label();
            IngredientLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // SubmitIngredient
            // 
            SubmitIngredient.Location = new System.Drawing.Point(138, 74);
            SubmitIngredient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SubmitIngredient.Name = "SubmitIngredient";
            SubmitIngredient.Size = new System.Drawing.Size(88, 25);
            SubmitIngredient.TabIndex = 0;
            SubmitIngredient.Text = "Submit";
            SubmitIngredient.UseVisualStyleBackColor = true;
            SubmitIngredient.Click += Submit_Recipe_Ingredient_Click;
            // 
            // IngredientChoice
            // 
            IngredientChoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            IngredientChoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            IngredientChoice.FormattingEnabled = true;
            IngredientChoice.Location = new System.Drawing.Point(179, 26);
            IngredientChoice.Name = "IngredientChoice";
            IngredientChoice.Size = new System.Drawing.Size(162, 23);
            IngredientChoice.TabIndex = 1;
            // 
            // MeasurementChoice
            // 
            MeasurementChoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            MeasurementChoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            MeasurementChoice.FormattingEnabled = true;
            MeasurementChoice.Items.AddRange(new object[] { "Tsp (Teaspoon)", "Tbsp (Tablespoon)", "Cup (Cup)", "Fl oz (Fluid Ounce)", "Pt (Pint)", "Qt (Quart)", "Gal (Gallon)", "Ml (Milliliter)", "L (Liter)", "G (Gram)", "Kg (Kilogram)", "Oz (Ounce)", "Lb (Pound)", "Pinch", "Dash", "Drop", "Mg (Milligram)", "Cm (Centimeter)", "In (Inch)", "Mm (Millimeter)", "Slice", "Whole", "Handful", "Clove", "Sprig", "Stick", "Head", "Packet", "Can", "Jar", "Bunch", "Stalk", "Bulb", "Square", "Round", "Cupcake liner", "Sheet", "Leaf", "Fillet", "Slab", "Cube", "Wedge", "Segment", "Portion", "Grain", "Scoop", "Dollop" });
            MeasurementChoice.Location = new System.Drawing.Point(90, 26);
            MeasurementChoice.Name = "MeasurementChoice";
            MeasurementChoice.Size = new System.Drawing.Size(83, 23);
            MeasurementChoice.TabIndex = 2;
            // 
            // MeasurementAmount
            // 
            MeasurementAmount.Location = new System.Drawing.Point(24, 26);
            MeasurementAmount.Name = "MeasurementAmount";
            MeasurementAmount.Size = new System.Drawing.Size(60, 21);
            MeasurementAmount.TabIndex = 3;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new System.Drawing.Point(30, 8);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new System.Drawing.Size(49, 15);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Amount";
            // 
            // MeasurementLabel
            // 
            MeasurementLabel.AutoSize = true;
            MeasurementLabel.Location = new System.Drawing.Point(90, 6);
            MeasurementLabel.Name = "MeasurementLabel";
            MeasurementLabel.Size = new System.Drawing.Size(83, 15);
            MeasurementLabel.TabIndex = 5;
            MeasurementLabel.Text = "Measurement";
            // 
            // IngredientLabel
            // 
            IngredientLabel.AutoSize = true;
            IngredientLabel.Location = new System.Drawing.Point(229, 7);
            IngredientLabel.Name = "IngredientLabel";
            IngredientLabel.Size = new System.Drawing.Size(62, 15);
            IngredientLabel.TabIndex = 6;
            IngredientLabel.Text = "Ingredient";
            // 
            // RecipeIngredientForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 245, 229);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(365, 111);
            Controls.Add(IngredientLabel);
            Controls.Add(MeasurementLabel);
            Controls.Add(AmountLabel);
            Controls.Add(MeasurementAmount);
            Controls.Add(MeasurementChoice);
            Controls.Add(IngredientChoice);
            Controls.Add(SubmitIngredient);
            Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "RecipeIngredientForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add Ingredient";
            KeyDown += Form_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Button SubmitIngredient;
        public System.Windows.Forms.ComboBox IngredientChoice;
        public System.Windows.Forms.ComboBox MeasurementChoice;
        public System.Windows.Forms.TextBox MeasurementAmount;
        public System.Windows.Forms.Label AmountLabel;
        public System.Windows.Forms.Label MeasurementLabel;
        public System.Windows.Forms.Label IngredientLabel;
    }
}