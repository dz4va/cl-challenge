using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Challenge {
	public class RobotBlackboard : MonoBehaviour {

		#region Private Members
		
		[SerializeField]
		BlackBoardFeature[]	_blackBoardFunFeatures;
		int previousFeatureIndex;
		
		#endregion

		#region MB Methods
		
		void Start() {
			if (_blackBoardFunFeatures == null) {
				Debug.LogError(string.Format("Black board fun features are not assigned on {0}", name));
				return;
			}
			if (_blackBoardFunFeatures.Length == 0) {
				Debug.LogError(string.Format("Black board fun features doesn't contain any fun features {0}", name));
				return;
			}
			foreach (BlackBoardFeature feature in _blackBoardFunFeatures) {
				feature.Initialize();
			}
			previousFeatureIndex = -1;
		}

		void Update() {
			if (_blackBoardFunFeatures != null) {
				foreach (BlackBoardFeature feature in _blackBoardFunFeatures) {
					if (feature.IsActive)
						feature.UpdateFeature();
				}
			}
		}
		
		#endregion

		#region Public Methods
		
		public void PlayRandomFunThing() {
			Debug.Log("Playing random thing");
			if (_blackBoardFunFeatures == null) {
				Debug.LogError(string.Format("Black board fun features are not assigned on {0}", name));
				return;
			}

			if (_blackBoardFunFeatures.Length == 0) {
				Debug.LogError(string.Format("Black board fun features doesn't contain any fun features {0}", name));
				return;
			}

			int randomFunFeatureIndex = Random.Range(0, _blackBoardFunFeatures.Length);
			while (randomFunFeatureIndex == previousFeatureIndex) {
				randomFunFeatureIndex = Random.Range(0, _blackBoardFunFeatures.Length);
			}
			_blackBoardFunFeatures[randomFunFeatureIndex].Activate();

			if (previousFeatureIndex != -1 && previousFeatureIndex != randomFunFeatureIndex) {
				_blackBoardFunFeatures[previousFeatureIndex].Stop();
			}

			previousFeatureIndex = randomFunFeatureIndex;
		}
		
		#endregion

	}
}