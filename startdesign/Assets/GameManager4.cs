﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreUp()
    {
        ScoreUp++;
        win();
    }
    void win()
    {
        s5();
    }
}
