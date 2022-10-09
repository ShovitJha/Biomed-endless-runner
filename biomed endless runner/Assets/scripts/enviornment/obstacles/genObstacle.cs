using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genObstacle : MonoBehaviour
{
    public GameObject[] obstacle;
    [SerializeField] private int zPos = 30;
    public bool creatingObstacle = false;

    private int index;
    
    public GameObject spawnedObstacles;
    
    void Update()
    {
        if(creatingObstacle == false)
        {
            creatingObstacle = true;
            StartCoroutine(Generateobstacle());
        }
    }

    IEnumerator Generateobstacle()
    {
         Instantiate(obstacle[Random.Range(0, obstacle.Length)],
                new Vector3(Random.Range(Level.leftSide, Level.rightSide), -1.72f, zPos), Quaternion.identity);
        index++;
        zPos += Random.Range(30, 60);
        yield return new WaitForSeconds(2);
        creatingObstacle = false;
    }
}
