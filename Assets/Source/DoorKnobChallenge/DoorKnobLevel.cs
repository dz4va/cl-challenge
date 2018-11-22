using UnityEngine;

namespace Challenge {
	public class DoorKnobLevel : Level {

		#region Public Methods
        
        public override void Initialize() {
            base.Initialize();
			// We don't need to handle anything here, door has it's own logic and animations and sounds
			// This is here so that we can have other stuff in the level
        }

		public override void UpdateLevel() {

		}
        
        #endregion

	}
}
