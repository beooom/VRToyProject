using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // ó������ ������ ����
    }

    public void OnGrab()
    {
        rb.isKinematic = false; // ������ ���� ����
    }

    public void OnRelease()
    {
        rb.isKinematic = false;
        rb.useGravity = true;
    }
}
