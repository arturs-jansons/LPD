using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Sekot_Player : MonoBehaviour {

    [Range(0f, 10f)]
    [SerializeField]
    private float closeEnoughDistance = 1f;

    private GameObject player;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) > closeEnoughDistance)
        {
            PerformFollowPlayer();
        }
    }

    private void PerformFollowPlayer()
    {
        navMeshAgent.SetDestination(player.transform.position);
    }
}
