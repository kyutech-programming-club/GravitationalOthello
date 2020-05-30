﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OthelloCell : MonoBehaviour {
    int ownerID = -1;
    public Image ChipImage;
    public Vector2 Location;
    public Text CellEffectText;
    public int TurnNumber;
    public int OwnerID {
        get { return ownerID; }
        set
        {
            ownerID = value;
            ChipImage.color = OthelloBoard.Instance.PlayerChipColors[ownerID+1];
            if(ownerID == 2)
                this.GetComponent<Button>().interactable = true;
            else
                this.GetComponent<Button>().interactable = false;
        }
    }
    public void CellPressed() {
        if(this.OwnerID == 2) {
            OthelloBoard.Instance.PlaceHere(this);
            OthelloBoard.Instance.EraseCellOverdTurn();
            OthelloBoard.Instance.EndTurn(false);
            OthelloBoard.Instance.ShowAllCanPlace();
        }
    }
}
