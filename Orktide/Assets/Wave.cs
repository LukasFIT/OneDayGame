using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class EnemyDirectory
{
    public GameObject prefab;
    public float waitTime;
    public int count;
}

[CreateAssetMenu(fileName = "Wave", menuName = "Waves/Wave", order = 1)]
public class Wave : ScriptableObject {

    public List<EnemyDirectory> directories;

}
