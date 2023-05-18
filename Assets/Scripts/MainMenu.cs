using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update


    public void Mulai(int sceneID)
    {
        if (PlayerPrefs.GetInt("levelAt") > 1)
        {
            sceneID = 2;
        }
        SceneManager.LoadScene(sceneID);
    }
}
