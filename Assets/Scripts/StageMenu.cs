using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StageMenu : MonoBehaviour
{
    [SerializeField] Button misi2;
    [SerializeField] Button misi3;

    private void Start()
    {


        if (PlayerPrefs.GetInt("levelAt") == 3)
        {
            misi2.interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt("levelAt") == 4)
            {
                misi3.interactable = true;
                misi2.interactable = true;
            }

        }
    }
    // private void Update()
    // {
    //     button.interactable = false;
    // }
    public void Misi1(int sceneID)
    {
        StartCoroutine(DelayMisi(sceneID));
    }

    IEnumerator DelayMisi(int sceneID)
    {
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene(sceneID);


    }

}
