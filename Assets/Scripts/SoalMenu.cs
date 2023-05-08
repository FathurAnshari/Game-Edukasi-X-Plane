using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoalMenu : MonoBehaviour
{
    [SerializeField] GameObject soalMenu;
    Button pauseButton;

    private void Awake()
    {
        pauseButton = FindAnyObjectByType<Button>();
    }

    public void openQuestion()
    {
        soalMenu.SetActive(true);
        pauseButton.interactable = false;
        Time.timeScale = 0f;
    }
    public void closeQuestion()
    {
        soalMenu.SetActive(false);
        pauseButton.interactable = true;
        Time.timeScale = 1f;
    }
}
