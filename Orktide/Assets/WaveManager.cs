using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour {

    public Wave[] waves;
    private int currentWave;
    private bool spawningFinished;
    private bool waveRunning;
    private int aliveEnemies;

    public Transform spawnPoint;
    public Transform enemiesParent;

    private GameController controller;

	// Use this for initialization
	void Start () {
        currentWave = 0;
        aliveEnemies = 0;
        spawningFinished = true;
        waveRunning = false;

        controller = GetComponent<GameController>();
    }
	
	// Update is called once per frame
	void Update () {
		if(waveRunning && spawningFinished && aliveEnemies <= 0)
        {
            FinishWave();
        }
	}

    private void FinishWave()
    {
        waveRunning = false;
        StopAllCoroutines();
        currentWave++;

        if(currentWave >= waves.Length)
        {
            Victory();
        }

        controller.WaveFinished();
    }

    private void Victory()
    {

    }

    public void StartWave()
    {
        spawningFinished = false;
        waveRunning = true;
        StartCoroutine(SpawningWave(waves[currentWave]));
    }

    public void EnemyDied()
    {
        aliveEnemies--;
        //todo: gold,score value
    }

    private IEnumerator SpawningWave(Wave wave)
    {
        foreach(EnemyDirectory dir in wave.directories)
        {
            for(int i = 0;i< dir.count;i++)
            {
                EnemyController newEnemy = Instantiate(dir.prefab, spawnPoint.position, spawnPoint.rotation, enemiesParent).GetComponent<EnemyController>();
                SetupEnemyController(newEnemy);

                aliveEnemies++;

                yield return new WaitForSeconds(dir.waitTime);
            }
        }

        spawningFinished = true;

        yield break;
    }

    private void SetupEnemyController(EnemyController controller)
    {
        controller.manager = this;
    }
}
