using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{


	void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        Screen.SetResolution(720, 1280, true);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
