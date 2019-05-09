using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField] int currentHealth = 100;
    Projectile collProjectile;

	// Use this for initialization
	void Start () {
		
	}


    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == ("Projectile"))
        {
            currentHealth -= 100;
        }
    }



    // Update is called once per frame
    void Update () {
		
	}
}
