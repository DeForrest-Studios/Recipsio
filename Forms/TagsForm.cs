﻿using RecipeManager;
using System.Diagnostics;
using System.Windows.Forms;

namespace Recipsio.Forms
{
    public partial class TagsForm : Form
    {
        public TagsForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        private void Form_KeyDown(object Sender, KeyEventArgs KeyEvent)
        {
            if (KeyEvent.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
