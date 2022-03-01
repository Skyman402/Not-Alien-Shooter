using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody movement;

    private void Start()
    {
        movement = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        MovementLogic();
    }
    
    private void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveHorizontal, 0.0f, moveVertical);
        movement.AddForce(move);
    }
}
