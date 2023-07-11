using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootButton : MonoBehaviour
{

    [SerializeField] GameObject bullet;

    [SerializeField] Transform rocketLauncher;
    AudioPlayer audioPlayer;
    bool isAlive = true;
    void Start()
    {
        audioPlayer = FindAnyObjectByType<AudioPlayer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Fire()
    {
        if (!isAlive) { return; }
        Instantiate(bullet, rocketLauncher.position, transform.rotation);
        audioPlayer.PlayShootingClip();
    }
}
