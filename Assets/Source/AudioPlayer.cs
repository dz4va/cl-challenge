using UnityEngine;

namespace Challenge {
    public class AudioPlayer : MonoBehaviour {

        #region Private Members
        
        [SerializeField]
        AudioSource     _objectAudioSource;
        [Space(10)]
        [Header("Chosen clip to play")]
        [SerializeField]
        AudioClip       _audioClip;
        
        #endregion

        #region Public Methods

        public void PlayAudio() {
            if (_audioClip == null) {
                Debug.LogError(string.Format("No audio clip found on {0}", name));
                return;
            }
            _objectAudioSource.clip = _audioClip;
            _objectAudioSource.Play();
        }

        #endregion

    }
    
}