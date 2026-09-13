namespace OurTiger.EITitorExtOfOurTiger
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contentSplitContainer = new System.Windows.Forms.SplitContainer();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.txtParsed = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).BeginInit();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.Panel2.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentSplitContainer
            // 
            this.contentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.contentSplitContainer.Margin = new System.Windows.Forms.Padding(1);
            this.contentSplitContainer.Name = "contentSplitContainer";
            this.contentSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // contentSplitContainer.Panel1
            // 
            this.contentSplitContainer.Panel1.Controls.Add(this.btnParse);
            this.contentSplitContainer.Panel1.Controls.Add(this.btnClear);
            this.contentSplitContainer.Panel1.Controls.Add(this.txtSource);
            // 
            // contentSplitContainer.Panel2
            // 
            this.contentSplitContainer.Panel2.Controls.Add(this.lblCopyright);
            this.contentSplitContainer.Panel2.Controls.Add(this.txtParsed);
            this.contentSplitContainer.Size = new System.Drawing.Size(299, 561);
            this.contentSplitContainer.SplitterDistance = 284;
            this.contentSplitContainer.SplitterWidth = 2;
            this.contentSplitContainer.TabIndex = 0;
            // 
            // btnParse
            // 
            this.btnParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btnParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParse.ForeColor = System.Drawing.Color.White;
            this.btnParse.Location = new System.Drawing.Point(220, 247);
            this.btnParse.Margin = new System.Windows.Forms.Padding(1);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(76, 38);
            this.btnParse.TabIndex = 1;
            this.btnParse.Text = "=>";
            this.btnParse.UseVisualStyleBackColor = false;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(4, 247);
            this.btnClear.Margin = new System.Windows.Forms.Padding(1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(36, 38);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(5, 5);
            this.txtSource.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSource.Size = new System.Drawing.Size(290, 239);
            this.txtSource.TabIndex = 0;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(5, 258);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(243, 13);
            this.lblCopyright.TabIndex = 1;
            this.lblCopyright.Text = "Copyright © 2023 by Our Tiger. All rights reserved.";
            // 
            // txtParsed
            // 
            this.txtParsed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParsed.Location = new System.Drawing.Point(5, 1);
            this.txtParsed.Margin = new System.Windows.Forms.Padding(1);
            this.txtParsed.Multiline = true;
            this.txtParsed.Name = "txtParsed";
            this.txtParsed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParsed.Size = new System.Drawing.Size(290, 253);
            this.txtParsed.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(299, 561);
            this.Controls.Add(this.contentSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "MainForm";
            this.Text = "EITitorExt of Our Tiger";
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel1.PerformLayout();
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            this.contentSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer contentSplitContainer;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtParsed;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCopyright;
    }
}

