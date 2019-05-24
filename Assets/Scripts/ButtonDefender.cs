using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDefender : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<ButtonDefender>();
        foreach(ButtonDefender button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(69, 69, 69, 255);
        }
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;

        FindObjectOfType<GameArea>().SetSelectedDefender(defenderPrefab);
    }
}
