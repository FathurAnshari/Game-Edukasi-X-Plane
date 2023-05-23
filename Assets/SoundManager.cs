using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image soundOnIncon;
    [SerializeField] Image soundOffIcon;


    private bool muted = false;

    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {

            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
    }


    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            soundOnIncon.enabled = true;
            soundOffIcon.enabled = false;
        }
        else
        {
            soundOnIncon.enabled = false;
            soundOffIcon.enabled = true;
        }
    }


    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateButtonIcon();
    }
    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;

    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
