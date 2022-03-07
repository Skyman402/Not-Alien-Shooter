using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float _playerHealth;
    //[SerializeField] private float _playerArmor; это тоже
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _playerHealth = _playerHealth - collision.collider.GetComponent<Enemy>().EnemyDamage;
        if (_playerHealth <= 0)
            Destroy(gameObject);
    }
}

