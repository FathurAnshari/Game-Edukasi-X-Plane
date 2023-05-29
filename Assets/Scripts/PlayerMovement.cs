using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float paddingLeft;
    [SerializeField] float paddingRight;
    [SerializeField] float paddingTop;
    [SerializeField] float paddingBottom;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform rocketLauncher;
    AudioPlayer audioPlayer;
    Waypoints waypoints;
    GameSession gameSession;


    Vector2 moveInput;
    Vector2 minBounds;
    Vector2 maxBounds;
    bool isAlive = true;
    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        initBounds();
        audioPlayer = FindAnyObjectByType<AudioPlayer>();
    }

    void Update()
    {
        if (gameSession.target == 0 && SceneManager.GetActiveScene().buildIndex == 16)
        {
            waypoints = GetComponent<Waypoints>();
            waypoints.enabled = true;
            gameObject.GetComponent<PlayerMovement>().enabled = false;
        }
        Move();
    }
    void initBounds()
    {
        Camera mainCamera = Camera.main;
        minBounds = mainCamera.ViewportToWorldPoint(new Vector2(0, 0));
        maxBounds = mainCamera.ViewportToWorldPoint(new Vector2(1, 1));
    }

    void OnFire(InputValue value)
    {
        if (!isAlive) { return; }
        Instantiate(bullet, rocketLauncher.position, transform.rotation);
        audioPlayer.PlayShootingClip();
    }

    void Move()
    {
        Vector2 delta = moveInput * moveSpeed * Time.deltaTime;
        Vector2 newPos = new Vector2();
        newPos.x = Mathf.Clamp(transform.position.x + delta.x, minBounds.x + paddingLeft, maxBounds.x - paddingRight);
        newPos.y = Mathf.Clamp(transform.position.y + delta.y, minBounds.y + paddingBottom, maxBounds.y - paddingTop);
        transform.position = newPos;
    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();


    }

}
