using System;
using UnityEngine.UI;

namespace Supyrb
{
	using UnityEngine;
	using System.Collections;

    [RequireComponent(typeof(Text))]
	public class AccelerometerText : MonoBehaviour
    {
        private Text text;
		void OnEnable ()
		{
		    text = GetComponent<Text>();
		}
		
		void FixedUpdate ()
		{
		    Vector3 acc = Input.acceleration;
		    text.text = String.Format("(X:{0} Y:{1} Z:{2})", 
                acc.x.ToString("0.00"), acc.y.ToString("0.00"), acc.z.ToString("0.00"));
		}
	}
}