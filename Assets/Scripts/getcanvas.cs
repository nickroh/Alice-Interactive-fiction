using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getcanvas : MonoBehaviour
{
	public GameObject Screen;
	Vector3 pos;
	Quaternion angle;

    // Start is called before the first frame update
    void Start()
    {	
    	LoadScreen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadScreen()
    {
    	pos = new Vector3(0,0,0);
    	angle = Quaternion.identity;
    	//GameObject screen = Resources.Load("Prefabs/Canvas") as GameObject;
    	GameObject instance = Instantiate(Screen,pos,angle);
    }
}
