// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccelorometerTester.cs" company="Supyrb">
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

	public class AccelorometerTester : MonoBehaviour 
	{
	    [SerializeField] private bool RotationX = true;
	    [SerializeField] private bool RotationY = true;
	    [SerializeField] private bool RotationZ = true;


	    void FixedUpdate ()
		{
		    Vector3 euler = Vector3.zero;
            if(RotationX) { euler.x = -Input.acceleration.y * 90f; }
            if(RotationY) { euler.y = Input.acceleration.x * 90f; }
            if(RotationZ) { euler.z = Input.acceleration.z * 90f; }
            transform.localEulerAngles = euler;
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
}