﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    public bool mined = false;
    public int health = 10;
    public int type = 0;
    
    public List<Material> types;
    public List<Texture> textures;

    void Start()
    {
        choseType();
    }
    
    // Update is called once per frame
    void Update()
    {

        if (mined == true && GetComponent<Rigidbody>().isKinematic == true) //extra check prevents fallen cubes from sending raycasts
        {
            //Each ray is required to be declared independently 
            Ray ray1 = new Ray(transform.position, transform.forward);
            Ray ray2 = new Ray(transform.position, transform.forward * -1);
            Ray ray3 = new Ray(transform.position, transform.up);
            Ray ray4 = new Ray(transform.position, transform.up * -1);
            Ray ray5 = new Ray(transform.position, transform.right);
            Ray ray6 = new Ray(transform.position, transform.right * -1);
            
            
            //checkhit is run with each ray to reduce redundant code
            checkHit(ray1);
            checkHit(ray2);
            checkHit(ray3);
            checkHit(ray4);
            checkHit(ray5);
            checkHit(ray6);
            GetComponent<Rigidbody>().isKinematic = false;
            this.gameObject.transform.localScale = new Vector3(0.98f, 0.98f, 0.98f);
        }
        
    }
    public void choseType() 
    {
        type = Random.Range(0, types.Count);
        Material m = types[type];
        GetComponent<Renderer>().material = m;
        health = 2 * (type + 1);


    }
    public void checkHit(Ray ray)
    {
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var hitCube = hit.transform;
            var hitCubePhysics = hitCube.GetComponent<Rigidbody>();
            if (hitCubePhysics != null && hitCube.tag == "Cube") 
            { 
                hitCubePhysics.isKinematic = false;
                hitCube.GetComponent<Cube>().mined = true;
                hitCube.localScale = new Vector3(0.98f, 0.98f, 0.98f);
                //hitCubePhysics.AddExplosionForce(2000f, transform.position, 10f);
            }
            
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        var drill = collision.gameObject.GetComponentInChildren<Drill>();
        var hoover = collision.gameObject.GetComponentInChildren<Collect>();

        if (drill != null && drill.enabled == true) 
        {
            mined = true;
            if (health > 0)
            {
                health--;
                transform.localScale = transform.localScale - new Vector3(0.03f / (type + 1), 0.03f / (type + 1), 0.03f / (type + 1));
            }
            
        }
        if (hoover != null && hoover.enabled == true)
        {
            if(health == 0) 
            {
                die();
            }

        }

    }
    public void die() 
    {
        GameObject player = GameObject.Find("RigidBodyFPSController");
        //float f = type;
        player.GetComponent<Inventory>().money = player.GetComponent<Inventory>().money + Mathf.Pow(10f, type);
        Destroy(this.gameObject) ; 


        
    }
}
