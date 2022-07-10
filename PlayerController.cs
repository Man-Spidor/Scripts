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

    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate() {
        if(!isMoving) {
            if((transform.position.x % 0.5f == 0) || (transform.position.y % 0.5f == 0)) {
                Debug.Log("first");              
                if(movementInput != Vector2.zero) {
                    int count = rb.Cast(movementInput,
                        movementFilter,
                        castCollision,
                        moveSpeed * Time.fixedDeltaTime + collisionOffset);
                    
                    Vector3 targetPos = new Vector2(transform.position.x + movementInput.x, transform.position.y + movementInput.y);            
                    
                    Debug.Log(targetPos);
                    
                    if(movementInput.x != 0) movementInput.y = 0;
                    
                    if(count == 0) {
                        StartCoroutine(Move(targetPos));
                    }
                }
            }
            else {
                Debug.Log("test");
                Vector3 targetPos = transform.position;
                float xDiff;
                float yDiff;
                if(transform.position.x < 0) {
                    xDiff = transform.position.x % -0.5f;
                    targetPos.x = targetPos.x - xDiff - 0.5f;
                }
                else {
                    xDiff = transform.position.x % 0.5f;
                    targetPos.x = targetPos.x - xDiff + 0.5f;
                }

                if(transform.position.y < 0) {
                    yDiff = transform.position.y % -0.5f;
                    targetPos.y = targetPos.y - yDiff - 0.5f;
                }
                else {
                    yDiff = transform.position.y % 0.5f;
                    targetPos.y = targetPos.y - yDiff + 0.5f;
                }
                StartCoroutine(Move(targetPos));
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
