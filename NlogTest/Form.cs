using System;
using NLog;
using NLogForm;
using System.Windows.Forms;
using NLog.Fluent;

namespace NLogTest
{
    public partial class Form : System.Windows.Forms.Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public Form()
        {
            InitializeComponent();
            PanelShowForm(panel, new LogForm());
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
        public static void PanelShowForm(Panel panel, System.Windows.Forms.Form form)
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
            new FormOther().Show();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Logger.Debug("test");
            Logger.Info("test");
            Logger.Warn("test");
            Logger.Error("test");
            Test.Test1();
            Test.Test2();
        }
    }

    public static class Test
    {
        static Logger logger = LogManager.GetCurrentClassLogger();

        public static void Test1()
        {
            try
            {
                logger.Debug("test1");
                logger.Info("test1");
                logger.Warn("test1");
                logger.Error(new Exception("test1"), "test1");
                throw new ApplicationException("test1");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "test1 错误");
            }
        }

        public static void Test2()
        {
            logger.Debug("test2");
            logger.Info("test2");
            logger.Warn("test2");
            logger.Error(new Exception("test2"), "test2");
        }
    }
}