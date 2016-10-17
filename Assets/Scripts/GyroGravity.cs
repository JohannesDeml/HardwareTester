using UnityEngine;
using System.Collections;

public class GyroGravity : MonoBehaviour
{

    [SerializeField] private Transform point;

    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update ()
    {
        point.localPosition = Input.gyro.gravity;
    }
}
