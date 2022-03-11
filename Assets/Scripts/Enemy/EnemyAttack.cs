using System.Collections;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private PlayerScript _target;
    [Header("Settings")]
    [SerializeField] private float _attackRadius;
    [SerializeField] private float _enemyDamage;
    [SerializeField] private float _cooldownTime;

    private bool _isCooldown;

    private void Update()
    {
        if (_target == null)
            return;

        if (Vector3.Distance(_target.transform.position, transform.position) <= _attackRadius && _isCooldown == false)
        {
            _target.TakeDamdage(_enemyDamage);
            StartCoroutine(WaitCooldown());
        }
    }

    private IEnumerator WaitCooldown()
    {
        _isCooldown = true;
        yield return new WaitForSeconds(_cooldownTime);
        _isCooldown=false;
    }
}
