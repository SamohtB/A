using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{
    [SerializeField] private Transform transformObj;
    [SerializeField] private float speed = 10.0f;
    [SerializeField] Animator animator;
    [SerializeField] private float jumpConstant;
    private Rigidbody rigidBody;

    private void Awake()
    {
        
        rigidBody = gameObject.GetComponent<Rigidbody>();
        
        
    }

    // Start is called before the first frame update
    void Start()
    {
        transformObj = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        
        MovementManager();
    }


    void MovementManager()
    {

        transformObj.transform.Translate(Vector3.forward * speed * Time.deltaTime * Input.GetAxisRaw("Vertical"));
        transformObj.Rotate(new Vector3(0, 1.0f, 0), 200.0f * Time.deltaTime * Input.GetAxisRaw("Horizontal"));

        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Working Force");
            GetComponent<Rigidbody>().AddForce((new Vector3(0, 10.0f, 0) * Time.deltaTime * 1000.0f)
                ,ForceMode.Impulse);
        }

    }

    void handleMovement()
    {
        bool isRunning = animator.GetBool("isRunning");
        bool isWalking = animator.GetBool("isWalking");
    }


   

}
