using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; public float moveSpeed;

    void Start() { rb.GetComponent<Rigidbody>(); }
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed,
rb.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

    }

}