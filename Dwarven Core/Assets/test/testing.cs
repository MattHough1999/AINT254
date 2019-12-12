using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testing : MonoBehaviour
{
    public Text timer;
    public Text lap;
    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        timer.text = currentTime.ToString("F");
        if (Input.GetKeyDown(KeyCode.L))
        {
            lap.text = currentTime.ToString("F");
        }
    }
}
