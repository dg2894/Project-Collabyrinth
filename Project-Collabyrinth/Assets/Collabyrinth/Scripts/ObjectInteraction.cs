using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectInteraction : MonoBehaviour {

    // Use this for initialization
    public Transform controllerPos;
    
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void PickUpObject()
    {
      transform.parent = controllerPos;
    }

    public void PutDownObject()
    {
        transform.parent = null;
    }
}
