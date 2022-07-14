using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monster", menuName = "Monster/Create New Monster")]

public class AbilityBase : ScriptableObject
{
    [SerializeField] string name;
}
