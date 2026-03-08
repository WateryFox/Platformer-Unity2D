using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpSpeed = 20f;
    public bool isGround = false;
    public float groundDist = 1f;
    private Rigidbody2D rb;
    private Animator animator;
    RaycastHit2D hit;
    int layerMask;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        layerMask = LayerMask.GetMask("Ground");
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = moveSpeed * Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(xSpeed, rb.linearVelocity.y);
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            animator.SetBool("isRun", true);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool("isRun", true);
        }
        else
        {
            animator.SetBool("isRun", false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpSpeed);
        }
        Debug.DrawRay(transform.position, Vector3.down * groundDist, Color.blue);
        hit = Physics2D.Raycast(transform.position, Vector3.down, groundDist, layerMask);
        if (hit.collider != null)
        {
            isGround = true;
            animator.SetBool("isJump", false);
        }
        else if (hit.collider == null)
        {
            isGround = false;
            animator.SetBool("isJump", true);
        }
    }
}
