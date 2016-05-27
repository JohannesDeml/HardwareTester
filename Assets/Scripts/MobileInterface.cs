// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MobileInterface.cs" company="Supyrb">
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

	public class MobileInterface : MonoBehaviour 
	{
	    public void Vibrate()
	    {
	        Handheld.Vibrate();
	    }

	    public void CompensateSensors(bool compensate)
	    {
	        Input.compensateSensors = compensate;
	    }
	}
}