namespace Supyrb
{
	using UnityEngine;
	using System.Collections;

	public class AccelorometerTester : MonoBehaviour 
	{
		
		void FixedUpdate ()
		{
		    transform.rotation = Quaternion.Euler(
                new Vector3(-Input.acceleration.y, Input.acceleration.x, Input.acceleration.z) *90f);
		}
	}
}