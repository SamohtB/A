using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class ThrowMechanic : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private Vector3 manualThrow;
    [SerializeField] private Vector3 minRandomThrow;
    [SerializeField] private Vector3 maxRandomThrow;
    private Rigidbody ballRigidbody;

    private void Awake()
    {
        EventBroadcaster.Instance.AddObserver(FetchNames.ON_GAME_START, this.throwBall);
        EventBroadcaster.Instance.AddObserver(FetchNames.ON_RANDOM_START, this.randomThrow);
        ballRigidbody = ball.GetComponent<Rigidbody>();

    }

    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = ball.GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    void Update()
    {
        EventBroadcaster.Instance.AddObserver(FetchNames.ON_GAME_START, this.throwBall);
        EventBroadcaster.Instance.AddObserver(FetchNames.ON_RANDOM_START, this.randomThrow);
        ballRigidbody = ball.GetComponent<Rigidbody>();
    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(FetchNames.ON_GAME_START);
        EventBroadcaster.Instance.RemoveObserver(FetchNames.ON_RANDOM_START);
    }

    private void throwBall()
    {
        ballRigidbody.AddForce(manualThrow, ForceMode.Force);
    }

    private void randomThrow()
    {
        Vector3 randVector = new Vector3(Random.Range(
                                            minRandomThrow.x, maxRandomThrow.x),
                                          Random.Range(
                                            minRandomThrow.y, maxRandomThrow.y),
                                          Random.Range(
                                              minRandomThrow.z, maxRandomThrow.z));
        ballRigidbody.AddForce(randVector);
    }

}
