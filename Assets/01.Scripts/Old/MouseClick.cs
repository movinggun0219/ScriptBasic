using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseDown()
    {
        Debug.Log("Click mouse!");
        rb.AddForce(transform.up * 500f);
        rb.useGravity = true;
    }

    void OnMouseEnter()
    {
        Debug.Log("Enter mouse!");
    }
}
