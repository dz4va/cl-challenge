using UnityEngine;

namespace Challenge {
    public class FlowerWaveFeature : BlackBoardFeature {

        #region Public Methods

        public override void UpdateFeature() {
            float newX = Mathf.SmoothStep(transform.position.x, Mathf.Cos(Time.time * 2f) * Time.deltaTime * 100f, 0.1f);
            transform.position = Vector3.right * newX;
        }

        public override void Activate() {
            base.Activate();
            transform.position = Vector2.zero;
        }
        
        #endregion

    }
}