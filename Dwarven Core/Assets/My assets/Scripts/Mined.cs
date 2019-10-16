using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mined : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public bool mined = false;
    // Update is called once per frame
    void Update()
    {

        if (mined == true)
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
        }
    }
    public void checkHit(Ray ray)
    {
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var hitCube = hit.transform;
            var hitCubePhysics = hitCube.GetComponent<Rigidbody>();
            if (hitCubePhysics != null) 
            { 
                hitCubePhysics.isKinematic = false;
                //hitCubePhysics.AddExplosionForce(2000f, transform.position, 10f);
            }
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
