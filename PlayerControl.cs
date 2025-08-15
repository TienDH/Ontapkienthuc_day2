using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControl : MonoBehaviour
{
    [Header("Move")]
    [SerializeField] private float moveSpeed = 5f;         // tốc độ tiến/lùi
    [SerializeField] private float inputDeadzone = 0.05f;  // ngưỡng bỏ rung input (0–1)

    [Header("Turn")]
    [SerializeField] private float turnSpeed = 1f;       // độ/giây (xoay trái/phải)

    [Header("Forward Axis")]
    [Tooltip("Sprite mặc định nhìn LÊN dùng Up. Nếu mặc định nhìn SANG PHẢI thì chọn Right.")]
    [SerializeField] private bool spriteFacesUp = true;    // true: dùng transform.up làm hướng tiến; false: transform.right

    private Rigidbody2D rb;
    private float vInput; // lên/xuống
    private float hInput; // trái/phải

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.interpolation = RigidbodyInterpolation2D.Interpolate;
        // Khuyến nghị: Rigidbody2D (Dynamic), Gravity Scale = 0
    }

    private void Update()
    {
        // Lấy input (raw cho phản hồi nhanh)
        hInput = Input.GetAxisRaw("Horizontal"); // trái/phải -> XOAY
        vInput = Input.GetAxisRaw("Vertical");   // lên/xuống -> TIẾN/LÙI
    }

    private void FixedUpdate()
    {

        float deltaAngle = -hInput * turnSpeed * Time.fixedDeltaTime;
        float newRot = rb.rotation + deltaAngle;
        rb.MoveRotation(newRot);

        // 2) Tiến/lùi theo hướng đang nhìn
        Vector2 forward = spriteFacesUp ? (Vector2)transform.up : (Vector2)transform.right;
        Vector2 deltaPos = forward * (vInput * moveSpeed * Time.fixedDeltaTime);
        rb.MovePosition(rb.position + deltaPos);
    }
}
