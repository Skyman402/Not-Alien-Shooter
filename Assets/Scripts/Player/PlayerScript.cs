using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float _playerHealth;
    [SerializeField] private float _playerArmor;
    
    public void TakeDamdage(float amount)
    {
        _playerHealth = _playerHealth - amount *(1-_playerArmor );
        if (_playerHealth <= 0)
            Destroy(gameObject);
    }
}


