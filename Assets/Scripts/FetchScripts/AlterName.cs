using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlterName : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        EventBroadcaster.Instance.AddObserver(FetchNames.ON_DISPLAY_TIME, this.dispalyTime);
    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(FetchNames.ON_DISPLAY_TIME);
    }

    public void dispalyTime(Parameters parameters)
    {
        //Accept Input as Time
        string time = parameters.GetStringExtra(FetchNames.ON_DISPLAY_TIME, "time");

        Debug.Log($"Time: {time}");

        TextMeshProUGUI text = this.GetComponent<TextMeshProUGUI>();

        text.SetText("Time: " + time);
        

    }
}
