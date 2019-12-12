using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelect : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            toggleWeapon();
        }
        lookAt();
    }
    
    void toggleWeapon() 
    {
        
        if (transform.GetChild(0).gameObject.activeInHierarchy == false)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
        }

        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
        }

    }
    public void lookAt()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 3, Color.red);
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 3f))
        {
            var hitObject = hit.transform;
            if (hitObject != null && hitObject.gameObject.tag == "Cube")
            {
                var hitObjectScript = hitObject.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>();

                //Debug.Log(hitObject.name);
                //if (hitObjectScript != null && hitObject.gameObject.tag == "Cube")
                //{
                    hitObjectScript.enabled = true;
                //}
            }
        }
    }
    
}
