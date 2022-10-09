using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 50;
    public bool creatingSection = false;

    void Update()
    {
        if(creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        Instantiate(section[0], new Vector3(0,0.1f,zPos), Quaternion.identity);
        zPos += 50;

        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
