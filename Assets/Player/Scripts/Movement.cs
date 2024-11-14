using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{
    [SerializeField] private float Speed = 10f;
    private Vector2 movementInput = Vector2.zero;
    public Rigidbody2D rb;
    private float playerInput = 0;
    [SerializeField] Animator animator;
    Transform trans;
    bool shouldFlip;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        trans = GetComponent<Transform>();
    }

   
    void Update()
    {
        Vector2 move = new Vector2(movementInput.x, movementInput.y);
        rb.linearVelocity = move * Speed;

        //set the animations
        animator.SetBool("Walking", move.magnitude != 0);


        SwapSprite(move);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
        if (context.performed)
        {
            shouldFlip = movementInput.x < 0;
        }
    }

    public void SwapSprite(Vector2 Move)
    {
        //impliment the different sprites for facing left and right
        trans.GetComponent<SpriteRenderer>().flipX = shouldFlip;

    }
    
}
