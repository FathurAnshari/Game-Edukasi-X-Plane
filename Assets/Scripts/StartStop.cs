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





    void Start()
    {
        player = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CloseVideo()
    {
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
