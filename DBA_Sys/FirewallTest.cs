using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetFwTypeLib;

namespace DBA_Sys
{
    class FirewallTest
    {
        public static void Inbound(string name, string filePath)
        {
            INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            firewallRule.Description = "방화벽 규칙에 대한 설명을 입력합니다";
            firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
            firewallRule.ApplicationName = filePath;
            firewallRule.InterfaceTypes = "All";
            firewallRule.Name = name; // 방화벽 규칙을 구분하는 이름, 삭제시에도 사용됩니다
            firewallRule.Enabled = true;

            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Add(firewallRule);
        }
    }
}
