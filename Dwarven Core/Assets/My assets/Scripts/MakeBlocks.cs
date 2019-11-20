using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBlocks : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject prefab;
    GameObject[] prefabs;
    public int worldDepth = 5;
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
        prefabs = new GameObject[worldDepth];
        
        for (int y = 0; y < worldHeight; y++)
        {
            for (int x = 0; x < worldDepth; x++)
            {
                for (int z = 0; z < worldWidth; z++)
                {
                    GameObject block = Instantiate(prefab);
                    block.transform.position = CurrPosition;
                    
                    
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
