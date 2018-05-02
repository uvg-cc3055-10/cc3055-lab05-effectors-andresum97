using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {

    float time=0f;
    public GameObject gameObject;
    public GameObject gameObject2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time <= 5)
        {
            gameObject.SetActive(false);
            gameObject2.SetActive(false);
        }
        else
        if(time>5 && time<10)
        {
            gameObject.SetActive(true);
            gameObject2.SetActive(true);
        }
        else
        {
            time = 0;
        }
        
	}
}
