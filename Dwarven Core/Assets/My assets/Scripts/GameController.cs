using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
   
    public bool timed = true;
    
    public GameObject menu;
    public GameObject options;
    public GameObject exit;
    [SerializeField] private Text countdownTimer = null;
    [SerializeField] private float startTime = 50.00f;
    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        resumeGame();
        //playGame();
        //if (menu.activeInHierarchy == true) Debug.Log("found menu");
        //if (options.activeInHierarchy == true) Debug.Log("found options");
        //if (exit.activeInHierarchy == true) Debug.Log("found exit");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.Save();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (timed == true)
        {
            if (currentTime > 0.00f)
            {
                currentTime -= Time.deltaTime;
                countdownTimer.text = currentTime.ToString("F");
            }
            else if (currentTime <= 0.00f)
            {
                PlayerPrefs.Save();
                SceneManager.LoadScene("endGame");
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            escapePressed();
        }
        if (menu.activeInHierarchy == true || options.activeInHierarchy == true || exit.activeInHierarchy == true)
        {
            Cursor.visible = true;
        }
        else if (menu.activeInHierarchy == false || options.activeInHierarchy == false || exit.activeInHierarchy == false) { Cursor.visible = false; }
    }
    public void playGame() 
    {
         SceneManager.LoadScene("Game"); 
    }
    public void resumeGame()
    {
        
        menu.SetActive(false); options.SetActive(false); exit.SetActive(false);
        
        if (SceneManager.GetActiveScene().name == "Menu") menu.SetActive(true);
        else if (SceneManager.GetActiveScene().name == "endGame") exit.SetActive(true);
        else { timed = true; }

    }
    public void openOptions() 
    {
        
        if (menu != null && options != null) 
        {
            menu.SetActive(false);
            options.SetActive(true);
        }
        
    }
    public void closeOptions()
    {
        
        if (menu != null && options != null)
        {
            options.SetActive(true);
            menu.SetActive(false);
        }

    }
    
    public void exitGame() 
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
        
    }
    public void escapePressed() 
    {
        if (SceneManager.GetActiveScene().name == "Menu") 
        {
            exitGame();
        }
        else if (menu.activeInHierarchy == false || options.activeInHierarchy == false || exit.activeInHierarchy == false)  
        {
            timed = false;
            options.SetActive(false);
            menu.SetActive(true);
        }
        else 
        {
            playGame();
        }
    }
}
