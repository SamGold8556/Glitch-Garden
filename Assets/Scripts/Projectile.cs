using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [SerializeField] float projectileSpeed = 8f, spinSpeed = 5f;
    [SerializeField] int projectileDamage = 50;

	// Use this for initialization
	void Start () {		

	}
	

    public int getDamage()
    {
        return projectileDamage;
    }


    public void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.tag == ("Enemy"))
        {
            collider.gameObject.GetComponent<Health>().damageDealt(projectileDamage);
            //Destroy(collider.gameObject);
            Destroy(gameObject);
        }
    }




        // Update is called once per frame
        void Update () {
        transform.Rotate(0, 0, -45, Space.World);
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime, Space.World);
        //transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime); 
        
    }
}
