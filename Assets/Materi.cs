using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materi : MonoBehaviour
{
    [SerializeField] GameObject page1;
    [SerializeField] GameObject page2;
    [SerializeField] GameObject page3;
    [SerializeField] GameObject page4;
    [SerializeField] GameObject page5;
    [SerializeField] GameObject page6;
    [SerializeField] GameObject page7;
    public int index = 0;
    [SerializeField] GameObject prev;
    [SerializeField] GameObject next;

    void Start()
    {
        index = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (index == 1)
        {
            prev.SetActive(false);
            page1.SetActive(true);
            page2.SetActive(false);

        }
        else if (index == 2)
        {
            prev.SetActive(true);
            page1.SetActive(false);
            page2.SetActive(true);
            page3.SetActive(false);
        }
        else if (index == 3)
        {
            page2.SetActive(false);
            page3.SetActive(true);
            page4.SetActive(false);
        }
        else if (index == 4)
        {
            page3.SetActive(false);
            page4.SetActive(true);
            page5.SetActive(false);
        }
        else if (index == 5)
        {
            page4.SetActive(false);
            page5.SetActive(true);
            page6.SetActive(false);
        }
        else if (index == 6)
        {
            page5.SetActive(false);
            page6.SetActive(true);
            page7.SetActive(false);
            next.SetActive(true);
        }
        else if (index == 7)
        {
            next.SetActive(false);
            page6.SetActive(false);
            page7.SetActive(true);
        }

    }
    public void nextButton()
    {
        index++;
        Debug.Log("pressed");
    }
    public void prevButton()
    {
        index = index - 1;
        Debug.Log("pressed");
    }

}
