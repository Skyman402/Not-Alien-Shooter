using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] [Range (0,1)] private float armor;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Bullet>() == null)
            return;

        health = health - other.GetComponent<Bullet>().damage*(1-armor);
        if (health <= 0)
            Destroy(gameObject);
    }
}
