using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugScript : MonoBehaviour
{
    [SerializeField] private Vector3 throwForce;
    [SerializeField] private Vector3 defaultPosition;
    [SerializeField] private GameObject thrownBall;
    Rigidbody body;

    private void Start()
    {
        body = thrownBall.GetComponent<Rigidbody>();
    }

    public void ResetPosition()
    {
        
        body.velocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
        thrownBall.transform.position = defaultPosition;
    }

    public void DebugThrow()
    {
        body.AddForce(throwForce);
    }
}
