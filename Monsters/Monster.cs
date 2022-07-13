using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters
{
    MonsterBase _base;
    int level;
    
    void Monster(MonsterBase pBase, int pLevel) {
        _base = pBase;
        level = pLevel;
    }

    public int Attack() {
        return _base.getAtt() * level;
    }
}
