using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float _attackRadius;
    [SerializeField] private PlayerScript _target;
    [SerializeField] private float _enemyDamage;

    
    private void Update()
    {
        if (Vector3.Distance(_target.transform.position, transform.position) <= _attackRadius)
        {
            _target.TakeDamdage(_enemyDamage);
        }
    }
}
