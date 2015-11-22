using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {
    public GameObject gameObject;

	// Use this for initialization
	void Start () {
        //Debug.Log("here");
        gameObject = Instantiate(Resources.Load("Prefabs/Segway"), new Vector3(5, 0.001f, 0) , Quaternion.identity) as GameObject;
    }
	
	// Update is called once per frame
	void Update () {
    }
}
