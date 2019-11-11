using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTarget : MonoBehaviour
{
    public float forwardSpeed = 1.1f;
    public float ReverseSpeed = 1.1f;
    public float RightSpeed = 1.1f;
    public float LeftSpeed = 1.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Camera.main.transform.forward * forwardSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Camera.main.transform.forward * -ReverseSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Camera.main.transform.right * RightSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Camera.main.transform.right * -LeftSpeed);
        }
        
        

    }
}
