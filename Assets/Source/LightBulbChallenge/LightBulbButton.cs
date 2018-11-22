using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Challenge {
    public class LightBulbButton : MonoBehaviour {

        #region Public Members
        
        public event UnityAction OnClick = delegate{};
        
        #endregion

        #region Private Members
        
        [SerializeField]
        Button  _button;
        [SerializeField]
        Image   _buttonImage;
        [SerializeField]
        Sprite  _normalStateSprite;
        [SerializeField]
        Sprite  _toggleStateSprite;
        
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
                Debug.LogError(string.Format("Image component not found on {0}", name));
                return;
            }
            _buttonImage.sprite = on ? _toggleStateSprite : _normalStateSprite;
        }
        
        #endregion

    }
}