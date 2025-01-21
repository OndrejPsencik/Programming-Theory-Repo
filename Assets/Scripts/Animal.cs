using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public abstract class Animal : MonoBehaviour
{
    private NavMeshAgent navAgent;
    public float Speed = 1;
    private Vector3? targetPosition;

    private void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();

        if (navAgent == null)
        {
            navAgent = gameObject.AddComponent<NavMeshAgent>();            
        }

        navAgent.enabled = true;
    }

    private void Update()
    {
        if (targetPosition != null)
        {
            float distance = Vector3.Distance(targetPosition.Value, transform.position);
            if (distance < 10f)
            {
                targetPosition = null;
                navAgent.isStopped = true;
                navAgent.ResetPath(); // Ensure the NavMeshAgent stops completely
            }
        }
    }

    public abstract Vector3 FindOwner();

    // ABSTRACTION
    public void GoToOwner()
    {
        Debug.Log("GoToOwner");
        targetPosition = FindOwner();
        navAgent.SetDestination(targetPosition.Value);
        navAgent.speed = Speed;
        navAgent.isStopped = false;
    }
}
