using UnityEngine;
using UnityEngine.Events;

namespace Challenge {
    public class DoorKnob : MonoBehaviour {

        #region Public Members
        
        public event UnityAction OnTouch = delegate{};
        
        #endregion

        #region MB Methods

        void OnMouseDown() {
            OnTouch();
        }
        
        #endregion

        #region Public Methods
        
        public void Show() {
            gameObject.SetActive(true);
        }

        public void Hide() {
            gameObject.SetActive(false);
        }
        
        #endregion

    }
}