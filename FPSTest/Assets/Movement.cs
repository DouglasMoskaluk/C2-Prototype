using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public int playerHealth = 10;

    private CharacterController controller;
    private Rigidbody rb;
    private Camera cam;

    private float lookSenses = 0.6f;

    public float speed;
    [SerializeField] private float walkSpeed = 7f;
    [SerializeField] private float runSpeed = 12f;
    [SerializeField] private float crouchSpeed = 4f;

    [SerializeField] private Transform horizontalRotTrans;
    [SerializeField] private Transform verticalRotTrans;
    [SerializeField] private Vector2 mouseSense;
    [SerializeField] private float verticalTopBounds;
    [SerializeField] private float verticalBottomBounds;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawn;
    private float fireCDTimer = 0f;

    private Vector2 moveInput;
    private Vector2 mouseInput;
    private bool jumpInput;

    private Vector3 verticalMotion;
    public float GRAVITY;

    public float jumpForce;

    public Player1ControlsMap input;

    public bool isRunningToggled = false;

    public bool isSlidingPressed = false;
    private float standingHeight = 2f;
    private float standingRadius = 0.5f;
    private float crouchingHeight = 0.6f;
    private float crouchingRadius = 0.3f;

    public playerState currentState = playerState.stand;


    private void Awake()
    {
        input = new Player1ControlsMap();
    }
    // Start is called before the first frame update
    public void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;

        Cursor.lockState = CursorLockMode.Locked;
        speed = walkSpeed;
    }

    public void OnLook(InputAction.CallbackContext ctx) => mouseInput = ctx.ReadValue<Vector2>();

    public void OnMove(InputAction.CallbackContext ctx) => moveInput = ctx.ReadValue<Vector2>();

    public void OnJump(InputAction.CallbackContext ctx) => jumpInput = ctx.ReadValueAsButton();

    public void OnRunToggle(InputAction.CallbackContext ctx)
    {
        if (ctx.performed) {
            Debug.Log("toggle run");
            isRunningToggled = !isRunningToggled;
            currentState = playerState.stand;
        }
    }

    public void OnFire(InputAction.CallbackContext ctx)
    {
        if (fireCDTimer >= 0.25f && ctx.performed)
        {
            Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            fireCDTimer = 0;
        }

    }

    public void OnSlideToggle(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)//start of hold
        {
            Debug.Log("Slide performed");
            isSlidingPressed = true;
            currentState = playerState.crouch;
        }
        else if (ctx.canceled)//end of hold
        {
            Debug.Log("Slide cancelled");
            isSlidingPressed = false;
            currentState = playerState.stand;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (moveInput.magnitude <= 0.3f && isRunningToggled) { isRunningToggled = false; }

        fireCDTimer += Time.deltaTime;

        if (currentState == playerState.stand)
        {
            controller.height = Mathf.Lerp(controller.height, standingHeight, Time.deltaTime * 18);
            controller.radius = standingRadius;

            if (isRunningToggled)
            {
                speed = runSpeed;
            }
            else
            {
                speed = walkSpeed;
            }
        }
        else if (currentState == playerState.crouch)
        {
            controller.height = Mathf.Lerp(controller.height, crouchingHeight, Time.deltaTime * 25);
            controller.radius = crouchingRadius;

            if (isSlidingPressed)
            {
                moveInput.y = 1;
                speed = runSpeed;
            }
            else
            {
                speed = crouchSpeed;
            }
        }

        if (jumpInput && controller.isGrounded)
        {
            Debug.Log("jump");
            verticalMotion = Vector3.up * jumpForce;
            currentState = playerState.stand;
        }

        MoveCharcter();

        
    }

    private void MoveCharcter()
    {
        horizontalRotTrans.localEulerAngles += Vector3.up * mouseInput.x * mouseSense.x;
        verticalRotTrans.localEulerAngles += -Vector3.right * mouseInput.y * mouseSense.y;

        verticalRotTrans.localEulerAngles = ClampCameraXRot(verticalRotTrans.localEulerAngles, verticalBottomBounds, verticalTopBounds);

        verticalMotion += Vector3.down * GRAVITY * Time.deltaTime;
        
        Vector3 movement = ((horizontalRotTrans.forward * moveInput.y) + (horizontalRotTrans.right * moveInput.x)).normalized * speed;

        movement += verticalMotion;

        Debug.DrawRay(transform.position, movement, Color.red, Time.deltaTime);

        controller.Move(movement * Time.deltaTime);

        if (controller.isGrounded) verticalMotion = Vector3.down;
    }

    private Vector3 ClampCameraXRot(Vector3 vec, float upperBounds, float lowerBounds)
    {
        if (vec.x > upperBounds && vec.x < 180)
        {
            vec.x = upperBounds;
        }
        else if (vec.x < 360 - lowerBounds && vec.x > 181)
        {
            vec.x = 360 - lowerBounds;
        }

        return vec;
    }

    private void OnEnable()
    {
        input.Player1Controls.Enable();
    }

    private void OnDisable()
    {
        input.Player1Controls.Disable();
    }

    public void TakeDamage()
    {
        playerHealth = Mathf.Max(--playerHealth, 0);
        if (playerHealth <= 0)
        {
            Debug.Log("Player is dead");
        }
    }
}

public enum playerState
{
   stand,
   crouch
}