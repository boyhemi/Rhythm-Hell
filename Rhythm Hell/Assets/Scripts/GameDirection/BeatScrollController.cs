using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScrollController : MonoBehaviour
{
    public float soundBeatValue; 
    public bool isMusicStarted;
    // Start is called before the first frame update
    void Start()
    {
        soundBeatValue = (soundBeatValue / 60f);
    }

    // Update is called once per frame
    void Update()
    {
        InitiateArrowMovements();
    }


    void InitiateArrowMovements()
    {
        if (isMusicStarted)
        {
            transform.position -= (new Vector3(0f,soundBeatValue * Time.deltaTime, 0f));

        }
    }
}
