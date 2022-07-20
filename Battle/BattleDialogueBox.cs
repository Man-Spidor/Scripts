using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleDialogueBox : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dialague;

    public void setDialogue(string text) {
        dialague.text = text;
    }
}
