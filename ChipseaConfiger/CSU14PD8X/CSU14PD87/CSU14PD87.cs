using ICSharpCode.AvalonEdit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipseaConfiger
{
    class CSU14PD87: ChipseaSOC
    {
        //分类
        //SFR
        public Dictionary<string, int> dicSFR = new Dictionary<string, int>();
        public CSU14PD87IOPorts windowIOPort = new CSU14PD87IOPorts();
        public override event SocEventHander socSetingChanged;
        public CSU14PD87() {
            initialSFR();
            windowIOPort.subWindChange += WindowIOPort_subWindChange;
        }

        private void WindowIOPort_subWindChange(object sender, ChipseaEventArgs e)
        {
            socEvenChange((ChipseaEventArgs)e);
        }

        public  void socEvenChange(ChipseaEventArgs csEventArgs)
        {
            socSetingChanged?.Invoke(this, csEventArgs);
        }


        public override void showWindowPortsIO()
        {
            windowIOPort.Show();
            if (windowIOPort.DialogResult == true)
            {

            }
        }
        public override void initialSFR()
        {
            dicSFR.Add("EADRH ", 0x00);
            dicSFR.Add("EADRL ", 0x00);
            dicSFR.Add("EDAT  ", 0x00);
            dicSFR.Add("WDTCON", 0x00);
            dicSFR.Add("TMOUT ", 0x00);
            dicSFR.Add("TMCON ", 0x00);
            dicSFR.Add("ADOH  ", 0x00);
            dicSFR.Add("ADOL  ", 0x00);
            dicSFR.Add("ADOLL ", 0x00);
            dicSFR.Add("ADCON ", 0x00);
            dicSFR.Add("MCK   ", 0x00);
            dicSFR.Add("PCK   ", 0x00);
            dicSFR.Add("MCK2  ", 0x00);
            dicSFR.Add("NETA  ", 0x00);
            dicSFR.Add("NETB  ", 0x00);
            dicSFR.Add("NETC  ", 0x00);
            dicSFR.Add("NETD  ", 0x00);
            dicSFR.Add("NETE  ", 0x00);
            dicSFR.Add("NETF  ", 0x00);
            dicSFR.Add("SVD   ", 0x00);
            dicSFR.Add("PT1   ", 0x00);
            dicSFR.Add("PT1EN ", 0x00);
            dicSFR.Add("PT1PU ", 0x00);
            dicSFR.Add("AIENB ", 0x00);
            dicSFR.Add("PT2   ", 0x00);
            dicSFR.Add("PT2EN ", 0x00);
            dicSFR.Add("PT2PU ", 0x00);
            dicSFR.Add("PT2MR ", 0x00);
            dicSFR.Add("PT2CON", 0x00);
            dicSFR.Add("PTINT ", 0x00);
            dicSFR.Add("INTF2 ", 0x00);
            dicSFR.Add("INTE2 ", 0x00);
            dicSFR.Add("LCD1  ", 0x00);
            dicSFR.Add("LCD2  ", 0x00);
            dicSFR.Add("LCD3  ", 0x00);
            dicSFR.Add("LCD4  ", 0x00);
            dicSFR.Add("LCD5  ", 0x00);
            dicSFR.Add("LCD6  ", 0x00);
            dicSFR.Add("LCD7  ", 0x00);
            dicSFR.Add("LCD8  ", 0x00);
            dicSFR.Add("LCD9  ", 0x00);
            dicSFR.Add("LCD10 ", 0x00);
            dicSFR.Add("LCD11 ", 0x00);
            dicSFR.Add("LCD12 ", 0x00);
            dicSFR.Add("LCD13 ", 0x00);
            dicSFR.Add("LCD14 ", 0x00);
            dicSFR.Add("LCDCN1", 0x00);
            dicSFR.Add("LCDENR", 0x00);
            dicSFR.Add("TEMPC ", 0x00);
            dicSFR.Add("WDT_C ", 0x00);
            dicSFR.Add("IOSC_C", 0x00);
            dicSFR.Add("TEST  ", 0x00);
            dicSFR.Add("SCON1 ", 0x00);
            dicSFR.Add("SCON2 ", 0x00);
            dicSFR.Add("SBUF  ", 0x00);
            dicSFR.Add("AIENB2", 0x00);
        }

    }
}
