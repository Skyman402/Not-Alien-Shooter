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
    
    public void TakeDamdage(float amount)
    {
        _playerHealth = _playerHealth - amount;
        if (_playerHealth <= 0)
            Destroy(gameObject);
    }
}


