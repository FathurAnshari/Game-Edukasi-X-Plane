using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JawabanBenar : MonoBehaviour
{
    [SerializeField] GameObject jawabanBenar;
    GameSession gameSession;
    // Start is called before the first frame update
    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameSession.target == 0)
        {
            jawabanBenar.SetActive(true);
        }
    }

}
