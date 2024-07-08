using UnityEngine;
using UnityEngine.InputSystem;
public class MovementManager : MonoBehaviour
{
    public Rigidbody rbHead;
    public Vector3 direction;
    public InputActionReference control;
    public float force;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(control.action.activeControl);
       
    }
}
