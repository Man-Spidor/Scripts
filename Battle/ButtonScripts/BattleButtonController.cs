using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleButtonController : MonoBehaviour
{
    [SerializeField] BattleDialogueBox dialogueBox;

    public void fightClicked() {
        dialogueBox.EnableMoveSelector(true);
        dialogueBox.EnableActionSelector(false);
        dialogueBox.EnableDialogueText(false);
    }

    public void runClicked() {
        Debug.Log("Run");
    }

    public void move1Clicked() {
        Debug.Log("Move1");
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
