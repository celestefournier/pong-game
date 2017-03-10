using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("uau");
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("uau1");
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("uau3");
    }
}