using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] public float speed = 3f;

    private Rigidbody2D _rb;
    private Vector2 _moveInput;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        _moveInput = new Vector2(moveX, moveY).normalized;
    }
    
    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _moveInput * (speed * Time.fixedDeltaTime));
    }
}
