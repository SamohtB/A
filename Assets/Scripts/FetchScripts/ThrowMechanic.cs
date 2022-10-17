using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class ThrowMechanic : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private float groundLevel;
    [SerializeField] private float throwX;
    [SerializeField] private float throwY;
    [SerializeField] private float throwZ;
    private Rigidbody ballRigidbody;

    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    [SerializeField] private float minZ;
    [SerializeField] private float maxZ;

    private void Awake()
    {
        EventBroadcaster.Instance.AddObserver(EventNames.FetchEvents.ON_GAME_START, this.throwBall);
        EventBroadcaster.Instance.AddObserver(EventNames.FetchEvents.ON_RANDOM_START, this.randomThrow);
    }

    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = ball.GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.FetchEvents.ON_GAME_START);
    }

    private void throwBall()
    {
        ballRigidbody.AddForce(new Vector3(throwX, throwY, throwZ), ForceMode.Force);
    }

    private void randomThrow()
    {
        Vector3 randVector = new Vector3(Random.Range(minX, maxX), maxY, Random.Range(minZ, maxZ));
        ballRigidbody.AddForce(randVector);
    }
    
}
