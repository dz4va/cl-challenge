using UnityEngine;

namespace Challenge {
	public class Door : ToggleableSceneObject {

		#region Private Members
		
		[SerializeField]
		AudioPlayer _audioPlayer;
		[SerializeField]
		DoorKnob	_knob;
		
		#endregion	

		#region MB Methods
		
		void Start() {
			if (_audioPlayer == null) {
				_audioPlayer = GetComponent<AudioPlayer>();
				if (_audioPlayer == null) {
					Debug.LogError(string.Format("AudioPlayer component not found on {0} or is not assigned", name));
					return;
				}
			}
			if (_knob == null) {
				Debug.LogError(string.Format("Door knob is not assigned on {0}", name));
				return;
			}
			_knob.OnTouch += () => Toggle(true);
		}
		
		#endregion

		#region Public Methods
		
		public override void Toggle(bool onOff) {
			base.Toggle(onOff);

			if (_audioPlayer != null)
				_audioPlayer.PlayAudio();

			if (_knob == null) return; 

			if (onOff)
				StartCoroutine(CoroutineUtilities.DelayedExecution(_toggleOnAnimationTime, () => { 
					_knob.Hide(); 
				}));
			else 
				StartCoroutine(CoroutineUtilities.DelayedExecution(_toggleOffAnimationTime, () => {
					_knob.Show();
				}));
		}

		void OnMouseDown() {
			Toggle(false);
		}

		#endregion
	}
}
