using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public float lateralSpeed = 4;
    private worthyObstacles _worthyObstacles;
    
    [SerializeField] private GenerateLevel genLevel;
    [SerializeField] private genObstacle genObstacle;

    private GameObject[] sections;
    public GameObject LevelControl;

    private void Start()
    {
        _worthyObstacles = LevelControl.GetComponent<worthyObstacles>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("obstacle"))
        {
            moveSpeed = 0f;
            lateralSpeed = 0f;
            _worthyObstacles.CreatingPrefabs = false;
            LevelControl.SetActive(false);

        }

        if (other.CompareTag("bhakk"))
        {
            Destroy(other.transform.parent.gameObject);
        }
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > Level.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * lateralSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < Level.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * lateralSpeed * -1);
            }
        }
    }
}
