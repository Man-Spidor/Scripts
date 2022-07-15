using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{
    [SerializeField] GameObject health;

    public void setHP(float HP = 0.5f) {
        
        health.transform.localScale = new Vector3(HP, 1f);
    }
}
