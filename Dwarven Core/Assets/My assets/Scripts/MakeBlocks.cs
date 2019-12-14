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

        int x, y, z,wallThickness;
        wallThickness = calcWall(worldWidth);
        //calcWall(worldWidth);

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

        Debug.Log(wallThick);
        return wallThick;
    }
}
