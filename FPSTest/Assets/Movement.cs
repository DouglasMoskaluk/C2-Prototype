using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private CharacterController controller;
    private Rigidbody rb;
    private Camera cam;

    private float lookSenses = 0.6f;

    [SerializeField] private float speed = 7f;
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

    public bool isSlidingPressed = false;
    private float standingHeight = 2f;
    private float standingRadius = 0.5f;
    private float crouchingHeight = 0.6f;
    private float crouchingRadius = 0.3f;

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
    }

    public void OnLook(InputAction.CallbackContext ctx) => mouseInput = ctx.ReadValue<Vector2>();

    public void OnMove(InputAction.CallbackContext ctx) => moveInput = ctx.ReadValue<Vector2>();

    public void OnJump(InputAction.CallbackContext ctx) => jumpInput = ctx.ReadValueAsButton();

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
        }
        else if (ctx.canceled)//end of hold
        {
            Debug.Log("Slide cancelled");
            isSlidingPressed = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        fireCDTimer += Time.deltaTime;

        if (isSlidingPressed)//should be a ground check here but it messed with the slide, downward force should be applied in real game but i dont wanna do that here so fuck yall bing bong
        {
            controller.height = Mathf.Lerp(controller.height, crouchingHeight, Time.deltaTime * 25);
            //controller.radius = Mathf.Lerp(controller.radius, crouchingRadius, Time.deltaTime * 15);
            controller.radius = crouchingRadius;
            moveInput.y = 1;
            speed = 12f;
        }
        else
        {
            controller.height = Mathf.Lerp(controller.height, standingHeight, Time.deltaTime * 18);
            controller.radius = standingRadius;
            speed = 7;
            //controller.radius = Mathf.Lerp(controller.radius, standingRadius, Time.deltaTime * 20);
        }

        horizontalRotTrans.localEulerAngles += Vector3.up * mouseInput.x * mouseSense.x;
        verticalRotTrans.localEulerAngles += -Vector3.right * mouseInput.y * mouseSense.y;

        verticalRotTrans.localEulerAngles = ClampCameraXRot(verticalRotTrans.localEulerAngles, verticalBottomBounds, verticalTopBounds);

        verticalMotion += Vector3.down * GRAVITY * Time.deltaTime;
        if (controller.isGrounded) verticalMotion = Vector3.down;

        if (jumpInput && controller.isGrounded)
        {
            Debug.Log("jump");
            verticalMotion = Vector3.up * jumpForce;
        }

        Vector3 movement = ((horizontalRotTrans.forward * moveInput.y) + (horizontalRotTrans.right * moveInput.x)).normalized * speed;

        movement += verticalMotion;

        Debug.DrawRay(transform.position, movement, Color.red, Time.deltaTime);

        controller.Move(movement * Time.deltaTime);

        
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
}
