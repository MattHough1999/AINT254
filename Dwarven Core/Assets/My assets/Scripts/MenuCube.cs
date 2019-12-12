using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCube : MonoBehaviour
{
    // Start is called before the first frame update
    public int type = 0;

    public List<Material> types;
    public List<Texture> textures;

    void Start()
    {
        type = Random.Range(0, types.Count);
        Material m = types[type];
        GetComponent<Renderer>().material = m;
    }

}
