using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class ThrowMechanic : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    private Rigidbody ballRigidbody;

    private void Awake()
    {
        ballRigidbody = ball.GetComponent<Rigidbody>();
    }

    private void Start()
    {
        EventBroadcaster.Instance.AddObserver(FetchNames.THROW_BALL, this.ThrowBall);
    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(FetchNames.THROW_BALL);
    }

    private void ThrowBall(Parameters param)
    {
        
        Vector3 force = new Vector3(param.GetFloatExtra(FetchNames.THROW_FORCE_X, 10),
                                    param.GetFloatExtra(FetchNames.THROW_FORCE_Y, 10),
                                    param.GetFloatExtra(FetchNames.THROW_FORCE_Z, 10));

        ballRigidbody.AddForce(force, ForceMode.Force);
        Debug.Log("Ball Thrown! Force = (" + force.x + ", " +
                force.y + ", " + force.z + ")");
    }

}
