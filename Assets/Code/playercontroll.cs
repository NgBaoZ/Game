
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody2D))]

[ExecuteInEditMode]
public class playercontroll : MonoBehaviour
{
    public float walkSpeed = 5f;
    Vector2 moveInput;
[SerializeField]
    private bool _isRunning = false;
    public bool isRunning 
{   get 
    {
        return _isRunning; 
    } private set  {
        _isRunning = value; 
        animator.SetBool("isRunning", value);
    } 
}
   
    Rigidbody2D rb;

    Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rb.linearVelocity= new Vector2(moveInput.x * walkSpeed * Time.fixedDeltaTime, rb.linearVelocity.y);
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        isRunning  = moveInput != Vector2.zero;
    }
}
