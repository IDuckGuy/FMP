using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject cameraBack;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        player.SetActive(true);
        cameraBack.SetActive(false);
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        player.SetActive(false);
        cameraBack.SetActive(true);
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading menu...");
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
