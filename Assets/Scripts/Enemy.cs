using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] [Range(0, 1)] private float armor;
    [SerializeField] Transform target;
    public float EnemyDamage;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Vector3.Distance(target.transform.position, transform.position) <= 1.5f)
        {
            GetComponentInChildren <Animator>().SetTrigger("Atack");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Bullet>() == null)
            return;

        health = health - other.GetComponent<Bullet>().damage * (1 - armor);
        if (health <= 0)
            Destroy(gameObject);
    }
}
