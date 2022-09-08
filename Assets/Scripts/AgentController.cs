using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    public NavMeshAgent Agent;
    public GameObject Destination;
    void Update()
    {
        Agent.SetDestination(Destination.transform.position);
    }
}
