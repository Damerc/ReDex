﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour {

    public void doquit()
    {
        Application.Quit();
    }


    public void dorestart()
    {
        SceneManager.LoadScene("GameScreen");
    }
}
