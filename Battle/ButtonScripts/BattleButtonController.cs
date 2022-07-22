using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleButtonController : MonoBehaviour
{
    [SerializeField] GameObject dialogueBox;
    [SerializeField] GameObject actionSelector;
    [SerializeField] GameObject moveDetails;
    [SerializeField] GameObject moveSelector;
    // [SerializeField] GameObject move1Button;
    // [SerializeField] GameObject move2Button;
    // [SerializeField] GameObject move3Button;
    // [SerializeField] GameObject move4Button;

    public void fightClicked() {
        dialogueBox.SetActive(false);
        actionSelector.SetActive(false);
        moveSelector.SetActive(true);
        moveDetails.SetActive(true);
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
