using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    GameManager gameManager;

    [SerializeField] GameObject pengaturan;
    [SerializeField] GameObject profilePengembang;
    [SerializeField] GameObject materi;
    [SerializeField] GameObject resetButton;
    [SerializeField] GameObject tutorial;



    public void Mulai(int sceneID)
    {
        StartCoroutine(DelayMulai(sceneID));
    }
    public void Pengaturan()
    {
        pengaturan.SetActive(true);
    }
    public void closePengaturan()
    {
        pengaturan.SetActive(false);
    }
    public void Materi()
    {
        materi.SetActive(true);

    }
    public void closeMateri()
    {
        materi.SetActive(false);


    }
    public void profile()
    {
        profilePengembang.SetActive(true);
    }
    public void closeProfile()
    {
        profilePengembang.SetActive(false);
    }
    public void reset()
    {
        PlayerPrefs.DeleteKey("levelAt");
        Debug.Log("pressed");
    }
    public void openTutorial()
    {
        tutorial.SetActive(true);
        pengaturan.SetActive(false);
    }
    public void closeTutorial()
    {
        tutorial.SetActive(false);
        pengaturan.SetActive(true);
    }



    IEnumerator DelayMulai(int sceneID)
    {
        yield return new WaitForSecondsRealtime(0.5f);
        if (PlayerPrefs.GetInt("levelAt") > 1)
        {
            sceneID = 2;
        }
        SceneManager.LoadScene(sceneID);
    }

}
