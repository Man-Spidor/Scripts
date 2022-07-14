using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "Ability/Create New Ability")]

public class AbilityBase : ScriptableObject
{
    [SerializeField] string name;
}
