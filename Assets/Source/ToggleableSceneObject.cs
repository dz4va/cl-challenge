using UnityEngine;

namespace Challenge {
    public class ToggleableSceneObject : MonoBehaviour {
        
        #region Public Members
        
        public bool IsOn { get; protected set; }
        
        #endregion

        #region Private/Protected Members
        
        [SerializeField]
        Animator    _objectAnimator;
        [SerializeField]
        string      _toggleParameterName;
        [SerializeField]
        protected float       _toggleOnAnimationTime;
        [SerializeField]
        protected float       _toggleOffAnimationTime;

        #endregion

        #region Public Methods
        
        public virtual void Toggle(bool onOff) {
            if (_objectAnimator == null) {
				Debug.LogError(string.Format("No animator object is assigned on {0}", name));
				return;
			}
			IsOn = onOff;
			_objectAnimator.SetBool(_toggleParameterName, onOff);
        }
        
        #endregion


    }
}