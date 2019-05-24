using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField] int currentHealth = 100;
    Projectile collProjectile;
    [SerializeField] GameObject deathVFX;

	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update () {
		
	}

    public void damageDealt(int enemyDamage)
    {
        currentHealth -= enemyDamage;
        if(currentHealth <= 0)
        {
            TriggerDeathFX();
            Destroy(gameObject);         
        }
    }


    private void TriggerDeathFX()
    {
        if(!deathVFX)
        {
            return;
        }
        else
        {
           GameObject deathFXObject = Instantiate(deathVFX, transform.position, Quaternion.identity);
           Destroy(deathFXObject, 1f);
        }
    }

}
