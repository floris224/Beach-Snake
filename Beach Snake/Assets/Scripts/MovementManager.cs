using UnityEngine;
using UnityEngine.InputSystem;
public class MovementManager : MonoBehaviour
{
    private PlayerControls playerControls;
    public Rigidbody rbHead;
    public float rotationSpeed;
  
    public float force;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        playerControls = new PlayerControls();
    }
    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void OnDisable()
    {
        playerControls.Disable();
    }
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = playerControls.Player.Move.ReadValue<Vector2>();
        if (move.x < 0)
        {
            transform.Rotate(Vector3.up,-rotationSpeed * Time.deltaTime);
        }
        else if(move.x > 0)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        rbHead.AddForce(transform.forward * force * Time.deltaTime);
        
        
    }
}
