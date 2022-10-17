using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{
    [SerializeField] private float X;
    [SerializeField] private float Y;
    [SerializeField] private float Z;
    [SerializeField] private GameObject thrownBall;

    public void resetPosition()
    {
        Vector3 defaultPos = new Vector3(X, Y, Z);
        thrownBall.transform.position = defaultPos;
    }
}
