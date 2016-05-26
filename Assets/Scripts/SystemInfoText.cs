using UnityEngine.UI;

namespace Supyrb
{
	using UnityEngine;
	using System.Collections;

    [RequireComponent(typeof(Text))]
	public class SystemInfoText : MonoBehaviour
    {
        private Text text;
        void Start () 
		{
            text = GetComponent<Text>();
            UpdateInfoText();
		}

        private void UpdateInfoText()
        {
            var infoText = "";
            infoText += "Device Name: " + SystemInfo.deviceName + "\n";
            infoText += "Device Type: " + SystemInfo.deviceType + "\n";
            infoText += "Model Name: " + SystemInfo.deviceModel + "\n";
            infoText += "OS: " + SystemInfo.operatingSystem + "\n";
            infoText += "CPU: " + SystemInfo.processorType + " x " + SystemInfo.processorCount + "\n";
            infoText += "Memory: " + SystemInfo.systemMemorySize.ToString("#,0") + "kB (VRAM:" + SystemInfo.graphicsMemorySize.ToString("#,0") + "kB)\n";
            infoText += "GPU: " + SystemInfo.graphicsDeviceName + " (ID:" + SystemInfo.graphicsDeviceID + ")\n";
            infoText += "Vendor: " + SystemInfo.graphicsDeviceVendor + " (ID:" + SystemInfo.graphicsDeviceVendorID + ")\n";
            infoText += "Driver: " + SystemInfo.graphicsDeviceVersion + " (SM:" + SystemInfo.graphicsShaderLevel + ")\n";
            infoText += "Resolution: " + Screen.width + " x " + Screen.height + "\n";
            infoText += "UDID: " + SystemInfo.deviceUniqueIdentifier;

            text.text = infoText;
        }
	}
}