using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Tekla.Structures.Model.Operations;

namespace BourneIssueApp
{
    public partial class ExecutionForm : Form
    {
        readonly bool BswxIsSelected;
        public ExecutionForm(bool bswxIsSelected)
        {
            this.InitializeComponent();
            this.BswxIsSelected = bswxIsSelected;
        }

        public void UpdateLabel(string str)
        {
            this.label.Text = str + " ...";
            Operation.DisplayPrompt(str + " ...");
            this.label.Update();
            Thread.Sleep(42);
        }

        public void UpdateLabel(string str, int number)
        {
            this.label.Text = str + " Phase " + number + " ...";
            Operation.DisplayPrompt(str + " Phase " + number + " ...");
            this.label.Update();
            Thread.Sleep(42);
        }

        private void ExecutionForm_Load(object sender, System.EventArgs e)
        {
            if (this.BswxIsSelected)
            {
                var x = this.Location.X;
                var y = this.Location.Y - 200;
                this.Location = new Point(x, y);
            }
        }
    }
}