using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int pickCount = 0;
    public int putCount = 0;

    public List<bool> itemAlive = new List<bool>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            for (int i = 0; i < 10; i++) itemAlive.Add(true);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPick() => pickCount++;
    public void AddPut() => putCount++;
}
