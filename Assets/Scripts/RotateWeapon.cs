using UnityEngine;
using System.Collections;

public class RotateWeapon : MonoBehaviour {

    private Rigidbody rb;
    
   // Transform player;

    void Start()

    {
        rb = GetComponent<Rigidbody>();
    }

	void Update ()
    {
        transform.Rotate(new Vector3(45, 0, 0) * Time.deltaTime);
	}

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag ("Player"))
    //    {
    //        player = other.transform;
    //        transform.SetParent(player);
    //        gameObject.transform.position = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, 0);
                
                
    //    }
    //}


}
