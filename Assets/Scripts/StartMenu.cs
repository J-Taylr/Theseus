﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenInstructions()
    {
        //enable instructions screen
    }
}
