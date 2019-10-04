using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBlocks : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    GameObject[] prefabs;
    public int worldSize = 5;
    public int worldHeight = 5;
    public int worldWidth = 5;
    public Vector3 startPosition = new Vector3(0,0,0);
    
    private void Start()
    {
        SpawnBlocks();
    }
    public void SpawnBlocks() 
    {
        Vector3 CurrPosition = startPosition;
        prefabs = new GameObject[worldSize];
        int i = 0 ;
        while (i < worldSize)
        {
            for (int x = 0; x < worldWidth; x++)
            {
                for (int z = 0; z < worldHeight; z++)
                {
                    if (i < worldSize)
                    {
                        GameObject block = Instantiate(prefab);
                        block.transform.position = CurrPosition;
                        i++;
                    }
                    CurrPosition.z++;
                }
                CurrPosition.x++;
                CurrPosition.z = startPosition.z;
            }
            CurrPosition.x = startPosition.x;
            CurrPosition.y++;

        }

    }
}
