using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    bool OnGround = false;
    private Rigidbody ballRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OnGround == true)
        {
            Debug.Log("stopping");
            ballRigidbody.velocity = Vector3.zero;
            ballRigidbody.angularVelocity = Vector3.zero;
        }

        if (gameObject.transform.position.y < -1)
        {
            gameObject.transform.position = new Vector3(0, 2f, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Floor"))
        {
            OnGround = true;
            gameObject.transform.rotation = Quaternion.identity;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Not on Ground");
        OnGround = false;
    }
}
