using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAtPlayer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Text>().enabled = false;
        //gameObject.GetComponentInChildren<Text>().enabled = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.rotation = Camera.main.transform.rotation;
        //gameObject.transform.Translate(Camera.main.transform.forward * 3);
       
        
        gameObject.GetComponentInChildren<Text>().enabled = false;
    }
}
