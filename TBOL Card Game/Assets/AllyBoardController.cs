using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyBoardController : MonoBehaviour {

    public GameObject[] meleeTiles = new GameObject[5];
    public GameObject[] rangeTiles = new GameObject[5];
    public PlayerController player;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Hero").GetComponent<PlayerController>();
    }
	
	// Update is called once per frame
	void Update () {
	}

    public GameObject[] GetMeleeTiles()
    {
        return meleeTiles;
    }

    public GameObject[] GetRangeTiles()
    {
        return rangeTiles;
    }

    public void GlowAvailableTiles(Card Card)
    {
        if (Card.IsMelee())
        {
            foreach (GameObject tile in meleeTiles)
            {
                if (tile.GetComponent<TileController>().IsEmpty())
                {
                    tile.GetComponent<TileController>().SetAvailability(true);
                }
            }
        }

        else if (Card.IsRanged())
        {
            foreach (GameObject tile in rangeTiles)
            {
                if (tile.GetComponent<TileController>().IsEmpty())
                {
                    tile.GetComponent<TileController>().SetAvailability(true);
                }
            }
        }
    }

    public void RemoveGlow()
    {
        foreach (GameObject tile in meleeTiles)
        {
            tile.GetComponent<TileController>().SetAvailability(false);
        }

        foreach (GameObject tile in rangeTiles)
        {
            tile.GetComponent<TileController>().SetAvailability(false);
        }
    }
}
