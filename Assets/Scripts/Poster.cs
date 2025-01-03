using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // 처음에는 고정된 상태
    }

    public void OnGrab()
    {
        rb.isKinematic = false; // 잡히면 고정 해제
    }

    public void OnRelease()
    {
        rb.isKinematic = false;
        rb.useGravity = true;
    }
}
