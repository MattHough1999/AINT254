using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    [SerializeField] private Text countdownTimer = null;
    [SerializeField] private float startTime = 5.00f;
    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.Save();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(currentTime > 0.00f) 
        {
            currentTime -= Time.deltaTime;
            countdownTimer.text = currentTime.ToString("F");
        }
        else if(currentTime <= 0.00f) 
        {
            PlayerPrefs.Save();
            SceneManager.LoadScene("endGame");
        }
    }
    public void playGame() 
    {
        SceneManager.LoadScene("Game");
    }
    public void openOptions() 
    {
        GameObject menu = GameObject.Find("Menu");
        GameObject options = GameObject.Find("Options");
        if (menu != null && options != null) 
        {
            menu.SetActive(false);
            options.SetActive(true);
            
        }
        
    }

    
}
