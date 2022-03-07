using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementToPlayer : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;
    private NavMeshAgent agent;


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = target.position;
    }
}
