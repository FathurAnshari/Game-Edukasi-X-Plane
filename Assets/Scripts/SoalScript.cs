using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SoalScript : MonoBehaviour
{
    public TextMeshProUGUI textComponent1;
    public TextMeshProUGUI textComponent2;
    public TextMeshProUGUI textComponent3;
    public TextMeshProUGUI textComponent4;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject optionButton;
    private int index = 0;
    void Start()
    {
        textComponent1.enabled = true;
        textComponent2.enabled = false;
        textComponent3.enabled = false;
        textComponent4.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (index == 1)
        {
            textComponent1.enabled = false;
            textComponent2.enabled = true;
            textComponent3.enabled = false;
            textComponent4.enabled = false;
        }
        if (index == 2)
        {
            textComponent1.enabled = false;
            textComponent2.enabled = false;
            textComponent3.enabled = true;
            textComponent4.enabled = false;
        }
        if (index == 3)
        {
            textComponent1.enabled = false;
            textComponent2.enabled = false;
            textComponent3.enabled = false;
            textComponent4.enabled = true;
            nextButton.SetActive(false);
            optionButton.SetActive(true);
        }
    }

    public void nextText()
    {
        index++;
    }
}
