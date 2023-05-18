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
        starsText.text = "= " + stars.ToString();
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
