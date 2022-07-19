using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] HPBar hpBar; 

    public void setData(Monsters monster) {
        nameText.text = monster.Base.getName();
        levelText.text = "Lvl " + monster.Level;
        hpBar.setHP((float) monster.HP / monster.Base.getMax());
    }
}