using UnityEngine;
using UnityEngine.UI;

namespace Challenge {
    public class LightBulbLevel : Level {

        #region Private Members
        
        [SerializeField]
        LightBulb   _bulb;

        [Space(10)]
        [SerializeField]
        Button      _bulbToggleButton;
        [SerializeField]
        Image       _bulbButtonImage;
        [SerializeField]
        Sprite       _bulbButtonToggledSprite;
        [SerializeField]
        Sprite       _bulbButtonNormalSprite;
        
        #endregion

        #region Public Methods
        
        public override void Initialize() {
            base.Initialize();
            _bulbToggleButton.onClick.AddListener(bulbToggleButtonClick);
        }
        
        #endregion

        #region Private Methods
        
        void bulbToggleButtonClick() {
            _bulb.ToggleLightBulb(!_bulb.IsOn);
            if (_bulbButtonImage == null) {
                Debug.LogError(string.Format("Button image field is not assigned on {0}", name));
                return;
            }
            _bulbButtonImage.sprite = _bulb.IsOn ? _bulbButtonToggledSprite : _bulbButtonNormalSprite;
        }
        
        #endregion

    }
}