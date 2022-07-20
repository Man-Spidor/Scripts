using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleDialogueBox : MonoBehaviour
{
    [SerializeField] int lettersPerSecond = 30;
    [SerializeField] TextMeshProUGUI dialague;

    public void setDialogue(string text) {
        dialague.text = text;
    }

    public IEnumerator typeDialogue(string text) {
        dialague.text = "";

        foreach (var letter in text) {
            dialague.text += letter;
            yield return new WaitForSeconds(1f/lettersPerSecond);
        }
    }
}
