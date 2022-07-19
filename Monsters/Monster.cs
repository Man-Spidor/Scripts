using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters
{
    public MonsterBase Base { get; set; }
    public int Level {get; set; }

    public int HP { get; set; }
    public List<Ability> Abilities { get; set; }

    public Monsters(MonsterBase pBase, int pLevel) {
        Base = pBase;
        Level = pLevel;
        HP = getHP();

        Abilities = new List<Ability>();
        foreach (var ability in Base.GetAbilities()) {
            if(ability.getLevel() <= Level)  Abilities.Add(new Ability(ability.GetBase()));

            if(Abilities.Count >= 4) break;
        }
    }

    public int Attack() {
        return Base.getAtt() * Level;
    }

    public int getHP() {
        return Base.getMax();
    }
}
