using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Challenge {	
	public class LevelManager : MonoBehaviour {

		#region Private Members

		[SerializeField]
		private Level _levelController;

		#endregion

		#region MB Methods

		void Start () {
			if (_levelController == null) {
				Debug.LogError(string.Format("Level object not found! Please assign it in {0} GameObject", name));
				return;
			}
			_levelController.Initialize();
		}

		void Update () {
			if (_levelController != null)
				_levelController.UpdateLevel();
		}

		#endregion

	}
}