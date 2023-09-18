using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ozeki.Media.IPCamera;
using Ozeki.Media.IPCamera.Discovery;
using Ozeki.Media.Video;
using Ozeki.Media.MediaHandlers;
using Ozeki.Media.MediaHandlers.Video;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void GuiThread(Action action)
        {
            this.Invoke(action);
        }

        private void GetUsbCameras()
        {
            var usblist = WebCamera.GetDevices();
            foreach (var device in usblist)
                GuiThread(() => DiscoverDeviceList.Items.Add("[USB] Name: " + device.Name));
        }

        private void GetIpCameras()
        {
            IPCameraFactory.DeviceDiscovered += IPCameraFactory_DeviceDiscovered;
            IPCameraFactory.DiscoverDevices();
        }

        private void IPCameraFactory_DeviceDiscovered(object sender, DiscoveryEventArgs e)
        {
            GuiThread(() => DiscoverDeviceList.Items.Add("[IPCamera] Host: " + e.Device.Host +
                " Port: " + e.Device.Port));
        }

        private void DiscoverButton_Click(object sender, EventArgs e)
        {
            DiscoverDeviceList.Items.Clear();
            IPCameraFactory.DeviceDiscovered -= IPCameraFactory_DeviceDiscovered;

            GetUsbCameras();
            GetIpCameras();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // This method will be executed when the Form3 is loaded.
            // You can add your initialization code here if needed.
        }
    }
}
