using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem; 

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private float moveX, moveY;

    public float speed = 0.0f; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 move = new Vector3(moveX, 0, moveY).normalized;
        rb.AddForce(move * speed); 
    }

    void OnMove(InputValue val)
    {
        Vector2 direction = val.Get<Vector2>();
        moveX = direction.x;
        moveY = direction.y; 
    }
}
