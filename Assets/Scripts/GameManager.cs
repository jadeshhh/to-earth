using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int lives;
    public bool gameState;

    public Vector3[] enempos;
    public GameObject enemPrefab;

    // Start is called before the first frame update
    void Start()
    {
        gameState = true;
        lives = 9;

       for (int i = 0; i < enempos.Length; i++)
        {
            Instantiate(enemPrefab, enempos[i], Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            gameState = false;
        }
        if (!gameState)
        {
            Debug.Log("You lost!");
        }

    }
}
