using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Challenge {
	public class LightBulb : MonoBehaviour {

		#region Public Members
		
		public bool IsOn { get; set; }
		
		#endregion

		#region Private Members
		
		[SerializeField]
		Animator 	_bulbAnimator;
		[SerializeField]
		string		_bulbOnOffParameter;
		
		#endregion

		#region Public Members
		
		public void ToggleLightBulb(bool onOff) {
			if (_bulbAnimator == null) {
				Debug.LogError(string.Format("No animator object is assigned on {0}", name));
				return;
			}
			IsOn = onOff;
			_bulbAnimator.SetBool(_bulbOnOffParameter, onOff);
		}
		
		#endregion
		
	}
}

