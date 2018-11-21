using UnityEngine;


namespace Challenge {
    public class Level : MonoBehaviour, ILevel {

        #region Public Methods
        
        public virtual void Initialize() {
            Debug.Log(string.Format("Initializing Level: {0}", name));
        }

        public virtual void UpdateLevel() {

        }
        
        #endregion

    }
}
