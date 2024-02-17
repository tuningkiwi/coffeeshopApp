using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshop
{
    public partial class termConfig : Form
    {
        public termConfig(int n1 = 0, int n2 = 0, int n3 = 0, int n4 = 0, int n5 = 0)
        {
            InitializeComponent();

            string[] l = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string s in l)
            {
                if(!(comPortBox.Items.Contains(s))) {
                    comPortBox.Items.Add(s);
                }
            }

            comPortBox.SelectedIndex = n1;
            baudRateBox.SelectedIndex = n2;
            parityBox.SelectedIndex = n3;
            dataBitsBox.SelectedIndex = n4;
            stopBitsBox.SelectedIndex = n5;


        }

    }
}
