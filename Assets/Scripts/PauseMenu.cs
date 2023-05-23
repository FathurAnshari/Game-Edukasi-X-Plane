using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] Button soalButton;
    AudioPlayer audioPlayer;
    private void Start()
    {
        audioPlayer = FindObjectOfType<AudioPlayer>();

    }

    public void Pause()
    {
        audioPlayer.GetComponent<AudioSource>().Pause();
        pauseMenu.SetActive(true);
        soalButton.interactable = false;
        Time.timeScale = 0f;

    }
    public void Resume()
    {
        audioPlayer.GetComponent<AudioSource>().Play();
        pauseMenu.SetActive(false);
        soalButton.interactable = true;
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        pauseMenu.SetActive(false);
        audioPlayer.GetComponent<AudioSource>().Play();
        soalButton.interactable = false;
        Time.timeScale = 1f;
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        audioPlayer.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(sceneID);
    }
}
