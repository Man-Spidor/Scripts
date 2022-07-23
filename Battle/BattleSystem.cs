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

    private IEnumerator SetupBattle() {
        playerUnit.Setup();
        enemyUnit.Setup();
        playerHUD.setData(playerUnit.monster);
        enemyHUD.setData(enemyUnit.monster);

        dialogueBox.setAbilityNames(playerUnit.monster.Abilities);
        BattleButton battleButton = new BattleButton();
        battleButton.setDetails();

        yield return StartCoroutine(dialogueBox.typeDialogue($"A Wild {enemyUnit.monster.Base.name} Appeared"));
        yield return new WaitForSeconds(1f);

        PlayerAction();
    }

    private void PlayerAction() {
        state = BattleState.PlayerAction;
        StartCoroutine(dialogueBox.typeDialogue("Choose an action"));
        dialogueBox.EnableActionSelector(true);
    }

    //Button Functionalities
    public class BattleButton : BattleSystem {
        List<Ability> abilities;
        private bool clicked = false;
        
        public void setDetails() {
            abilities = playerUnit.monster.Abilities;
        }
        public void fightClicked() {
            dialogueBox.EnableaAbilitySelector(true);
            dialogueBox.EnableActionSelector(false);
            dialogueBox.EnableDialogueText(false);
        }

        public void runClicked() {
            Debug.Log("Run");
        }

        public void move1Clicked() {
            clicked = !clicked;
            if(!clicked) {
                Debug.Log("Move1");
            }
            dialogueBox.setDetailText(abilities[0].Base.getDesc(), abilities[0].Base.getCool());
        }
        
        public void move2Clicked() {
            Debug.Log("Move2");
        }
        
        public void move3Clicked() {
            Debug.Log("Move3");
        }
        
        public void move4Clicked() {
            Debug.Log("Move4");
        }
    }
}
