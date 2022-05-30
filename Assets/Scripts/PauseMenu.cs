using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu, areYouSure, pauseText;
    bool isPaused;

    private void Start()
    {
        pauseMenu.SetActive(false);
        areYouSure.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            pauseMenu.SetActive(true);
            pauseText.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
        }

    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        pauseText.SetActive(false);
        areYouSure.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void QuitToMain()
    {
        pauseText.SetActive(false);
        areYouSure.SetActive(true);
    }

    public void YesQuit()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

}
