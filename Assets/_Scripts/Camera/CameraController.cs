using UnityEngine;
namespace TheDragonHunt
{
    [RequireComponent(typeof(Camera))]
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private float _borderSize = 50f;
        [SerializeField] private float _panSpeed = 10f;
        [SerializeField] private Vector2 _panLimit =
            new Vector2(30f, 35f);
        [SerializeField] private float _scrollSpeed = 1000f;
        [SerializeField] private Vector2 _scrollLimit =
            new Vector2(5f, 10f);
        private Vector3 _initialPosition = Vector3.zero;
        private Camera _camera = null;
        public float speed = 20.0f;

        [SerializeField] private bool _disableCameraMovement = false;
        private void Start()
        {
            _initialPosition = transform.position;
            _camera = GetComponent<Camera>();
        }
        private void Update()
        {
          #if UNITY_EDITOR
            if(_disableCameraMovement)
            {
                return;
            }
          #endif
            MoveCamWithKeys();
            UpdateZoom();
           // UpdatePan();
        }

        private void MoveCamWithKeys()
        {
            float horizontalInput = Input.GetAxis("Horizontal"); // A/D o Flechas izquierda/derecha
            float verticalInput = Input.GetAxis("Vertical"); // W/S o Flechas arriba/abajo

            // Mover la c�mara con el input horizontal y vertical
            Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime;

            // Aplicar el movimiento
            transform.Translate(movement, Space.World);
        }

        private void UpdateZoom()
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            scroll = -scroll * _scrollSpeed * Time.deltaTime;
            _camera.orthographicSize += scroll;
            _camera.orthographicSize = Mathf.Clamp(_camera.orthographicSize,
                _scrollLimit.x, _scrollLimit.y);
        }

        private void UpdatePan()
        {
            Vector3 position = transform.position;
            if (Input.mousePosition.y >= Screen.height - _borderSize)
                position.z += _panSpeed * Time.deltaTime;
            if (Input.mousePosition.y <= _borderSize)
                position.z -= _panSpeed * Time.deltaTime;
            if (Input.mousePosition.x >= Screen.width - _borderSize)
                position.x += _panSpeed * Time.deltaTime;
            if (Input.mousePosition.x <= _borderSize)
                position.x -= _panSpeed * Time.deltaTime;

           


            position.x = Mathf.Clamp(position.x,
                -_panLimit.x + _initialPosition.x,
                _panLimit.x + _initialPosition.x);

            position.z = Mathf.Clamp(position.z,
                -_panLimit.y + _initialPosition.z,
                 _panLimit.y  + _initialPosition.z);

            transform.position = position;
        }

    }

}


