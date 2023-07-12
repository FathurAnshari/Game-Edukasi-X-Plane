using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 15f;
    [SerializeField] float bulletLifetime = 5f;
    [SerializeField] ParticleSystem hitEffect;
    [SerializeField] bool applyCameraShake;
    Button bantuanButton;

    CameraShake cameraShake;

    Rigidbody2D myRigidbody;
    PlayerMovement player;
    float xSpeed;
    GameSession game;
    // Misi3 misi3;
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
        // misi3 = FindObjectOfType<Misi3>();
        gameObject.transform.eulerAngles = new Vector3(0, 0, -90);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        switch (currentScene)
        {
            case 10:
                bantuanButton = GameObject.FindGameObjectWithTag("Bantuan").GetComponent<Button>();
                break;
            case 11:
                bantuanButton = GameObject.FindGameObjectWithTag("Bantuan").GetComponent<Button>();
                break;
            case 13:
                bantuanButton = GameObject.FindGameObjectWithTag("Bantuan").GetComponent<Button>();
                break;

            case 14:
                bantuanButton = GameObject.FindGameObjectWithTag("Bantuan").GetComponent<Button>();
                break;
            case 15:
                bantuanButton = GameObject.FindGameObjectWithTag("Bantuan").GetComponent<Button>();
                break;
            case 18:
                bantuanButton = GameObject.FindGameObjectWithTag("Bantuan").GetComponent<Button>();
                break;
        }



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
            if (currentScene <= 18)
            {
                switch (currentScene)
                {
                    case 4:
                        SceneManager.LoadScene(currentScene);
                        break;
                    case 5:
                        SceneManager.LoadScene(currentScene - 1);
                        break;
                    case 6:
                        SceneManager.LoadScene(currentScene - 1);
                        break;
                    case 7:
                        SceneManager.LoadScene(currentScene);
                        break;
                    case 8:
                        SceneManager.LoadScene(currentScene - 1);
                        break;
                    case 9:
                        SceneManager.LoadScene(currentScene - 1);
                        break;
                    case 10:
                        bantuanButton.interactable = true;
                        break;
                    case 11:
                        bantuanButton.interactable = true;
                        break;
                    case 12:
                        SceneManager.LoadScene(currentScene - 1);
                        break;
                    case 13:
                        bantuanButton.interactable = true;
                        break;
                    case 14:
                        bantuanButton.interactable = true;
                        break;
                    case 15:
                        bantuanButton.interactable = true;
                        break;
                    case 16:
                        SceneManager.LoadScene(currentScene - 1);
                        break;
                    case 17:
                        SceneManager.LoadScene(currentScene - 1);
                        break;
                    case 18:
                        bantuanButton.interactable = true;
                        break;
                }

                // if (currentScene == 4)
                // {
                //     SceneManager.LoadScene(currentScene);
                // }
                // else
                // {

                //     SceneManager.LoadScene(currentScene - 1);
                // }
            }
            // else if (currentScene > 6 && currentScene <= 17)
            // {
            //     if (currentScene == 7)
            //     {
            //         SceneManager.LoadScene(currentScene);
            //     }
            //     else
            //     {
            //         SceneManager.LoadScene(currentScene - 1);
            //     }
            // }
            // else if (currentScene == 18)
            // {
            //     SceneManager.LoadScene(currentScene);
            // }
            // else
            // {
            //     SceneManager.LoadScene(currentScene);
            // }
        }
        // if (other.tag == "Misi3")
        // {
        //     Destroy(other.gameObject);
        //     misi3.reduceTarget();
        // }
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
