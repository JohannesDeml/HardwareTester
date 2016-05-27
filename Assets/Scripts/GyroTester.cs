using UnityEngine;
using System.Collections;

public class GyroTester : MonoBehaviour
{
    [SerializeField] private bool RotationX = true;
    [SerializeField] private bool RotationY = true;
    [SerializeField] private bool RotationZ = true;

    void Start ()
    {
        Input.gyro.enabled = true;
    }

    void Update ()
    {
        ShowHideAxes (Input.gyro.enabled);

        if (Input.gyro.enabled) {
            Quaternion q = Input.gyro.attitude;
            q.z *= -1.0f;
            if (RotationX && RotationY && RotationZ)
            {
                transform.localRotation = q;
            }
            else
            {
                Vector3 euler = Vector3.zero;
                if(RotationX) { euler.x = q.eulerAngles.x;}
                if(RotationY) { euler.y = q.eulerAngles.y;}
                if(RotationZ) { euler.z = q.eulerAngles.z;}
                transform.localEulerAngles = euler;
            }
            
        }
    }

    void ShowHideAxes (bool flag)
    {
        foreach (var r in GetComponentsInChildren<Renderer>()) {
            if (r.gameObject.name == "Axis") {
                r.enabled = flag;
            }
        }
    }

    public void RotationXEnabled(bool allowRotation)
    {
        RotationX = allowRotation;
    }

    public void RotationYEnabled(bool allowRotation)
    {
        RotationY = allowRotation;
    }

    public void RotationZEnabled(bool allowRotation)
    {
        RotationZ = allowRotation;
    }
}