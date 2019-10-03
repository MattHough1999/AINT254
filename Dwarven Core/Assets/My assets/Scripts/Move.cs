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

        while (Input.GetKeyDown(KeyCode.A)) player.velocity = player.velocity + new Vector3(20, 0, 0);
        while (Input.GetKeyDown(KeyCode.A)) player.velocity = player.velocity + new Vector3(-20, 0, 0);
        while (Input.GetKeyDown(KeyCode.W)) player.velocity = player.velocity + new Vector3(0, 0, 20);
        while (Input.GetKeyDown(KeyCode.S)) player.velocity = player.velocity + new Vector3(0, 0, -20);
    }
}
