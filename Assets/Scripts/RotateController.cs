using UnityEngine;

public class RotateController : MonoBehaviour
{
    [SerializeField] private float offset;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 diference = Camera.main.ScreenToViewportPoint(Input.mousePosition) - transform.position;
            float rotateY = Mathf.Atan2(diference.x, diference.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, rotateY + offset, 0f);
        }
    }
}
