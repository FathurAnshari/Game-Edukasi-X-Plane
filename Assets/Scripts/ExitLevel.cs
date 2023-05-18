using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitLevel : MonoBehaviour
{
    [SerializeField] Button misi2;
    [SerializeField] Button misi3;


    void Start()
    {

    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        LoadNextScene();
    }
    private void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            FindAnyObjectByType<AchievetmentSession>().ResetAchiementSession();
            misi2.interactable = true;
            misi3.interactable = true;
            PlayerPrefs.DeleteAll();
            nextSceneIndex = 0;
        }
        else
        {
            if (nextSceneIndex == 14)
            {
                PlayerPrefs.SetInt("levelAt", 3);
                FindAnyObjectByType<AchievetmentSession>().IncreaseStar();
                misi2.interactable = true;
                misi3.interactable = false;
                nextSceneIndex = 3;
            }
            if (nextSceneIndex == 15)
            {
                PlayerPrefs.SetInt("levelAt", 4);
                FindAnyObjectByType<AchievetmentSession>().IncreaseStar();
                misi2.interactable = true;
                misi3.interactable = true;
                nextSceneIndex = 3;
            }


        }
        SceneManager.LoadScene(nextSceneIndex);


    }
    private void LoadStageLevel()
    {

    }
}
