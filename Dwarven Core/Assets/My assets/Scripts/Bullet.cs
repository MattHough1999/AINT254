﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

        //GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
        //GetComponent<Rigidbody>().AddRelativeForce(transform.forward);
        GetComponent<Rigidbody>().AddRelativeForce(Camera.main.transform.forward * 20000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
