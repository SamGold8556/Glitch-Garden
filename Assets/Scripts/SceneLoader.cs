using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    int currentSceneIndex;
	// Use this for initialization
	void Start () {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(LoadStartScreen());
        }
    }
	
    IEnumerator LoadStartScreen()
    {
        yield return new WaitForSeconds(3);
        LoadNextScene();
        //SceneManager.LoadScene("Start Screen");

    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Update is called once per frame
    void Update () {
		
	}



}
