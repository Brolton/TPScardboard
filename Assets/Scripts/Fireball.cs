﻿using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour {

	public float speed = 10.0f;
	public int damage = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 0, speed * Time.deltaTime);
	}


	void OnTriggerEnter(Collider other) {
		PlayerCharacter player = other.GetComponent<PlayerCharacter>();
		if (player != null) {
			player.Hurt (damage);
		}
		Destroy(this.gameObject);
	}
}
