using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monster", menuName = "Monster/Create New Monster")]

public class MonsterBase : ScriptableObject
{
    [SerializeField] string monsterName;
    
    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] Classes creatureClass;

    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    [SerializeField] List<LearnableAbility> learnableAbilities; 

    public string getName() {
        return monsterName; 
    }

    public string getDesc() {
        return description;
    }

    public Sprite getFro() {
        return frontSprite;
    }

    public Sprite getBack() {
        return backSprite;
    }

    public Classes getClass() {
        return creatureClass;
    }

    public int getMax() {
        return maxHp;
    }

    public int getAtt() {
        return attack;
    }

    public int getDef() {
        return defense;
    }

    public int getSpA() {
        return spAttack;
    }

    public int getspD() {
        return spDefense;
    }

    public int getSpe() {
        return speed;
    }

    public List<LearnableAbility> GetAbilities() {
        return learnableAbilities;
    }
}

[System.Serializable]
public class LearnableAbility {
    [SerializeField] AbilityBase abilityBase;
    [SerializeField] int level;

    public AbilityBase GetBase() {
        return abilityBase;
    }

    public int getLevel() {
        return level;
    }
}

public enum Classes {
    Tank,
    Damage,
    Support
}