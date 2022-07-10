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

    Vector2 movementInput;
    Rigidbody2D rb;
    List<RaycastHit2D> castCollision = new List<RaycastHit2D>();

    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movePoint.parent = null;
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
                    isMoving = true;
                    movePoint.position += new Vector3(movementInput.x, movementInput.y, 0f);

                    // StartCoroutine(Move(targetPos));
                }
           }
        }
    }

    IEnumerator Move(Vector3 targetPos) {
        isMoving = true;
        while((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon) {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;
        isMoving = false;
    }
    
    void OnMove(InputValue movementValue) {
        movementInput = movementValue.Get<Vector2>();
    }  
}
