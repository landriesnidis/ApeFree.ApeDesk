using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApeFree.ApeDesk.Win.XMaster
{
    public class GlobalSettings
    {
        public MasterSettings Master { get; set; }
        public List<SlaveSettings> Slaves { get; set; }

        public GlobalSettings()
        {
            Master = new MasterSettings();
            Slaves = new List<SlaveSettings>();
        }

        public SlaveSettings GetSlaveSettings(string slaveId)
        {
            if (!Slaves.Any(x => x.SlaveId == slaveId))
            {
                var slave = new SlaveSettings() { SlaveId = slaveId };
                Slaves.Add(slave);
                return slave;
            }

            return Slaves.First(x => x.SlaveId == slaveId);
        }
    }

    public class MasterSettings
    {
        public string BrokerAddress { get; set; } = "127.0.0.1";
        public int BrokerPort { get; set; } = 1883;

        public string FileDistributionFolder { get; set; } = string.Empty;
    }

    public class SlaveSettings
    {
        public string SlaveId { get; set; } = string.Empty;
        public string ProcessGuardPath { get; set; } = string.Empty;
        public bool ProcessGuardEnable { get; set; }
        public string FileDistributionPath { get; set; } = string.Empty;
        public bool FileDistributionEnable { get; set; }
    }
}
