using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AchievetmentSession : MonoBehaviour
{
    [SerializeField] int stars = 0;
    [SerializeField] TextMeshProUGUI starsText;
    [SerializeField] GameObject starCanvas;

    void Awake()
    {
        int numAchievementSession = FindObjectsOfType<AchievetmentSession>().Length;
        if (numAchievementSession > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene == 0)
        {
            starCanvas.gameObject.SetActive(false);
        }
        starsText.text = "= " + stars.ToString();

    }
    private void Update()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene == 0)
        {
            starCanvas.gameObject.SetActive(false);
        }
        if (currentScene == 3)
        {
            starCanvas.gameObject.SetActive(true);
        }
    }
    public void ProcessNextMission()
    {
        IncreaseStar();
    }

    public void IncreaseStar()
    {
        stars++;
        starsText.text = "= " + stars.ToString();

    }

    public void ResetAchiementSession()
    {
        stars = 0;
        Destroy(gameObject);
    }
}
