using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Security.Cryptography;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject winBanner;
    [SerializeField] private GameObject text;
    

    private void OnEnable()
    {
        Debug.Log("DISPLAY");
        text.SetActive(true);
        StartCoroutine(Hide());
    }

    IEnumerator Hide()
    {
        yield return new WaitForSecondsRealtime(3.0f);
        Debug.Log("HIDE");
        text.SetActive(false);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == FetchNames.PLAYER)
        {
            //Call Event BroadCasting 
            winBanner.SetActive(true);
            EventBroadcaster.Instance.PostEvent(FetchNames.ON_DISPLAY_TIME);
        }
    }
    
}
