using NLog;
using NlogForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NlogTest
{
    public partial class Form2 : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public Form2()
        {
            InitializeComponent();
            PanelShowForm(panel, LogForm.Instance);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Logger.Info("111");
        }
    }
}
