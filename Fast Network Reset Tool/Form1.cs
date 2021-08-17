using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Management;

namespace Fast_Network_Reset_Tool
{
    public partial class Form1 : Form
    {
        private const int ADAPTER_NAME = 0;
        private const int STATUS = 1;
        private const int MAC_ADDRESS = 2;

        public Form1()
        {
            InitializeComponent();
            updateNetworkAdaptersList();
        }

        public void updateNetworkAdaptersList()
        {
            if (this.listView1.Items.Count > 0)
            {
                this.listView1.Items.Clear();
            }

            ObjectQuery adapterQuery = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(adapterQuery);
            ManagementObjectCollection objectCollection = managementObjectSearcher.Get();
            
            foreach (ManagementObject adapter in objectCollection)
            {
                if (adapter == null)
                    continue;
                
                if (adapter["NetConnectionID"] != null || 
                    adapter["NetConnectionStatus"] != null ||
                    adapter["MACAddress"] != null)
                {
                    string[] row = new string[3];

                    row[ADAPTER_NAME] = adapter["NetConnectionID"] as string;

                    if (row[ADAPTER_NAME] == null)
                        continue;

                    // No need for an enum since we only care about 2 scenarios
                    ushort connectionStatus = (ushort) adapter["NetConnectionStatus"];

                    if (connectionStatus != 7 && connectionStatus != 2 && connectionStatus != 0 )
                        continue;

                    if (connectionStatus == 7)
                        row[STATUS] = "Disconnected";

                    if (connectionStatus == 2)
                        row[STATUS] = "Connected";

                    if (connectionStatus == 0)
                        row[STATUS] = "Disabled";


                    row[MAC_ADDRESS] = adapter["MACAddress"] as string;

                    if (row[MAC_ADDRESS] != null && row[MAC_ADDRESS].Length == 0)
                    {
                        row[MAC_ADDRESS] = "Unknown";
                    }

                    ListViewItem rowItem = new ListViewItem(row);
                    this.listView1.Items.Add(rowItem);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                string adapterStatus = this.listView1.SelectedItems[0].SubItems[STATUS].Text;
                string adapterAddress = this.listView1.SelectedItems[0].SubItems[MAC_ADDRESS].Text;

                if (adapterStatus.Contains("Connected") || adapterStatus.Contains("Disconnected"))
                {
                    this.adapterOnButton.Enabled = false;
                    this.adapterOffButton.Enabled = true;
                } else if (adapterStatus.Contains("Disabled"))
                {
                    this.adapterOnButton.Enabled = true;
                    this.adapterOffButton.Enabled = false;
                }
            }   
        }

        private void adapterOnButton_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row", "Error", MessageBoxButtons.OK);
                return;
            }

            this.statusLabel.Text = "Status: working...";
            this.Cursor = Cursors.WaitCursor;

            string adapterNameToDisable = this.listView1.SelectedItems[0].SubItems[ADAPTER_NAME].Text;
            ObjectQuery adapterQuery = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(adapterQuery);
            ManagementObjectCollection objectCollection = managementObjectSearcher.Get();

            foreach (ManagementObject adapterItem in objectCollection)
            {
                if (adapterItem == null)
                    continue;

                string adapterName = adapterItem["NetConnectionID"] as string;
               
                if (adapterName != null && adapterName.Contains(adapterNameToDisable))
                {
                    adapterItem.InvokeMethod("Enable", null);
                    break;
                }
            }

            updateNetworkAdaptersList();

            this.statusLabel.Text = "Status: dormant";
            this.Cursor = Cursors.Default;
        }

        private void adapterOffButton_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row", "Error", MessageBoxButtons.OK);
                return;
            }

            this.statusLabel.Text = "Status: working...";
            this.Cursor = Cursors.WaitCursor;

            string adapterNameToDisable = this.listView1.SelectedItems[0].SubItems[ADAPTER_NAME].Text;
            ObjectQuery adapterQuery = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(adapterQuery);
            ManagementObjectCollection objectCollection = managementObjectSearcher.Get();

            foreach (ManagementObject adapterItem in objectCollection)
            {
                if (adapterItem == null)
                    continue;

                string adapterName = adapterItem["NetConnectionID"] as string;

                if (adapterName != null && adapterName.Contains(adapterNameToDisable))
                {
                    adapterItem.InvokeMethod("Disable", null);
                    break;
                }
            }

            updateNetworkAdaptersList();

            this.statusLabel.Text = "Status: dormant";
            this.Cursor = Cursors.Default;
        }

        private void resetAllButton_Click(object sender, EventArgs e)
        {
            if (this.listView1.Items.Count == 0)
            {
                MessageBox.Show("No adapters were detected", "Error", MessageBoxButtons.OK);
                return;
            }

            this.statusLabel.Text = "Status: working...";
            this.Cursor = Cursors.WaitCursor;

            flipNetworkAdaptersStatus();
            updateNetworkAdaptersList();
            flipNetworkAdaptersStatus();
            updateNetworkAdaptersList();

            this.statusLabel.Text = "Status: dormant";
            this.Cursor = Cursors.Default;

            MessageBox.Show("Done!", "Operation finished", MessageBoxButtons.OK);
        }

        private void flipNetworkAdaptersStatus()
        {
            ObjectQuery adapterQuery = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(adapterQuery);
            ManagementObjectCollection objectCollection = managementObjectSearcher.Get();

            foreach (ManagementObject adapterItem in objectCollection)
            {
                if (adapterItem == null || adapterItem["NetConnectionStatus"] == null)
                    continue;

                ushort connectionStatus = (ushort)adapterItem["NetConnectionStatus"];

                if (connectionStatus == 0)
                {
                    adapterItem.InvokeMethod("Enable", null);
                }
                else if (connectionStatus == 7 || connectionStatus == 2)
                {
                    adapterItem.InvokeMethod("Disable", null);
                }
            }
        }

        private void refreshList_Click(object sender, EventArgs e)
        {
            updateNetworkAdaptersList();
        }
    }
}
