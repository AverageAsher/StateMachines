using UnityEngine;
using UnityEngine.AI; // Import AI Namespace

public class EnemyAI : MonoBehaviour
{
    public Transform target; // Target for the enemy
    private NavMeshAgent ai; // Reference to the NavMeshAgent

    void Start()
    {
        ai = GetComponent<NavMeshAgent>(); // Get NavMeshAgent component
    }

    void Update()
    {
        ai.SetDestination(target.position); // Move AI toward target
    }
}
