using UnityEngine;

namespace Challenge {
    public class BlackBoardFeature : MonoBehaviour {

        #region Public Members
        
        public bool IsActive { get; private set; }
        
        #endregion
        
        #region Public Methods
        
        public virtual void Initialize() {
            Stop();
        }

        public virtual void UpdateFeature() {

        }

        public virtual void Activate() {
            gameObject.SetActive(true);
            IsActive = true;
        }

        public virtual void Stop() {
            gameObject.SetActive(false);
            IsActive = false;
        }
        
        #endregion

    }
}