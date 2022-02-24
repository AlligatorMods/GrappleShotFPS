using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSPController : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject head;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(head.transform.forward);
        }
    }
}
