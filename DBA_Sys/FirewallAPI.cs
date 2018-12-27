﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetFwTypeLib;

namespace DBA_Sys
{
    public static class FirewallAPI
    {
        private static INetFwPolicy2 _firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

        //public enum FirewallAction 
        //{ 
        // Block = 0, 
        // Allow = 1, 
        // Max = 2 
        //} 
        //public enum FirewallDirection 
        //{ 
        // In = 1, 
        // Out = 2, 
        // Max = 3 
        //} 

        public enum Protocol
        {
            Tcp = 6, Udp = 0x11, Any = 0x100
        }

        public static bool AddInboudRule(string name, string programFullPath)
        {
            if (IsInboundRuleExist(name, programFullPath) == true)
            {
                return true;
            }

            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            newRule.Name = name;
            newRule.ApplicationName = programFullPath;
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_ANY;
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
            newRule.Enabled = true;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            _firewallPolicy.Rules.Add(newRule);

            return IsInboundRuleExist(name, programFullPath);
        }

        private static bool IsInboundRuleExist(string name, string programFullPath)
        {
            return _firewallPolicy.Rules.Cast<INetFwRule>().Any(rule => rule.Name == name && rule.ApplicationName == programFullPath);
        }

        private static bool IsInboundRuleExist(string name, Protocol protocol, int port)
        {
            return _firewallPolicy.Rules.Cast<INetFwRule>().Any(r => r.Name == name && r.Protocol == (int)protocol && r.LocalPorts == port.ToString());
        }

        private static bool IsInboundRuleExist(string name, Protocol protocol)
        {
            return _firewallPolicy.Rules.Cast<INetFwRule>().Any(r => r.Name == name && r.Protocol == (int)protocol);
        }

        public static bool AddInboudRule(string name, Protocol protocol, int port)
        {
            if (IsInboundRuleExist(name, protocol, port) == true)
            {
                return true;
            }

            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));

            newRule.Name = name; newRule.Protocol = (int) protocol;
            newRule.LocalPorts = port.ToString();
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
            newRule.Enabled = true;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            _firewallPolicy.Rules.Add(newRule);
            return IsInboundRuleExist(name, protocol, port);
        }

        public static bool RemoveInboundRule(string name, Protocol protocol, int port)
        {
            if (IsInboundRuleExist(name, protocol, port) == false)
            {
                return true;
            }
            INetFwRule rule = _firewallPolicy.Rules.Cast<INetFwRule>().FirstOrDefault(r => r.Name == name && r.Protocol == (int) protocol && r.LocalPorts.Contains(port.ToString()));

            if (rule != null)
            {
                _firewallPolicy.Rules.Remove(name);
            }

            return IsInboundRuleExist(name, protocol, port) == false;

        }

        public static bool RemoveInboundRule(string name, Protocol protocol)
        {
            if (IsInboundRuleExist(name, protocol) == false)
            {
                return true;
            }

            INetFwRule rule = _firewallPolicy.Rules.Cast<INetFwRule>().FirstOrDefault(r => r.Name == name && r.Protocol == (int)protocol);

            if (rule != null)
            {
                _firewallPolicy.Rules.Remove(name);
            }
            return IsInboundRuleExist(name, protocol) == false;
        }

    }

     
}
