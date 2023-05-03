using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))] // Require all prefabs with this script to have a nav mesh agent
public class BasicEnemy : MonoBehaviour
{
    private NavMeshAgent navAgent;

    public float damageAmount;
    public float attackDelay;
    public float attackRate;
    public float attackDistance;

    public Transform playerObject;
    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player").transform;
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > attackDelay)
        {
            navAgent.destination = playerObject.position;
            if (Vector3.Distance(playerObject.position, transform.position) <= attackDistance)
            {
                playerObject.GetComponent<PlayerHealth>().playerHealth -= damageAmount;
                attackDelay = Time.time + attackRate;
            }
        }
        else
        {
            navAgent.destination = transform.position;
        }
    }
}
