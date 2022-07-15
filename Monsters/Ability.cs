using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability
{
    public AbilityBase Base { get; set;}
    public int cooldown { get; set; }

    public Ability(AbilityBase pBase) {
        Base = pBase;
        cooldown = pBase.getCool();
    }
}
