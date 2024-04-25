
namespace Merge_Formatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolStripItem PerformMergeButton = this.htmlEditControl1.ToolStripItems.Add("Perform Merge");
            PerformMergeButton.Click += PerformMergeButton_Click;
            PerformMergeButton.Padding = new Padding(2);
            PerformMergeButton.Margin = new Padding(2);

            ToolStripItem ResetButton = this.htmlEditControl1.ToolStripItems.Add("Reset");
            ResetButton.Click += ResetButton_Click;
            ResetButton.Padding = new Padding(2);
            ResetButton.Margin = new Padding(2);

            this.htmlEditControl1.CSSText = "body {font-family: arial}";

            this.htmlEditControl1.DocumentHTML = "<p>Dear <a data-merge=\"Salutation\" href=\"#\"><strong>Salutation</strong></a>,</p><p>Please find a quote for <a data-merge=\"Company\" href=\"#\">Company</a>&nbsp;attached</p><p>Our records show that your email address is registered as <a data-merge=\"Email\" href=\"#\">Email</a></p><p>regards</p><p><strong>Some Other Company</strong></p>";

            this.htmlEditControl1.Focus();
        }

        private void ResetButton_Click(object? sender, EventArgs e)
        {
            this.htmlEditControl1.DocumentHTML = "<p>Dear <a data-merge=\"Salutation\" href=\"#\"><strong>Salutation</strong></a>,</p><p>Please find a quote for <a data-merge=\"Company\" href=\"#\">Company</a>&nbsp;attached</p><p>Our records show that your email address is registered as <a data-merge=\"Email\" href=\"#\">Email</a></p><p>regards</p><p><strong>Some Other Company</strong></p>";

        }

        private void PerformMergeButton_Click(object? sender, EventArgs e)
        {
            var newDoc = this.htmlEditControl1.DocumentClone;
            //htmlEditControl2.DocumentHTML = htmlEditControl1.DocumentHTML;

            foreach (HtmlElement link in newDoc.Links)
            {

                HtmlElement element = link;

                switch (link.GetAttribute("data-merge"))
                {
                    case "Salutation":
                        FindLowestChild(element).InnerText = "Mr. Smith";
                        link.OuterHtml = link.InnerHtml;
                        break;
                    case "Company":
                        FindLowestChild(element).InnerText = "Smith and Co.";
                        link.OuterHtml = link.InnerHtml;
                        break;
                    case "Email":
                        FindLowestChild(element).InnerText = "smith@smithandco.com";
                        link.SetAttribute("href", "mailto:smith@smithandco.com");
                        break;
                }
            }

            this.htmlEditControl1.DocumentHTML = newDoc.Body.InnerHtml;
        }

        private HtmlElement FindLowestChild(HtmlElement element)
        {

            if (element.Children.Count > 0)
            {
                element = FindLowestChild(element.Children[0]);
            }

            return element;

        }
    }
}
