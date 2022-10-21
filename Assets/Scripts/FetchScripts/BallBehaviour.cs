using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] GameObject winBanner;
    private bool Found = false;
    float currTime = 0; 

    // Update is called once per frame
    void Update()
    {
        TimeUpdate();
    }

    void TimeUpdate()
    {
        if (!Found)
        {
            currTime += Time.deltaTime;
            //Debug.Log($"Time: {currTime.ToString()  }");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == FetchNames.PLAYER  && !Found)
        {
            //Call Event BroadCasting 
            Debug.Log("You hit it");
            winBanner.SetActive(true);
            Found = true;

            Parameters parameters = new Parameters();
            parameters.PutExtra(EventNames.FetchEvents.ON_DISPLAY_TIME, currTime.ToString());
          
            EventBroadcaster.Instance.PostEvent(EventNames.FetchEvents.ON_DISPLAY_TIME, parameters);
            
        }
    }
}
