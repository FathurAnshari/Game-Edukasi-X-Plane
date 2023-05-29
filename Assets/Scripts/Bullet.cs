using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 15f;
    [SerializeField] float bulletLifetime = 5f;
    [SerializeField] ParticleSystem hitEffect;
    [SerializeField] bool applyCameraShake;

    CameraShake cameraShake;

    Rigidbody2D myRigidbody;
    PlayerMovement player;
    float xSpeed;
    GameSession game;
    Misi3 misi3;
    AudioPlayer audioPlayer;

    private void Awake()
    {
        cameraShake = Camera.main.GetComponent<CameraShake>();
    }

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * bulletSpeed;
        game = FindObjectOfType<GameSession>();
        audioPlayer = FindAnyObjectByType<AudioPlayer>();
        misi3 = FindObjectOfType<Misi3>();
    }


    void Update()
    {
        myRigidbody.velocity = new Vector2(xSpeed, 1f);
        Destroy(gameObject, bulletLifetime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayHitEffect();
        audioPlayer.PlayDamageClip();
        if (other.tag == "Target")
        {
            // FindObjectOfType<GameSession>().ProcessNextLevel();
            game.reduceTarget();
            Destroy(other.gameObject);
        }
        if (other.tag == "Not Target")
        {
            ShakeCamera();
            if (currentScene <= 13)
            {
                SceneManager.LoadScene(4);
            }
            else if (currentScene > 13 && currentScene <= 16)
            {
                SceneManager.LoadScene(14);

            }
        }
        if (other.tag == "Misi3")
        {
            Destroy(other.gameObject);
            misi3.reduceTarget();
        }
        // else
        // {

        // }
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }

    void PlayHitEffect()
    {
        if (hitEffect != null)
        {
            ParticleSystem instance = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(instance.gameObject, instance.main.duration + instance.main.startLifetime.constantMax);
        }
    }
    void ShakeCamera()
    {
        if (cameraShake != null && applyCameraShake)
        {
            cameraShake.Play();
        }
    }
}
