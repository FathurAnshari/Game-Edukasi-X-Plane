using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misi3 : MonoBehaviour
{
    [SerializeField] int target = 15;
    [SerializeField] GameObject target1;
    [SerializeField] GameObject target2;
    [SerializeField] GameObject target3;
    [SerializeField] GameObject target4;
    [SerializeField] GameObject target5;
    [SerializeField] GameObject target6;
    [SerializeField] GameObject target7;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target == 14)
        {
            target1.SetActive(false);
            target2.SetActive(true);
        }
        if (target == 13)
        {
            target2.SetActive(false);
            target3.SetActive(true);
        }
        if (target == 12)
        {
            target3.SetActive(false);
            target4.SetActive(true);
        }
        if (target == 8)
        {
            target4.SetActive(false);
            target5.SetActive(true);
        }
    }

    public void reduceTarget()
    {
        target--;
    }
}
