using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public int score;
    public int life;
    public int gold;

    public WaveManager waveManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EnemyReachedExit()
    {
        life--;
        if(life <= 0)
        {
            Defeat();
        }
    }

    private void Defeat()
    {
        Debug.Log("Defeat");
    }

    public void Victory()
    {
        Debug.Log("Victory");
    }

    public void WaveFinished()
    {
        Debug.Log("Wave finished");
    }

    public void NextWave()
    {
        Debug.Log("Start wave");
        waveManager.StartWave();
    }
}
