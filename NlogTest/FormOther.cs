using NLog;
using NLogForm;
using System;
using System.Windows.Forms;

namespace NLogTest
{
    public partial class FormOther : System.Windows.Forms.Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public FormOther()
        {
            InitializeComponent();
            PanelShowForm(panel, new LogFormOther());
        }

        /// <summary>
        /// panel显示窗体
        /// </summary>
        /// <param name="panel">panel</param>
        /// <param name="form">窗体</param>
        public static void PanelShowForm(Panel panel, System.Windows.Forms.Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            panel.Tag = form;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logger.Debug("test");
            Logger.Info("test");
            Logger.Warn("test");
            Logger.Error("test");
        }
    }
}