using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private float Speed = 10f;
    private Vector2 movementInput = Vector2.zero;
    public Rigidbody2D rb;
    private float playerInput = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        Vector2 move = new Vector2(movementInput.x, movementInput.y);
        rb.linearVelocity = move * Speed;

        //set the animations

        SwapSprite();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void SwapSprite()
    {
        //impliment the different sprites for facing left and right
    }
    
}
