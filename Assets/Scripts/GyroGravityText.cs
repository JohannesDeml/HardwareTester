using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GyroGravityText : MonoBehaviour {

    private Text text;
    void OnEnable()
    {
        text = GetComponent<Text>();
    }

    void FixedUpdate()
    {
        Vector3 gyroGravity = Input.gyro.gravity;
        text.text = String.Format("(X:{0} Y:{1} Z:{2})",
            gyroGravity.x.ToString("0.0"), gyroGravity.y.ToString("0.0"), gyroGravity.z.ToString("0.0"));
    }
}
