using UnityEngine;

namespace Challenge {
    public class MachineLevel : Level {

        #region Private Members
        
        [SerializeField]
        RobotBlackboard     _robotBlackBoard;
        [SerializeField]
        CustomSquareButton  _robotActivationButton;
        
        #endregion

        #region Public Members
        
        public override void Initialize() {
            base.Initialize();
            if (_robotActivationButton == null) {
                Debug.LogError(string.Format("Robot activation button not found on {0}", name));
                return;
            }
            if (_robotBlackBoard == null) {
                Debug.LogError(string.Format("Robot blackboard not found on {0}", name));
                return;
            }
            _robotActivationButton.AddOnClickListener(() => {
                _robotBlackBoard.PlayRandomFunThing();
            });
        }
        
        #endregion

    }
}