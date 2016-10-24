using UnityEngine;
using System.Collections;

public class PlayerWeapons : MonoBehaviour {
    public GameObject CrossBowPL;
    public GameObject CannonPl;
    private bool Crossbow = false;
    private bool Cannon = false;


    void Start()
    {
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (IsWeapon(other.gameObject))
        {
            if (other.gameObject.name == "Crossbow")
            {
                CrossBowPL.SetActive(true);
                Crossbow = true;
                CannonPl.SetActive(false);
                Destroy(other.gameObject);
            }
            else if (other.gameObject.name == "Cannon")
            {
                CannonPl.SetActive(true);
                Cannon = true;
                CrossBowPL.SetActive(false);
                Destroy(other.gameObject);
            }
        }
    }

    bool  IsWeapon(GameObject obj)
    {
        return (obj.CompareTag("Weapon"));
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1) && Crossbow)
        {
            CrossBowPL.SetActive(true);
            CannonPl.SetActive(false);
        }

        if (Input.GetKey(KeyCode.Alpha2) && Cannon)
        { 
        CannonPl.SetActive(true);
        CrossBowPL.SetActive(false);
        }
    }

}
