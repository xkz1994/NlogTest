using NLog;
using NLog.Windows.Forms;
using System.Windows.Forms;

namespace NlogForm
{
    public partial class LogForm : Form
    {
        public static readonly LogForm Instance = new LogForm();

        public LogForm()
        {
            InitializeComponent();
            RichTextBoxTarget.ReInitializeAllTextboxes(this); // 将 NLog Target 附加到 RichTextBox
        }
    }
}