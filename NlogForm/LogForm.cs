using NLog.Windows.Forms;
using System.Windows.Forms;

namespace NLogForm
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
            RichTextBoxTarget.ReInitializeAllTextboxes(this); // 将 NLog Target 附加到 RichTextBox
        }
    }
}