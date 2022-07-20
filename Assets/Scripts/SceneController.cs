using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    Canvas canvas = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("ParallelDimension");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void GamePause()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0;
        canvas = GetComponentInParent<Canvas>();
        canvas.enabled = false;
        canvas = GameObject.FindGameObjectWithTag("Pause").GetComponent<Canvas>();
        canvas.enabled = true;
    }
    public void GameResume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        canvas = GetComponentInParent<Canvas>();
        canvas.enabled = false;
        canvas = GameObject.FindGameObjectWithTag("Game").GetComponent<Canvas>();
        canvas.enabled = true;
    }
}
