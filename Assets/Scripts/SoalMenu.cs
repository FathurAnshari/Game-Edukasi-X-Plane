using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoalMenu : MonoBehaviour
{
    [SerializeField] GameObject soalMenu;
    [SerializeField] GameObject optionsMenu;
    [SerializeField] Button pauseButton;
    [SerializeField] Button soalButton;
    [SerializeField] GameObject bantuanPanel;
    [SerializeField] GameObject warning;
    // private void Awake()
    // {
    //     pauseButton = FindAnyObjectByType<Button>();
    // }

    public void openQuestion()
    {
        soalMenu.SetActive(true);
        pauseButton.interactable = false;
        soalButton.interactable = false;
        Time.timeScale = 0f;
    }
    public void closeQuestion()
    {
        soalMenu.SetActive(false);
        pauseButton.interactable = true;
        soalButton.interactable = true;
        Time.timeScale = 1f;
    }
    public void openOptions()
    {
        optionsMenu.SetActive(true);
        soalMenu.SetActive(false);
    }
    public void closeOptions()
    {
        optionsMenu.SetActive(false);
        pauseButton.interactable = true;
        soalButton.interactable = true;
        soalMenu.SetActive(true);
        Time.timeScale = 1f;
    }
    public void openBantuan()
    {
        bantuanPanel.SetActive(true);
        soalMenu.SetActive(false);
        pauseButton.interactable = false;
        soalButton.interactable = false;
    }
    public void closeBantuan()
    {
        bantuanPanel.SetActive(false);
        soalMenu.SetActive(true);
        pauseButton.interactable = true;
        soalButton.interactable = true;
    }
    public void closeWarning()
    {
        warning.SetActive(false);
    }
}
