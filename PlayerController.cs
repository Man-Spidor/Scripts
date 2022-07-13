using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;
    public Transform movePoint;
    public LayerMask grassLayer;

    Vector2 movementInput;
    Rigidbody2D rb;
    List<RaycastHit2D> castCollision = new List<RaycastHit2D>();

    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movePoint.parent = null;
        isMoving = false;
    }

    // Update is called once per frame
    private void Update() {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        if(Vector3.Distance(transform.position, movePoint.position) == 0) {
            if(movementInput != Vector2.zero) {
                int count = rb.Cast(movementInput,
                    movementFilter,
                    castCollision,
                    moveSpeed * Time.fixedDeltaTime + collisionOffset);
                
                if(movementInput.x != 0) movementInput.y = 0;

                if(count == 0) {
                    if(movementInput.x < 0) movePoint.position = new Vector3(transform.position.x -1, transform.position.y, 0);
                    else if(movementInput.x > 0) movePoint.position = new Vector3(transform.position.x + 1, transform.position.y, 0);
                    else {
                        if(movementInput.y < 0) movePoint.position = new Vector3(transform.position.x, transform.position.y - 1, 0);
                        else movePoint.position = new Vector3(transform.position.x, transform.position.y + 1, 0);
                    }
                }
                // transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
           }
            if(isMoving) {
                checkForGrass();
            } 
        }
    }
    
    void OnMove(InputValue movementValue) {
        movementInput = movementValue.Get<Vector2>();
        isMoving = !isMoving;
    }  

    void checkForGrass() {
        if(Physics2D.OverlapCircle(movePoint.position, 0.2f, grassLayer)) {
            if(Random.Range(1, 101) <= 10) Debug.Log("Encountered a wild MOM! OoO");
        }
    }
}
