using UnityEngine;

public class AggroRadius : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private Transform _target;
    [SerializeField] private EnemyMovementToPlayer _enemyMovementToPlayer;

    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (Vector3.Distance(_target.position, transform.position) < _radius)
            _enemyMovementToPlayer.enabled = true;
        else
            _enemyMovementToPlayer.enabled = false;
    }
}
