using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleButtonController : MonoBehaviour {
    [SerializeField] BattleDialogueBox dialogueBox;

    private List<Ability> abilities;
    private int clicked;
    
    public void setDetails(List<Ability> _abilities) {
        abilities = _abilities;
    }
    public void fightClicked() {
        dialogueBox.EnableAbilitySelector(true);
        dialogueBox.EnableActionSelector(false);
        dialogueBox.EnableDialogueText(false);
    }

    public void runClicked() {
        Debug.Log("Run");
    }

    public void move1Clicked() {
        if(clicked == 1) {
            Debug.Log("Move1");
        }   
        dialogueBox.setDetailText(abilities[0].Base.getDesc(), abilities[0].Base.getCool());
        dialogueBox.EnableAbilityDetails(true);

        clicked = 1;
    }
    
    public void move2Clicked() {
        if(clicked == 2) {
            Debug.Log("Move 2");
        }
        dialogueBox.setDetailText(abilities[1].Base.getDesc(), abilities[1].Base.getCool());
        dialogueBox.EnableAbilityDetails(true);

        clicked = 2;
    }
    
    public void move3Clicked() {
        if(clicked == 3) {
            Debug.Log("Move3");
        }
        dialogueBox.setDetailText(abilities[2].Base.getDesc(), abilities[2].Base.getCool());
        dialogueBox.EnableAbilityDetails(true);

        clicked = 3;
    }
    
    public void move4Clicked() {
        if(clicked == 4) {
            Debug.Log("Move4");
        }
        dialogueBox.setDetailText(abilities[3].Base.getDesc(), abilities[3].Base.getCool());
        dialogueBox.EnableAbilityDetails(true);

        clicked = 4;
    }
}