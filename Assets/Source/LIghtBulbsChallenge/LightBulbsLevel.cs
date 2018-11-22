using UnityEngine;

namespace Challenge {
    public class LightBulbsLevel : Level {

        #region Private Members
        
        [SerializeField]
        LightBulb[]       _bulbs;

        [SerializeField]
        LightBulbButton _bulbButton;

        int _currentBulbIndex;
        int _previousBulbIndex;

        #endregion

        #region Public Methods
        
        public override void Initialize() {
            base.Initialize();
            _currentBulbIndex = 0;
            _previousBulbIndex = -1;

            if (_bulbs == null) {
                Debug.LogError(string.Format("Lightbulb array is not assigned on {0}", name));
                return;
            }

            if (_bulbButton == null) {
                Debug.LogError(string.Format("Bulb button is not assigned on {0}", name));
                return;
            }

            _bulbButton.AddOnClickListener(() => {
                LightBulb bulb = _bulbs[_currentBulbIndex];
                bulb.Toggle(!bulb.IsOn);
                
                if (_previousBulbIndex != -1) {
                    LightBulb previousBulb = _bulbs[_previousBulbIndex];
                    previousBulb.Toggle(false);
                }

                _previousBulbIndex = _currentBulbIndex;
                _currentBulbIndex = _currentBulbIndex == _bulbs.Length - 1 ? 0 : _currentBulbIndex + 1;
                Debug.Log(_currentBulbIndex);
            });
        }
        
        #endregion

    }
}