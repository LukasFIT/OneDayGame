using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public int health;
    public WaveManager manager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //fixme
        transform.position = transform.position + Vector3.forward * Time.deltaTime * 0.2f;
	}

    //fixme
    private void OnMouseDown()
    {
        health--;
        if(health <= 0)
        {
            manager.EnemyDied();
            Destroy(gameObject);
        }
    }
}
