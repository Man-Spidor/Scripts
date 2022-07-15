using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleHUD : MonoBehaviour
{
    [SerializeField] TextMeshPro nameText;
    [SerializeField] TextMeshPro levelText;
    [SerializeField] HPBar hpBar;

    public void setData(Monsters monster) {
        nameText.text = monster.Base.getName();
        levelText.text = "Lvl " + monster.Level;
        hpBar.setHP((float) monster.HP / monster.Base.getMax());
    }
}