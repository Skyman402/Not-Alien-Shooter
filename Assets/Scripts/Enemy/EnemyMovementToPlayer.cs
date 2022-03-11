using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementToPlayer : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (_target == null)
            return;
        _agent.destination = _target.position;
    }
}
