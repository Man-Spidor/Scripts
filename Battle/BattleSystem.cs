using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleHUD playerHUD;

    [SerializeField] BattleUnit enemyUnit;
    [SerializeField] BattleHUD enemyHUD;

    // Start is called before the first frame update
    void Start()
    {
        SetupBattle();
    }

    private void SetupBattle() {
        playerUnit.Setup();
        enemyUnit.Setup();
        playerHUD.setData(playerUnit.monster);
        enemyHUD.setData(enemyUnit.monster);
    }
}
