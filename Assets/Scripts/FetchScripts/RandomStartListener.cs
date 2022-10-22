using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStartListener : MonoBehaviour
{
    [SerializeField] private Vector3 minRandomThrow;
    [SerializeField] private Vector3 maxRandomThrow;
    Parameters throwforce = new Parameters();

    private void Start()
    {
        Vector3 force = new Vector3();
        force.x = Random.Range(minRandomThrow.x, maxRandomThrow.x);
        force.y = Random.Range(minRandomThrow.y, maxRandomThrow.y);
        force.z = Random.Range(minRandomThrow.z, maxRandomThrow.z);

        throwforce.PutExtra(FetchNames.THROW_FORCE_X, force.x);
        throwforce.PutExtra(FetchNames.THROW_FORCE_Y, force.y);
        throwforce.PutExtra(FetchNames.THROW_FORCE_Z, force.z);
    }


    private void OnTriggerEnter(Collider other)
    {

        /* if player is detected, throw ball */
        if (other.name == FetchNames.PLAYER)
        { 
            EventBroadcaster.Instance.PostEvent(FetchNames.THROW_BALL, throwforce);
            this.gameObject.SetActive(false);
        }
    }

}
