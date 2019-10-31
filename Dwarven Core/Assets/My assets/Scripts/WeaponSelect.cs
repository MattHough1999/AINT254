using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }


   // [System.Obsolete]
    void toggleWeapon()
    {

        if (transform.GetChild(0).gameObject.activeSelf == false)
        {
            transform.GetChild(0).gameObject.SetActive(true) ;
            transform.GetChild(1).gameObject.SetActive(false);
        }

        else
        {
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(0).gameObject.SetActive(false);
        }

    }
}
