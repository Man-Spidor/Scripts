using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] MonsterBase _base;
    [SerializeField] int Level;
    [SerializeField] bool isPlayer;

    public Monsters monster { get; set; }

    public void Setup() {
        monster = new Monsters(_base, Level);
        if(isPlayer) GetComponent<Image>().sprite = monster.Base.getBack();

        else GetComponent<Image>().sprite = monster.Base.getFro();
    }
}
