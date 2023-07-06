using NlogForm;
using System.Windows.Forms;
using NLog;

namespace NlogTest
{
    public partial class Form1 : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private static readonly LogForm LogForm = LogForm.Instance;
        public Form1()
        {
            InitializeComponent();
            PanelShowForm(panel, LogForm);
            Logger.Debug("test");
            Logger.Info("test");
            Logger.Warn("test");
            Logger.Error("test");
        }

        /// <summary>
        /// panel显示窗体
        /// </summary>
        /// <param name="panel">panel</param>
        /// <param name="form">窗体</param>
        public static void PanelShowForm(Panel panel, Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            panel.Tag = form;
            form.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Logger.Debug("test");
            Logger.Info("test");
            Logger.Warn("test");
            Logger.Error("test");
        }
    }
}