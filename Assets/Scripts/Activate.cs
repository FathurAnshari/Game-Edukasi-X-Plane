using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Activate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject starCanvas;

    void Start()
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

    // Update is called once per frame
    void Update()
    {

    }
}
