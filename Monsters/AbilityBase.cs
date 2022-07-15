using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "Ability/Create New Ability")]

public class AbilityBase : ScriptableObject
{
    [SerializeField] string name;
    [SerializeField] string description;
    [SerializeField] int power;
    [SerializeField] int cooldown;

    public string getName() {
        return name;
    }

    public string getDesc() {
        return description;
    }

    public int getPow() {
        return power;
    }

    public int getCool() {
        return cooldown;
    }
}