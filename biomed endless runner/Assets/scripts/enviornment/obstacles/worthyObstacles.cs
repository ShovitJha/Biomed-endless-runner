using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worthyObstacles : MonoBehaviour
{
    public Transform[] spawner;
    public GameObject[] prefabs;
    public bool CreatingPrefabs = true;

    void Start()
    {
        InvokeRepeating("SpawnObstacles",1f,1f);
    }

    void SpawnObstacles()
    {
        if (CreatingPrefabs)
        {
            int randomCase = Random.Range(0, 2);
            if (randomCase == 0)
            {
                int rand = Random.Range(0, 2);
                if (rand == 0)
                {
                    GameObject temp1 = Instantiate(prefabs[Random.Range(0, prefabs.Length)], spawner[2]);
                    GameObject temp2 = Instantiate(prefabs[Random.Range(0, prefabs.Length)], spawner[Random.Range(0, 2)]);
                    temp1.transform.parent = null;
                    temp2.transform.parent = null;

                }
                else
                {
                    GameObject temp1 = Instantiate(prefabs[Random.Range(0, prefabs.Length)], spawner[0]);
                    GameObject temp2 = Instantiate(prefabs[Random.Range(0, prefabs.Length)], spawner[1]);
                    temp1.transform.parent = null;
                    temp2.transform.parent = null;

                }
            }
            else
            {
                GameObject temp1 = Instantiate(prefabs[Random.Range(0, prefabs.Length)], spawner[Random.Range(0, 2)]);
                temp1.transform.parent = null;
            }
        }
    }
}
