using System;
using UnityEngine.UI;

namespace Supyrb
{
	using UnityEngine;
	using System.Collections;

	public class GyroText : MonoBehaviour 
	{
        private Text text;
        void OnEnable()
        {
            text = GetComponent<Text>();
        }

        void FixedUpdate()
        {
            Quaternion q = Input.gyro.attitude;
            q.z *= -1f;
            Vector3 gyro = q.eulerAngles;
            text.text = String.Format("(X:{0} Y:{1} -Z:{2})",
                gyro.x.ToString("0"), gyro.y.ToString("0"), gyro.z.ToString("0"));
        }
    }
}