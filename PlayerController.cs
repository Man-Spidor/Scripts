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
            int count = rb.Cast(movementInput,
                movementFilter,
                castCollision,
                moveSpeed * Time.fixedDeltaTime + collisionOffset);

            Vector3 targetPos = new Vector2(transform.position.x + movementInput.x, transform.position.y + movementInput.y);            

            if(count == 0) {
                while (transform.position != targetPos) {
                    transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
                }
            }
        }
    }

    // private bool tryMove(Vector2 direction) {
    // }
    
    void OnMove(InputValue movementValue) {
        movementInput = movementValue.Get<Vector2>();
    }  
}
