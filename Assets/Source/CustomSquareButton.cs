using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Challenge {
    public class CustomSquareButton : MonoBehaviour {

        #region Private Members
        
        [SerializeField]
        Button      _button;
        [SerializeField]
        Image       _buttonImage;
        [SerializeField]
        Sprite      _normalStateSprite;
        [SerializeField]
        Sprite      _toggleStateSprite;
        [SerializeField]
        Animator    _buttonAnimator;
        
        #endregion

        #region Public Methods
        
        public void AddOnClickListener(UnityAction action) {
            if (_button == null) {
                Debug.LogError(string.Format("Button not found on {0}", name));
                return;
            }
            _button.onClick.AddListener(() => { action(); });
        }

        public void ToggleState(bool on) {
            if (_buttonImage == null) {
                Debug.LogError(string.Format("Image component not assigned on {0}", name));
                return;
            }
            _buttonImage.sprite = on ? _toggleStateSprite : _normalStateSprite;
        }

        public void RunClickAnimation(string animationName) {
            if (_buttonAnimator == null) {
                Debug.LogError(string.Format("Animator component not assigned on {0}", name));
                return;
            }
            _buttonAnimator.Play(animationName, -1, 0);
        }

        #endregion

    }
}