using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters
{
    MonsterBase _base;
    int level;

    public int HP { get; set; }
    public List<Ability> Abilities { get; set; }

    void Monster(MonsterBase pBase, int pLevel) {
        _base = pBase;
        level = pLevel;
        HP = _base.getMax();

        Abilities = new List<Ability>();
        foreach (var ability in _base.GetAbilities()) {
            if(ability.getLevel() <= level)  Abilities.Add(new Ability(ability.GetBase()));

            if(Abilities.Count >= 4) break;
        }
    }

    public int Attack() {
        return _base.getAtt() * level;
    }
}
