using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;

    Vector2 movementInput;
    Rigidbody2D rb;
    List<RaycastHit2D> castCollision = new List<RaycastHit2D>();

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() {
        if(movementInput != Vector2.zero) {
            bool succ = tryMove(movementInput);

            if(!tryMove(movementInput)) {
                if(!tryMove(new Vector2(movementInput.x, 0)));
                else {
                    tryMove(new Vector2(0, movementInput.y);
                }
            }
        }
    }

    private bool tryMove(Vector2 direction) {
        int count = rb.Cast(direction,
                movementFilter,
                castCollision,
                moveSpeed * Time.fixedDeltaTime + collisionOffset);
        if(count == 0) {
            rb.MovePosition(rb.position + moveSpeed * movementInput * Time.fixedDeltaTime);
            return true;
        }
        else {
            return false;
        }
    }
    
    void OnMove(InputValue movementValue) {
        movementInput = movementValue.Get<Vector2>();
    } 

}
