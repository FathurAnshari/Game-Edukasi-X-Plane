using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    [SerializeField] GameObject page1;
    [SerializeField] GameObject page2;
    [SerializeField] GameObject prev;
    [SerializeField] GameObject next;
    public int index = 0;
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
            next.SetActive(true);

        }
        else if (index == 2)
        {
            prev.SetActive(true);
            page1.SetActive(false);
            page2.SetActive(true);
            next.SetActive(false);
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
