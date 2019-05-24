using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameArea : MonoBehaviour {

    Defender defender;

	// Use this for initialization
	void Start () {
		
	}

    private void OnMouseDown()
    {
        //Instantiate(Defender, transform.position, Quaternion.identity);
        Debug.Log("Mouse Button Pressed");
        SpawnDefender();
    }

    public void SetSelectedDefender(Defender selectedDefender)
    {
        defender = selectedDefender;
    }


    private Vector2 GetSquareClicked()
    {
        Vector2 mousePOS = new Vector2(Mathf.Floor(Input.mousePosition.x), Mathf.Floor(Input.mousePosition.y));
        Debug.Log("Mouse POS x is" + Mathf.Floor(Input.mousePosition.x));
        Vector2 worldPOS = Camera.main.ScreenToWorldPoint(mousePOS);
        return SnapToGrid(worldPOS);

    }

    private Vector2 SnapToGrid(Vector2 rawWorldPOS)
    {
        float newXPOS = Mathf.RoundToInt(rawWorldPOS.x);
        float newYPOS = Mathf.RoundToInt(rawWorldPOS.y);

        Vector2 snappedPOS = new Vector2(newXPOS, newYPOS);
        return snappedPOS;
    }

    private void SpawnDefender()
    {
        Defender newDefender = Instantiate(defender, GetSquareClicked(), Quaternion.identity) as Defender;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
