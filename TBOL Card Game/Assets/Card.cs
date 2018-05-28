using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {

    private bool stickedToMouse = false;
    private Vector3 mousePosition;
    private GameObject player;
    public AllyBoardController board;

    //tags for any cause
    private string cardTags = "CARD_TAG_CREATURE"; //base card tags {CARD_TAG_CREATURE, CARD_TAG_SPELL}
    private string creatureTags = "CARD_TAG_CREATURE_MELEE"; //tags for creatures {CARD_TAG_CREATURE_MELEE, CARD_TAG_CREATURE_RANGED}
    private string spellTargetTags = ""; //tags for spells (CARD_TAG_TARGET_ALLY, CARD_TAG_TARGET_ENEMY, CARD_TAG_TARGET_CREATURE, CARD_TAG_TARGET_HERO, CARD_TAG_TARGET_NO_TARGET)
    //public string 

    void GetAvailableTiles()
    {
        if (IsCreature())
        {

        }
    }

    public bool IsCreature()
    {
        if (cardTags == "CARD_TAG_CREATURE")
            return true;
        else
            return false;
    }

    public bool IsSpell()
    {
        if (cardTags == "CARD_TAG_SPELL")
            return true;
        else
            return false;
    }

    public bool IsMelee()
    {
        if (creatureTags == "CARD_TAG_CREATURE_MELEE")
            return true;
        else
            return false;
    }

    public bool IsRanged()
    {
        if (creatureTags == "CARD_TAG_CREATURE_RANGED")
            return true;
        else
            return false;
    }

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Hero");
        board = GameObject.Find("Board").GetComponent<AllyBoardController>();
    }

    // Update is called once per frame
    void Update() {
        if (stickedToMouse)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = transform.position.z;
            transform.position = mousePosition;
        }
	}

    void OnMouseDown()
    {
        if (stickedToMouse) {
            stickedToMouse = false;
            transform.localScale = new Vector3(0.3f, 0.3f, 1);
            player.GetComponent<PlayerController>().cardHolded = null;
            board.RemoveGlow();
        }
        else
        {
            stickedToMouse = true;
            transform.localScale = new Vector3(0.35f, 0.35f, 1);
            player.GetComponent<PlayerController>().cardHolded = this;
            board.GlowAvailableTiles(this);
        }
    }
}
