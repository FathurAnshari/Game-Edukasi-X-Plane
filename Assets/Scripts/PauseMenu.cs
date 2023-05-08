using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] Button soalButton;


    public void Pause()
    {
        pauseMenu.SetActive(true);
        soalButton.interactable = false;
        Time.timeScale = 0f;

    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        soalButton.interactable = true;
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        pauseMenu.SetActive(false);
        soalButton.interactable = false;
        Time.timeScale = 1f;
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
