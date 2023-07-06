using NLog;
using NLog.Windows.Forms;
using System.Windows.Forms;

namespace NlogForm
{
    public partial class LogForm1 : Form
    {
        public static LogForm1 Instance = new LogForm1();

        public LogForm1()
        {
            InitializeComponent();
            RichTextBoxTarget.ReInitializeAllTextboxes(this); // 将 NLog Target 附加到 RichTextBox
        }
    }
}