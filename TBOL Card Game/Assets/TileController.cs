using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour {

    private Card card = null;
    private bool isAvailable = false;
    private Color cGreen = new Color(0, 255, 0);
    private Color cWhite = new Color(255, 255, 255);
    private Color cYellow = new Color(255, 255, 0);
    private Vector3 mousePosition;

    public Card GetCard()
    {
        return card;
    }

    public bool IsEmpty()
    {
        if (card == null)
            return true;
        else
            return false;
    }

    public void SetAvailability(bool choice)
    {
        isAvailable = choice;
    }

    public bool GetAvailability()
    {
        if (isAvailable)
            return true;
        else
            return false;
    }

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void LateUpdate () {
        if (GetAvailability() && GetComponent<SpriteRenderer>().color != cGreen)
        {
            GetComponent<SpriteRenderer>().color = cGreen;
        }
        else if(GetAvailability() == false && GetComponent<SpriteRenderer>().color != cWhite)
        {
            GetComponent<SpriteRenderer>().color = cWhite;
        }
    }

    void OnMouseEnter()
    {
        Debug.Log("a");
        if (GetAvailability())
            transform.localScale = new Vector3(0.45f, 0.45f, 1);
    }

    void OnMouseExit()
    {
        if (GetAvailability())
            transform.localScale = new Vector3(0.4f, 0.4f, 1);
    }


}
