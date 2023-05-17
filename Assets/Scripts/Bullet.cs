using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 15f;
    [SerializeField] float bulletLifetime = 5f;
    Rigidbody2D myRigidbody;
    PlayerMovement player;
    float xSpeed;
    GameSession game;


    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * bulletSpeed;
        game = FindObjectOfType<GameSession>();
    }


    void Update()
    {
        myRigidbody.velocity = new Vector2(xSpeed, 1f);
        Destroy(gameObject, bulletLifetime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Target")
        {
            game.reduceTarget();
            Destroy(other.gameObject);
        }
        // if (other.tag == "Canvas")
        // {
        //     Destroy(other.gameObject);
        // }
        else
        {
            int currentScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentScene);
        }
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
