using System.Text;
using UnityEngine.UI;

namespace Supyrb
{
	using UnityEngine;
	using System.Collections;

    [RequireComponent(typeof(Text))]
	public class SystemInfoText : MonoBehaviour
    {
        [SerializeField]
        private Text text;

        private StringBuilder sb;
        void Start () 
		{
            sb = new StringBuilder();
            UpdateInfoText();
		}

        private void UpdateInfoText()
        {
            sb.Append("Device Name: ");
            sb.AppendLine(SystemInfo.deviceName);
            sb.Append("Device Type: ");
            sb.AppendLine(SystemInfo.deviceType.ToString());
            sb.Append("Model Name: ");
            sb.AppendLine(SystemInfo.deviceModel);
            sb.Append("OS: ");
            sb.AppendLine(SystemInfo.operatingSystem);
            sb.Append("System language: ");
            sb.AppendLine(Application.systemLanguage.ToString());
            sb.Append("CPU: ");
            sb.Append(SystemInfo.processorType + " x " + SystemInfo.processorCount);
            sb.Append(" @ ");
            sb.AppendLine(SystemInfo.processorFrequency + "MHz");
            sb.Append("Memory: ");
            sb.Append(SystemInfo.systemMemorySize.ToString("#,0"));
            sb.AppendLine("kB (VRAM:" + SystemInfo.graphicsMemorySize.ToString("#,0") + "kB)");
            sb.Append("GPU: ");
            sb.AppendLine(SystemInfo.graphicsDeviceName + " (ID:" + SystemInfo.graphicsDeviceID + ")");
            sb.Append("Supported shader model: ");
            sb.AppendLine(SystemInfo.graphicsShaderLevel.ToString());
            sb.Append("Vendor: ");
            sb.AppendLine(SystemInfo.graphicsDeviceVendor + " (ID:" + SystemInfo.graphicsDeviceVendorID + ")");
            sb.Append("Driver: ");
            sb.AppendLine(SystemInfo.graphicsDeviceVersion + " (SM:" + SystemInfo.graphicsShaderLevel + ")");
            sb.Append("Resolution: ");
            sb.AppendLine(Screen.width + " x " + Screen.height);
            sb.Append("UDID: ");
            sb.AppendLine(SystemInfo.deviceUniqueIdentifier);
            

            text.text = sb.ToString();
        }

        void Reset()
        {
            if (text == null)
            {
                text = GetComponent<Text>();
            }
        }
	}
}