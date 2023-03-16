using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed = 3;
    [SerializeField] private float jumpingPower = 10f;

    //public Transform ColliderTransform;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 jump = new Vector3(0, 1, 0);
            rb.AddForce(jump * jumpingPower);
        }
    }
}