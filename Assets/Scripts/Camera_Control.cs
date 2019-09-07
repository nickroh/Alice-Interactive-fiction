using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
	public GameObject Player;       

    private Vector3 offset;         

  	private Vector3 pos;
    
    void Start () 
    {
    	pos = Player.transform.position;
    	pos.z =- 10;
    	transform.position = pos;
        offset = transform.position - Player.transform.position;
    }
    
    void LateUpdate () 
    {
        transform.position = Player.transform.position + offset;
    }
}
