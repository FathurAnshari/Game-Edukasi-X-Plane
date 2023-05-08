using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StageMenu : MonoBehaviour
{
    Button button;


    private void Start()
    {
        button = GetComponent<Button>();
    }
    // private void Update()
    // {
    //     button.interactable = false;
    // }
    public void Misi1(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

}
