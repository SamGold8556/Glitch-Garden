using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    [SerializeField] GameObject projectileObject;
    [SerializeField] GameObject gunObject;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }




    public void Fire()
    {
        Instantiate(projectileObject, gunObject.transform.position, Quaternion.identity);
        //projectileObject.transform.Translate(Vector2.right * Time.deltaTime);
    }
}