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
            //RaycastHit hit = null;
            Ray ray1 = new Ray(transform.position, transform.forward);
            Ray ray2 = new Ray(transform.position, transform.forward * -1);
            Ray ray3 = new Ray(transform.position, transform.up);
            Ray ray4 = new Ray(transform.position, transform.up * -1);
            Ray ray5 = new Ray(transform.position, transform.right);
            Ray ray6 = new Ray(transform.position, transform.right * -1);
            
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
            if (hitCubePhysics != null) hitCubePhysics.isKinematic = false;
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
