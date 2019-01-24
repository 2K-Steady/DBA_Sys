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
        public static void Inbound(string name, string testDate)
        {
            INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            firewallRule.Description = "TslLocal Client 프로그램";
            firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
            firewallRule.ApplicationName = @"C:\TestBuild\" + testDate + "\\BroLauncher.exe"; // 적용 프로그램의 경로
            firewallRule.InterfaceTypes = "All";
            firewallRule.Name = name; // 방화벽 규칙을 구분하는 이름, 삭제시에도 사용됩니다
            //firewallRule.LocalPorts = "7777"; //로컬 포트
            //firewallRule.Protocol = 6;
            firewallRule.Enabled = true;
            
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Add(firewallRule);
        }
    }
}
