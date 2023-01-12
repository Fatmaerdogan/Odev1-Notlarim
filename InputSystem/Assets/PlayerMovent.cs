using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovent : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    Vector2 input=Vector2.zero;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        rb.AddForce(new Vector3(speed * input.x, 0, speed * input.y));
    }
    public void Moving(InputAction.CallbackContext value)
    {
            input = value.ReadValue<Vector2>();
    }
    public void Jump()
    {
        rb.AddForce(Vector3.up*100);
    }
}
