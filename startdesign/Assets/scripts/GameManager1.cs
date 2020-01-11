using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score = 0;
    
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreUp()
    {
        score++;
        win();
    }

    void win()
    {
        s2();
    }
}
