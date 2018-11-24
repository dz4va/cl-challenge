using UnityEngine;
using System.Collections.Generic;

namespace Challenge {
    public class PoppyBalloonsFeature : BlackBoardFeature {

        #region Private Members
        
        [SerializeField]
        GameObject  _balloonPrefab;
        [SerializeField]
        Transform   _balloonObjectsParent;
        [SerializeField]
        Vector2     _horizontalBallonRange;

        float randomBalloonSpawnTimer = 0;
        
        #endregion

        #region Public Methods

        public override void UpdateFeature() {
            if (randomBalloonSpawnTimer <= 0) {
                WorldSpaceCanvasBalloon balloon = Instantiate(_balloonPrefab, _balloonObjectsParent)
                    .GetComponent<WorldSpaceCanvasBalloon>();
                if (balloon != null) {
                    // Random position on horizontal line
                    Vector2 pos = new Vector2(
                        Random.Range(_horizontalBallonRange.x, _horizontalBallonRange.y),
                        -1.5f
                    );
                    // Set the position and random color
                    balloon.SetPosition(pos)
                        .SetColor(new Color(Random.Range(0.1f, 1), Random.Range(0.1f, 1), Random.Range(0.1f, 1)));

                    // Set the random spawn timer to a new value 
                    randomBalloonSpawnTimer = Random.Range(0.1f, 0.8f);
                }
            }
            randomBalloonSpawnTimer -= Time.deltaTime;
        }

        public override void Stop() {
            foreach (Transform spawnedObject in _balloonObjectsParent)
                Destroy(spawnedObject.gameObject);
            base.Stop();
        }
        
        #endregion

    }
}