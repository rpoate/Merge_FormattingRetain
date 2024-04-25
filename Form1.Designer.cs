namespace Merge_Formatting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            htmlEditControl1 = new Zoople.HTMLEditControl();
            SuspendLayout();
            // 
            // htmlEditControl1
            // 
            htmlEditControl1.AcceptsReturn = true;
            htmlEditControl1.BaseURL = null;
            htmlEditControl1.CleanMSWordHTMLOnPaste = true;
            htmlEditControl1.CSSText = null;
            htmlEditControl1.Dock = DockStyle.Fill;
            htmlEditControl1.DocumentHTML = null;
            htmlEditControl1.EnableInlineSpelling = false;
            htmlEditControl1.FontSizesList = null;
            htmlEditControl1.FontsList = null;
            htmlEditControl1.HiddenButtons = null;
            htmlEditControl1.ImageStorageLocation = null;
            htmlEditControl1.InCodeView = false;
            htmlEditControl1.IndentAmount = 2;
            htmlEditControl1.IndentsUseBlockuote = false;
            htmlEditControl1.LanguageFile = null;
            htmlEditControl1.LicenceActivationKey = null;
            htmlEditControl1.LicenceKey = null;
            htmlEditControl1.LicenceKeyInlineSpelling = null;
            htmlEditControl1.Location = new Point(0, 0);
            htmlEditControl1.Name = "htmlEditControl1";
            htmlEditControl1.Size = new Size(800, 450);
            htmlEditControl1.TabIndex = 0;
            htmlEditControl1.ToolstripImageScalingSize = new Size(16, 16);
            htmlEditControl1.UseParagraphAsDefault = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(htmlEditControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Zoople.HTMLEditControl htmlEditControl1;
    }
}
