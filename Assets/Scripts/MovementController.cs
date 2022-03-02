using UnityEngine;

public class MovementController : MonoBehaviour
{
    private CharacterController _characterController;
    [SerializeField] private float _speed;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        _characterController.Move(move * Time.deltaTime * _speed);
    }
}
