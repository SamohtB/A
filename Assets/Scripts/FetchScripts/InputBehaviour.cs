using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputBehaviour : MonoBehaviour
{
     
    [SerializeField] private float speed = 10.0f;
    [SerializeField] Animator animator;

    [SerializeField] private Vector3 appliedForce = new Vector3(0, 50.0f, 0);

    const float BUFFER = 0.5f;

    private float currTime;
    private Transform transformObj;
    private Rigidbody rigidbody;



    private bool isOnGround = true;

    //Animator Definition
    bool isMoving;
    bool isJumping;

    private void Awake()
    {
        
       
        HandleMovement();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        transformObj = GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        MovementManager();
    }



    void MovementManager()
    {

        float forwardMovement = Input.GetAxisRaw("Vertical");
        if (!Input.GetKey(KeyCode.W) &&  !Input.GetKey(KeyCode.S))
        {
            //DeadZone
            Debug.Log("Dead");
            animator.SetBool("isMoving", false);
        }
        else
        {
            transformObj.transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardMovement);
            animator.SetBool("isMoving", true);
            
        }
        //Debug.Log($"Speed: {forwardMovement}");
        transformObj.Rotate(new Vector3(0, 1.0f, 0), 200.0f * Time.deltaTime * Input.GetAxisRaw("Horizontal"));

        if (Input.GetKeyDown("space") && isOnGround == true && BUFFER < currTime)
        {
            Debug.Log("Working Force");
            rigidbody.AddForce((appliedForce * Time.deltaTime * 200.0f), ForceMode.Impulse);
            isOnGround = false;

            //Handling Animation
            animator.SetBool("isJumping", true);
            isJumping = true;
            currTime = 0;
        }

    }

    void HandleMovement()
    {
        bool isMoving = animator.GetBool("isMoving");
        bool isJumping = animator.GetBool("isJumping");

        //animator.GetBool("");
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
        animator.SetBool("isJumping", false);
        isJumping = false;
    }
}




