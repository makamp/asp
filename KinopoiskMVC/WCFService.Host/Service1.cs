using System;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceProcess;

namespace WCFService.Host
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            StartWCFService();
        }

        protected override void OnStop()
        {
            StopWCFService();
        }

        private ServiceHost _host;

        public void AddLog(string log)
        {
            try
            {
                if (!EventLog.SourceExists("FilmsService"))
                {
                    EventLog.CreateEventSource("FilmsService", "FilmsService");
                }
                eventLog1.Source = "FilmsService";
                eventLog1.WriteEntry(log);
            }
            catch { }
        }

        public void StartWCFService()
        {
            try
            {
                _host = new ServiceHost(typeof(Service));
                _host.Open();

                AddLog("started");
            }
            catch (Exception ex)
            {
                AddLog("start is failed: " + ex.Message);
            }
        }

        public void StopWCFService()
        {
            AddLog("stopped");

            if (_host == null) return;
            try
            {
                _host.Close();
            }
            catch
            {
                _host.Abort();
            }
            _host = null;
        }
    }
}
