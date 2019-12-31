using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBlocks : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject prefab;
    public GameObject wallPrefab;
    public GameObject enemy;
    
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

        int x, y, z, wallThickness, spawnEnemy;

        wallThickness = calcWall(worldWidth);

        for (y = 0; y < worldHeight; y++)
        {
            for (x = 0; x < worldDepth; x++)
            {
                for (z = 0; z < worldWidth; z++)
                {
                    if (!(x > wallThickness - 1 && z > wallThickness - 1) || !(x < worldDepth - wallThickness && z < worldWidth - wallThickness)) // so proud of this if statement feel free to email me for an essay of explanation
                    {
                        GameObject block = Instantiate(prefab);
                        block.transform.position = CurrPosition;
                        spawnEnemy = new System.Random().Next(0, 5);
                        if (spawnEnemy == 1) 
                        {
                            GameObject Denemy = Instantiate(enemy);
                            Denemy.transform.position = CurrPosition + new Vector3(0, 5, 0);
                        }
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

    public int calcWall(int width) 
    {
        int wallThick = width / 7;

        if (wallThick == 0) return 1;

        //Debug.Log(wallThick);
        return wallThick;
    }
}
