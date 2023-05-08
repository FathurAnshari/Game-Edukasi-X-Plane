using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    [SerializeField] int target = 4;
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
            target = 4;
        }
    }
    public void reduceTarget()
    {
        target--;
    }
}
