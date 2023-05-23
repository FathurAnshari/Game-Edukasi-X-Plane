using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] GameObject pengaturan;



    public void Mulai(int sceneID)
    {
        if (PlayerPrefs.GetInt("levelAt") > 1)
        {
            sceneID = 2;
        }
        SceneManager.LoadScene(sceneID);
    }
    public void Pengaturan()
    {
        pengaturan.SetActive(true);
    }
    public void closePengaturan()
    {
        pengaturan.SetActive(false);
    }

}