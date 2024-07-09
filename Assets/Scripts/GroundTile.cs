using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{

    GroundSpawner gs;
    public GameObject kuzelky;
    public GameObject zdi;
    [Range(0, 95)]
    public int wallAppearanceProbability = 10;

    // Start is called before the first frame update
    private void Start()
    {
        gs = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnKuzelky();
        SpawnZdi();
    }

    private void OnTriggerExit(Collider other)
    {
        gs.SpawnTile();
        Destroy(gameObject, 2);
    }

    void SpawnKuzelky()
    {
        int childIndex = GetRandomNum();
        kuzelky.transform.GetChild(childIndex).gameObject.SetActive(true);
    }

    void SpawnZdi()
    {
        int randomNum = GetRandomNum();
        int wallIndex = ChooseWall();
        if (randomNum >= wallAppearanceProbability)
        {
            zdi.transform.GetChild(wallIndex).gameObject.SetActive(true);
        }      
    }

    int GetRandomNum()
    {
        int randomNumber = Random.Range(0, 95);
        return randomNumber;
    }

    int ChooseWall()
    {
        int randomNumber = Random.Range(0, 2);
        return randomNumber;
    }

}
