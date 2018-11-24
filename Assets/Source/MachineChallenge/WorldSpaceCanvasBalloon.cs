using UnityEngine;
using UnityEngine.UI;

namespace Challenge {
    [RequireComponent(typeof(RectTransform))]
    public class WorldSpaceCanvasBalloon : MonoBehaviour {

        #region Private Members
        
        [SerializeField]
        RectTransform   _transform;
        [SerializeField]
        Image           _balloonImage;
        [SerializeField]
        AudioPlayer     _audioPlayer;
        [SerializeField]
        float           _maxTravelDistance = 6;

        float   _distanceTraveled;

        float   _speed = 0;
        float   _waveFrequency = 0;
        
        #endregion

        #region MB Methods

        void Start() {
            _transform = gameObject.GetComponent<RectTransform>();
            _waveFrequency = Random.Range(1.5f, 2f);
            _speed = Random.Range(0.5f, 2f);
        }

        void Update() {
            _transform.anchoredPosition += Vector2.right * Mathf.Cos(Time.time * _waveFrequency) * Time.deltaTime;
            _transform.anchoredPosition += Vector2.up * Time.deltaTime * _speed;
            _distanceTraveled += Time.deltaTime * _speed;
            if (_distanceTraveled > _maxTravelDistance) {
                Destroy(gameObject);
            }
        }

        void OnMouseDown() {
            _audioPlayer.PlayAudio();
            Destroy(gameObject, 0.2f);
        }
        
        #endregion

        #region Public Methods
        
        public WorldSpaceCanvasBalloon SetPosition(Vector2 pos) {
            _transform.anchoredPosition = pos;
            return this;
        }

        public WorldSpaceCanvasBalloon SetColor(Color color) {
            _balloonImage.color = color;
            return this;
        }
        
        #endregion

    }
}