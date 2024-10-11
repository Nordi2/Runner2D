using UnityEngine;

namespace Assets.Scripts.Logic.Wall
{
    public class WallSpawner : MonoBehaviour
    {
        [SerializeField] private float _maxTime;
        [SerializeField] private float _maxHeight;
        [SerializeField] private float _minHeight;
        [SerializeField] GameObject _wallPrefab;

        private GameObject _wall;
        private float _time;

        private void Start()
        {
            _time = 1;
        }

        private void Update()
        {
            if (_time > _maxTime)
            {
                _wall = Instantiate(_wallPrefab);
                _wall.transform.position = transform.position + new Vector3(0, Random.Range(_minHeight, _maxHeight), 0);
                _time = 0;
            }

            _time += Time.deltaTime;
            Destroy(_wall, 8f);
        }
    }
}