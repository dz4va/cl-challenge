using UnityEngine;
using UnityEngine.UI;

namespace Challenge {
    public class LightBulbLevel : Level {

        #region Private Members
        
        [SerializeField]
        LightBulb       _bulb;

        [SerializeField]
        CustomSquareButton _bulbButton;

        #endregion

        #region Public Methods
        
        public override void Initialize() {
            base.Initialize();
            _bulbButton.AddOnClickListener(() => { 
                _bulb.Toggle(!_bulb.IsOn);
                _bulbButton.ToggleState(_bulb.IsOn);
            });
        }
        
        #endregion

    }
}