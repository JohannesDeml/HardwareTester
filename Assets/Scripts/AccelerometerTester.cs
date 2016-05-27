// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccelerometerTester.cs" company="Supyrb">
//   Copyright (c) 2016 Supyrb. All rights reserved.
// </copyright>
// <author>
//   Johannes Deml
//   send@johannesdeml.com
// </author>
// --------------------------------------------------------------------------------------------------------------------
namespace Supyrb
{
	using UnityEngine;
	using System.Collections;

	public class AccelerometerTester : MonoBehaviour 
	{
	    [SerializeField] private bool _rotationX = true;
	    [SerializeField] private bool _rotationY = true;
	    [SerializeField] private bool _rotationZ = true;


	    void FixedUpdate ()
		{
            Vector3 euler = Vector3.zero;
            if(_rotationX) { euler.x = -Input.acceleration.y * 90f; }
            if(_rotationY) { euler.y = Input.acceleration.x * 90f; }
            if(_rotationZ) { euler.z = Input.acceleration.z * 90f; }
            transform.localEulerAngles = euler;
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
}