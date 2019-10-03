using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D)) player.velocity = new Vector3(20, 0, 0);
        if (Input.GetKeyDown(KeyCode.A)) player.velocity = new Vector3(-20, 0, 0);
        if (Input.GetKeyDown(KeyCode.W)) player.velocity = new Vector3(0, 0, 20);
        if (Input.GetKeyDown(KeyCode.S)) player.velocity = new Vector3(0, 0, -20);
    }
}
