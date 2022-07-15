using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class BattleHUD : MonoBehaviour
{
    [SerializeField] TextMeshPro nameText;
    [SerializeField] TextMeshPro levelText;
    [SerializeField] HPBar hpBar;

    public void setData(Monster monster) {
        nameText.text = monster.Base.getName();
        levelText.text = "Lvl " + monster.Level;
        hpBar.setHP(monster.HP / monster.maxHp);
    }
}
