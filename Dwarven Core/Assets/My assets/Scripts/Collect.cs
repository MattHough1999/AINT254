using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public Text collectText;
    public int cubesCollected = 0;
    // Start is called before the first frame update
    private void Start()
    {
        
    }
   
    private void FixedUpdate()
    {
        //collectText.text = "Cubes Collected: " + cubesCollected.ToString() ;
    }
    
    //public void collected() 
    //{
    //    cubesCollected++;

    //}
}
