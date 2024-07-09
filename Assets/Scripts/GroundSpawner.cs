using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    public GameObject groundTile;
    public int spawnedTilesCount = 10;
    Vector3 nextSpawnpoint;

    public void SpawnTile()
    {
        for (int i = 0; i < spawnedTilesCount; i++)
        {
            GameObject temp = Instantiate(groundTile, nextSpawnpoint, Quaternion.identity);
            nextSpawnpoint = temp.transform.GetChild(1).transform.position;
        }

    }

    // Start is called before the first frame update
    private void Start()
    {
        SpawnTile();
    }

}
