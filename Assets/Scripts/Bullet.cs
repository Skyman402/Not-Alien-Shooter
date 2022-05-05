using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 20;

    private Rigidbody _rigidbody;
    [SerializeField] private float _bulletSpeed;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        StartCoroutine(DestroyAfterDelay());
    }
    private void FixedUpdate()
    {
       _rigidbody.velocity=transform.forward*_bulletSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
    private IEnumerator DestroyAfterDelay()
    {
        yield return new WaitForSeconds(4);
        if (this != null)
        {
            Destroy(gameObject);
        }
    }
}
