using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float triangleSpawn;
    public float clowdSpawn;
    public float treeSpawn;

    // Start is called before the first frame update
    void Start()
    {
        triangleSpawn = Random.Range(1f, 2f);
        clowdSpawn = 35f;
        treeSpawn = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Obstacle"))
        {
            triangleSpawn -= Time.deltaTime;

            if (triangleSpawn <= 0)
            {
                SpawnObstacle();
                triangleSpawn = Random.Range(1f, 2f);
            }
        }

        if (gameObject.CompareTag("Cloud"))
        {
            clowdSpawn -= Time.deltaTime;

            if (clowdSpawn <= 0)
            { 
                SpawnObstacle();
                clowdSpawn = 35f;
            }
        }
        if (gameObject.CompareTag("Tree"))
        {
            treeSpawn -= Time.deltaTime;

            if (treeSpawn <= 0)
            {
                SpawnObstacle();
                treeSpawn = 10f;
            }
        }

    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
    }
}
