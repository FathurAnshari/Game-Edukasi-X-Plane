using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Sprites;
using UnityEngine.UI;
using System;

public class StartStop : MonoBehaviour
{
    private VideoPlayer player;
    public Button button;
    public Sprite startSprite;
    public Sprite stopSprite;
    [SerializeField] GameObject canvas;
    AudioPlayer audioPlayer;






    void Start()
    {
        player = GetComponent<VideoPlayer>();
        audioPlayer = FindObjectOfType<AudioPlayer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CloseVideo()
    {
        audioPlayer.GetComponent<AudioSource>().Play();
        canvas.SetActive(false);
        player.Stop();
        player.targetTexture.Release();


        // button.image.sprite = startSprite;
    }

    public void ChangeStartStop()
    {
        if (player.isPlaying == false)
        {
            player.Play();
            button.image.sprite = stopSprite;

        }
        else
        {
            player.Pause();
            button.image.sprite = startSprite;
        }
    }


}
