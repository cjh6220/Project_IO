﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        Debug.Log("한판더");
        IOGameManager.Instance.ResetGame();
    }

    public void Quit()
    {
        Debug.Log("안할래");
        SceneManager.LoadScene("Loby");
    }
}
