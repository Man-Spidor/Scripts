using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleButtonController : MonoBehaviour {
    [SerializeField] BattleDialogueBox dialogueBox;
    private bool clicked = false;
    
    public void setDetails(List<Ability> abilities) {
        
    }
    public void fightClicked() {
        dialogueBox.EnableaAbilitySelector(true);
        dialogueBox.EnableActionSelector(false);
        dialogueBox.EnableDialogueText(false);
    }

    public void runClicked() {
        Debug.Log("Run");
    }

    public void move1Clicked() {
        clicked = !clicked;
        if(!clicked) {
            Debug.Log("Move1");
        }
        // dialogueBox.setDetailText(abilities[0].Base.getDesc(), abilities[0].Base.getCool());
    }
    
    public void move2Clicked() {
        Debug.Log("Move2");
    }
    
    public void move3Clicked() {
        Debug.Log("Move3");
    }
    
    public void move4Clicked() {
        Debug.Log("Move4");
    }
}