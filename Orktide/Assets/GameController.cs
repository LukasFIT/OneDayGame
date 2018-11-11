using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public int life;
    public int gold;

    public WaveManager waveManager;
    public Text valuesText;

	// Use this for initialization
	void Start () {
        UpdateValues(waveManager.currentWave + 1, waveManager.waves.Length, gold, life);
	}
	
	// Update is called once per frame
	void Update ()
    {
        UpdateValues(waveManager.currentWave + 1, waveManager.waves.Length, gold, life);
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

    public void RestartLevel()
    {

    }

    public void ToMainMenu()
    {

    }

    private void UpdateValues(int _currWave, int _maxWave, int _gold, int _life)
    {
        string txt = string.Format("{0}/{1}\n{2}\n{3}", _currWave, _maxWave, _gold, _life);
        valuesText.text = txt;
    }
}
