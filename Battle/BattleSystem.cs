using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleHUD playerHUD;


    // Start is called before the first frame update
    void Start()
    {
        SetupBattle();
    }

    private void SetupBattle() {
        playerUnit.Setup();
        playerHUD.setData(playerUnit.monster);
    }
}
