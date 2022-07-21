using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { Start, PlayerAction, PlayerMove, EnemyMove, Busy }

public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleHUD playerHUD;
    [SerializeField] BattleUnit enemyUnit;
    [SerializeField] BattleHUD enemyHUD;
    [SerializeField] BattleDialogueBox dialogueBox;
    [SerializeField] BattleState state;

    int currentAction;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SetupBattle());
    }

    private void Update() {
        HandleActionSelection();
    } 

    private IEnumerator SetupBattle() {
        playerUnit.Setup();
        enemyUnit.Setup();
        playerHUD.setData(playerUnit.monster);
        enemyHUD.setData(enemyUnit.monster);
        yield return StartCoroutine(dialogueBox.typeDialogue($"A Wild {enemyUnit.monster.Base.name} Appeared"));
        yield return new WaitForSeconds(1f);

        PlayerAction();
    }

    private void PlayerAction() {
        state = BattleState.PlayerAction;
        StartCoroutine(dialogueBox.typeDialogue("Choose an action"));
        dialogueBox.EnableActionSelector(true);
    }

    private void HandleActionSelection() {
        // if(Input.GetKeyDown(KeyCode.DownArrow)) 
        //     if(currentAction < 1) ++currentAction;
        // else if(Input.GetKeyUp(KeyCode.UpArrow))
        //     if(currentAction > 0) --currentAction;
    }
}
