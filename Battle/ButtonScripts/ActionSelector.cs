using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSelector : MonoBehaviour
{
    private void displayMoves() {
        Debug.Log("Move!!!");
    }

    public void ButtonClicked() {
        displayMoves();
    }
}
