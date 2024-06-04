using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;

    void Awake()
    {
        // Check if a player already exists in the scene
        GameObject existingPlayer = GameObject.FindWithTag("Player");

        if (existingPlayer == null)
        {
            // Instantiate a new player if none exists
            Instantiate(playerPrefab);
        }

        // Make the GameManager persistent across scenes
        DontDestroyOnLoad(gameObject);
    }
}