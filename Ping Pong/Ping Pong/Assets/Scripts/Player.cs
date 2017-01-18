using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            transform.localPosition += new Vector3(0, 4.5f, 0) * Time.deltaTime;
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            transform.localPosition += new Vector3(0, -4.5f, 0) * Time.deltaTime;
        }

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.85f, 3.85f), 0);
    }
}
