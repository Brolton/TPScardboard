using UnityEngine;
using System.Collections;

public class CrossbowShot : MonoBehaviour {
    public GameObject bolt;
    public Transform Shot;
    public Rigidbody rb;
    public bool ShotRedy = true;

	void Start () {
      //  rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
        if (Input.GetButton("Fire1") && (ShotRedy == true))
        {
            Rigidbody rbshot;
           // bolt.gameObject.SetActive(false);
            rbshot = Instantiate(rb, bolt.transform.position, bolt.transform.rotation) as Rigidbody;
            rbshot.AddForce(Vector3.forward * 5000);
        //    ShotRedy = false;
                
        }

	}
}
