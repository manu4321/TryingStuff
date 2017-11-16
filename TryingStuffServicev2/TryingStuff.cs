using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using TryingStuffServicev2.services.EntryPoint;

namespace TryingStuffServicev2
{
    public partial class TryingStuff : ServiceBase
    {
        ServiceHost _Host;
        public TryingStuff()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (_Host != null)
            {
                _Host.Close();
            }
            Uri httpUrl = new Uri("http://localhost:8090/TryingStuff/EntryPointService");
            _Host = new ServiceHost(typeof(EntryPointServiceImpl), httpUrl);
            _Host.AddServiceEndpoint(typeof(IEntryPointService), new WSHttpBinding(), "");
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            _Host.Description.Behaviors.Add(smb);

            _Host.Open();
        }

        protected override void OnStop()
        {
            if (_Host != null)
            {
                _Host.Close();
                _Host = null;
            }
        }
    }
}
