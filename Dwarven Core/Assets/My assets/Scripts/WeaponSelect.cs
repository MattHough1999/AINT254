using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// GET RID OF ALL OF THIS CODE!!!! USE ONLY FOR THE DEMO!!!!!!!!!
    /// </summary>
    void Start()
    {
        transform.GetChild(0).gameObject.active = true;
        transform.GetChild(1).gameObject.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            toggleWeapon();
        }
    }
    /// <summary>
    /// GET RID OF ALL OF THIS CODE!!!! USE ONLY FOR THE DEMO!!!!!!!!!
    /// </summary>
    void toggleWeapon() 
    {
        
        if (transform.GetChild(0).gameObject.active == false)
        {
            transform.GetChild(0).gameObject.active = true;
            transform.GetChild(1).gameObject.active = false;
        }

        else
        {
            transform.GetChild(1).gameObject.active = true;
            transform.GetChild(0).gameObject.active = false;
        }

    }
    public void lookAt()
    {
        
    }
    /// <summary>
    /// GET RID OF ALL OF THIS CODE!!!! USE ONLY FOR THE DEMO!!!!!!!!!
    /// </summary>
}
