using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAtPlayer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.rotation = Camera.main.transform.rotation;
        
       
        
        if(gameObject.GetComponentInChildren<Text>() != null)gameObject.GetComponentInChildren<Text>().enabled = false;
    }
}
