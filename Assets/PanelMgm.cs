using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMgm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    	gameObject.SetActive(false);
    }

    void MenuOn()
    {
    	gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
