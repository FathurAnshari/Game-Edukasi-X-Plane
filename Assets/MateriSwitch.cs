using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MateriSwitch : MonoBehaviour
{
    [SerializeField] Button materi;
    void Start()
    {
        if (PlayerPrefs.GetInt("levelAt") == 5)
        {
            materi.interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
