using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlterName : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        EventBroadcaster.Instance.AddObserver(EventNames.FetchEvents.ON_DISPLAY_TIME, this.dispalyTime);
    }
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.FetchEvents.ON_DISPLAY_TIME);
    }



    public void dispalyTime(Parameters parameters)
    {
        //Accept Input as Time
        string time = parameters.GetStringExtra(EventNames.FetchEvents.ON_DISPLAY_TIME, "time");

        Debug.Log($"Time: {time}");

        TextMeshProUGUI text = this.GetComponent<TextMeshProUGUI>();

        text.SetText("Time: " + time);
        

    }
}
