using UnityEngine;

public class RotateController : MonoBehaviour
{
    private Camera _camera;
    private Transform _transform;

    private void Start()
    {
        _camera = Camera.main;
        _transform = transform;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Rotate();
        }
    }

    private void Rotate()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, 1000f))
        {
            var hitPoint = new Vector3(hit.point.x, _transform.position.y, hit.point.z);
            _transform.forward = (hitPoint-transform.position).normalized;
        }
    }
}
