using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private const float mouseSensitvity = 1000.0f;
    [SerializeField] Transform playerBody;
    //Camera Reference
    private float xRotation = 30;
    private float yRotation = 30;

    

    // Start is called before the first frame update
    void Start()
    {

        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
        //increment += Time.deltaTime;
        camRotate();
    }

    private void camRotate()
    {


        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitvity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitvity * Time.deltaTime;

            xRotation += mouseX;
            yRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -30.0f, 30.0f);
            yRotation = Mathf.Clamp(yRotation, 0.0f, 45.0f);


            this.transform.localRotation = Quaternion.Euler(yRotation, xRotation, 0);
        }
    }


}