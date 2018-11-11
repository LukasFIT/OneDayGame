using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

    public int health;

    public float arrivalDistance;

    public Transform exit;
    public WaveManager manager;
    public NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if(Vector3.Distance(transform.position, exit.position) <= arrivalDistance)
        {
            manager.EnemyReachedExit();
            manager.EnemyDied();
            Destroy(gameObject);
        }
	}

    //fixme
    private void OnMouseDown()
    {
        health--;
        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        manager.EnemyDied();
        Destroy(gameObject);
    }

    public void StartMovement()
    {
        agent.SetDestination(exit.position);
    }

}
