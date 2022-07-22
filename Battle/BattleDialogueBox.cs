using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleDialogueBox : MonoBehaviour
{
    [SerializeField] int lettersPerSecond = 30;
    [SerializeField] Color highlight;
    [SerializeField] TextMeshProUGUI dialogue;
    [SerializeField] GameObject actionsSelector;
    [SerializeField] GameObject moveSelector;
    [SerializeField] GameObject moveDetails;
    
    [SerializeField] List<TextMeshProUGUI> moveText;
    [SerializeField] List<TextMeshProUGUI> actionText;

    [SerializeField] TextMeshProUGUI detailText;

    public void setDialogue(string text) {
        dialogue.text = text;
    }

    public IEnumerator typeDialogue(string text) {
        dialogue.text = "";

        foreach (var letter in text) {
            dialogue.text += letter;
            yield return new WaitForSeconds(1f/lettersPerSecond);
        }
    }

    public void EnableDialogueText(bool enabled) {
        dialogue.enabled = enabled;
    }

    public void EnableActionSelector(bool enabled) {
        actionsSelector.SetActive(enabled);
    }

    public void EnableMoveSelector(bool enabled) {
        moveSelector.SetActive(enabled);
        moveDetails.SetActive(enabled);
    }
    
}
