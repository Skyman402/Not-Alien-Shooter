using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _bulletSpeed;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
       _rigidbody.velocity=transform.forward*_bulletSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
