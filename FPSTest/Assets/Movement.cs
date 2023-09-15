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

    private Vector2 moveInput;
    private Vector2 mouseInput;
    private bool jumpInput;

    private Vector3 verticalMotion;
    public float GRAVITY;

    public float jumpForce;

    public Player1ControlsMap input;


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

    // Update is called once per frame
    void Update()
    {
        //moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        //moveInput = input.Player1Controls.Movement.ReadValue<Vector2>();
        //mouseInput = input.Player1Controls.Look.ReadValue<Vector2>();
        
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
