using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    [SerializeField] private Vector3 force;

    private void OnTriggerEnter(Collider other)
    {
        
        /* if player is detected, throw ball */
        if (other.name == FetchNames.PLAYER)
        {
            Debug.Log("Player Entered!");
            Parameters throwforce = new Parameters();
            throwforce.PutExtra(FetchNames.THROW_FORCE_X, force.x);
            throwforce.PutExtra(FetchNames.THROW_FORCE_Y, force.y);
            throwforce.PutExtra(FetchNames.THROW_FORCE_Z, force.z);

            EventBroadcaster.Instance.PostEvent(FetchNames.THROW_BALL, throwforce);
            this.gameObject.SetActive(false);
        }     
    }
}
