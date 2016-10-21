using UnityEngine;
using System.Collections;

public class PlayerRotating : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (1, 1, 1);
	}
}
