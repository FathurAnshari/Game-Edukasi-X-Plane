using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class AchievetmentSession : MonoBehaviour
{
    public int stars = 0;
    [SerializeField] TextMeshProUGUI starsText;
    [SerializeField] GameObject starCanvas;
    [SerializeField] Animator transitionAnim;
    [SerializeField] Button misi2;
    [SerializeField] Button misi3;

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

    public IEnumerator LoadLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            PlayerPrefs.DeleteKey("levelAt");
            misi2.interactable = true;
            misi3.interactable = true;
            nextSceneIndex = 0;
        }
        else
        {
            if (nextSceneIndex == 14)
            {
                PlayerPrefs.SetInt("levelAt", 3);
                misi2.interactable = true;
                misi3.interactable = false;
                nextSceneIndex = 3;
            }

            else if (nextSceneIndex == 17)
            {
                PlayerPrefs.SetInt("levelAt", 4);
                misi2.interactable = true;
                misi3.interactable = true;
                nextSceneIndex = 3;
            }

        }
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(nextSceneIndex);
        transitionAnim.SetTrigger("Start");

    }
}
