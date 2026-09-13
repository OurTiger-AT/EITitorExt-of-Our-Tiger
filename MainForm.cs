using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OurTiger.EITitorExtOfOurTiger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.lblCopyright.Text = $"GPLv3 Copyright © 2023 - {DateTime.Now.Year} by Our Tiger (www.ourtiger.at)";
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            Parse();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetTextBoxContent(string.Empty, string.Empty);
        }

        private void Parse()
        {
            string source = Clipboard.GetText(TextDataFormat.Text);
            string corrected = Correct(source);
            SetTextBoxContent(source, corrected);
            PopulateClipBoard(corrected);
        }

        private void SetTextBoxContent(string source, string corrected)
        {
            txtSource.Text = source;
            txtParsed.Text = corrected;
        }

        private static void PopulateClipBoard(string corrected)
        {
            if (!string.IsNullOrEmpty(corrected))
                Clipboard.SetText(corrected);
        }
    }
}
