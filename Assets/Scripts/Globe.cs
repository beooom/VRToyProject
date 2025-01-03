using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globe : MonoBehaviour
{
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    public void OnGrab()
    {
        rb.isKinematic = false;
    }

    public void OnRelease()
    {
        rb.isKinematic = false;
        rb.useGravity = true;
    }
}
