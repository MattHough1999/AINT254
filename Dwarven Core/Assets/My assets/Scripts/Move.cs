using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody player;
    public Vector3 maxVelocity = new Vector3(5,5,5);
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A) && player.velocity.x < maxVelocity.x) player.velocity = player.velocity + new Vector3(2, 0, 0);
        if (Input.GetKey(KeyCode.D) && player.velocity.x > maxVelocity.x * -1) player.velocity = player.velocity + new Vector3(-2, 0, 0);
        if (Input.GetKey(KeyCode.W) && player.velocity.z < maxVelocity.z) player.velocity = player.velocity + new Vector3(0, 0, 2);
        if (Input.GetKey(KeyCode.S) && player.velocity.z > maxVelocity.z * -1) player.velocity = player.velocity + new Vector3(0, 0, -2);
    }
}
