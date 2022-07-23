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
    [SerializeField] GameObject abilitySelector;
    [SerializeField] GameObject abilityDetails;
    [SerializeField] TextMeshProUGUI detailTextDesc;
    [SerializeField] TextMeshProUGUI detailtTextCool;
    
    [SerializeField] List<TextMeshProUGUI> abilityText;
    [SerializeField] List<TextMeshProUGUI> actionText;

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

    public void EnableAbilitySelector(bool enabled) {
        abilitySelector.SetActive(enabled);
    }

    public void EnableAbilityDetails(bool enabled) {
        abilityDetails.SetActive(enabled);        
    }
    
    public void setAbilityNames(List<Ability> abilities) {
        for(int i = 0; i < abilityText.Count; ++i) {
            if(i < abilities.Count) {
                abilityText[i].text = abilities[i].Base.getName();
            }
            else abilityText[i].text = "-";
        }
    }

    public void setDetailText(string desc, int cool) {
        detailTextDesc.text = desc;
        detailtTextCool.text = $"{cool} Turns";
    }
}
