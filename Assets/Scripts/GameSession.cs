using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    [SerializeField] int target = 2;
    [SerializeField] GameObject exit;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ProcessNextLevel();

    }
    public void ProcessNextLevel()
    {
        if (target == 0)
        {
            exit.SetActive(true);
            DestroyNonTarget();
            DestroyCanvas();
            // target = 4;
        }
    }
    public void reduceTarget()
    {
        target--;
    }

    void DestroyNonTarget()
    {
        GameObject[] notTarget = GameObject.FindGameObjectsWithTag("Not Target");
        foreach (GameObject i in notTarget)
        {
            GameObject.Destroy(i);
        }
    }

    void DestroyCanvas()
    {
        GameObject[] notTarget = GameObject.FindGameObjectsWithTag("Canvas");
        foreach (GameObject i in notTarget)
        {
            GameObject.Destroy(i);
        }
    }

}
