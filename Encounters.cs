using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounters : MonoBehaviour
{
    public LayerMask grassLayer;

    private void OnCollisionEnter2D() {
        if(Physics2D.OverlapCircle(transform.position, 0.2f, grassLayer)) {
            if(Random.Range(1, 101) <= 10) Debug.Log("Encountered a wild MOM! OoO");
        }
    }
}
