﻿using RecipeManager;
using System.Diagnostics;
using System.Windows.Forms;

namespace Recipsio.Forms
{
    public partial class HelpForm : Form
    {
        public HelpForm()
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
