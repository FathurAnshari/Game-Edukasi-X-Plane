using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;


public class OpenVideoPlayer : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    StartStop start;
    public VideoPlayer player;
    public Sprite stopSprite;
    public Button button;




    void Start()
    {
        // player = GetComponent<VideoPlayer>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayVideo()
    {
        canvas.SetActive(true);
        player.Play();
        button.image.sprite = stopSprite;

        // player.Play();
    }
}
