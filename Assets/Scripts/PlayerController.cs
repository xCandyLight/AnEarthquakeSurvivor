using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private KeyCode _interactableKey = KeyCode.E;
    [SerializeField] private float _interactableDistance = 0.00f;
    [SerializeField] private LayerMask _interactableLayermask = 0;

    public float speed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    private Animator _animator = null;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");

        movement = new Vector2(horizontalMovement, verticalMovement).normalized;

        SetAnimatorValue("Horizontal", Input.GetAxisRaw("Horizontal"));
        SetAnimatorValue("Vertical", Input.GetAxisRaw("Vertical"));


        if (Input.GetKeyDown(_interactableKey)) Interact();

        Vector3 _direction = Input.GetAxisRaw("Horizontal") > 0 ? transform.right : -transform.right;
        Debug.DrawRay(transform.position, _direction * _interactableDistance, Color.red);
    }

    private void SetAnimatorValue(string _variableName, float _value) => _animator.SetFloat(_variableName, _value);

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void Interact()
    {
        Vector3 _direction = Input.GetAxisRaw("Horizontal") > 0 ? transform.right : -transform.right;

        RaycastHit2D _hit = Physics2D.Raycast(transform.position, _direction, _interactableDistance, _interactableLayermask);

        if (!_hit.collider) return;

        if (!_hit.collider.TryGetComponent(out IInteractable interactable)) return;
        interactable.Interact();
    }
}