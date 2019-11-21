using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBlocks : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject prefab;
    public GameObject wallPrefab;
    
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

        //GameObject wall1 = Instantiate(wallPrefab);
        //wall1.transform.position = startPosition;
        //wall1.transform.localScale = new Vector3(worldDepth + 1, worldHeight + 1, worldWidth + 1);



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
