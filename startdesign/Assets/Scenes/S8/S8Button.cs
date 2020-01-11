using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S8Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void s8()
    {
        void OnMouseDown()
        {
            GameObject.Find("GameManager").GetComponent<GameManager8>().ScoreUp();


        }
    }
}
