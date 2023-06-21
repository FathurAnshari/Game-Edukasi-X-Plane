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
