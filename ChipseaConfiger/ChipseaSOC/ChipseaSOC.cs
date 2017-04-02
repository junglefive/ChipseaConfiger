using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChipseaConfiger
{
     public abstract class ChipseaSOC
    {
        internal static CSU14PD87 currentSoc { get; set; } = null;

        // public Dictionary<string, int> dicSFR;
        // public Window  windowIOPort;
        public abstract void showWindowPortsIO();
        public abstract void initialSFR();
        public  delegate void SocEventHander(object sender, ChipseaEventArgs e);
        public abstract event SocEventHander socSetingChanged;
 
    }
    public class ChipseaEventArgs : EventArgs {
        public KeyValuePair<string, int> sfrKeyValue;
        public string commets;
        public ChipseaEventArgs(string name, int value) {
            sfrKeyValue = new KeyValuePair<string, int>(name, value);
        }
        public ChipseaEventArgs(KeyValuePair<string, int> kv, string commets)
        {
            sfrKeyValue = kv;
            this. commets = commets;
        }

    }
}
