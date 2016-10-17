using UnityEngine;
using System.Collections;

public class GyroRotation : MonoBehaviour
{
    [SerializeField] private bool _rotationX = true;
    [SerializeField] private bool _rotationY = true;
    [SerializeField] private bool _rotationZ = true;

    void Start ()
    {
        Input.gyro.enabled = true;
    }

    void Update ()
    {
        if (Input.gyro.enabled) {
            Quaternion q = Input.gyro.attitude;
            q.z *= -1.0f;
            if (_rotationX && _rotationY && _rotationZ)
            {
                transform.localRotation = q;
            }
            else
            {
                Vector3 euler = Vector3.zero;
                if(_rotationX) { euler.x = q.eulerAngles.x;}
                if(_rotationY) { euler.y = q.eulerAngles.y;}
                if(_rotationZ) { euler.z = q.eulerAngles.z;}
                transform.localEulerAngles = euler;
            }
            
        }
    }

    public void RotationXEnabled(bool allowRotation)
    {
        _rotationX = allowRotation;
    }

    public void RotationYEnabled(bool allowRotation)
    {
        _rotationY = allowRotation;
    }

    public void RotationZEnabled(bool allowRotation)
    {
        _rotationZ = allowRotation;
    }
}