using UnityEngine;
using System.Collections;

public class Segway : MonoBehaviour {
    //int count = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward);
        }
        
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -1);
        } else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up);
        }
    }
}
