using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlterName : MonoBehaviour
{
    [SerializeField] private GameObject timer;
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
    private void Awake()
    {
        EventBroadcaster.Instance.AddObserver(FetchNames.ON_DISPLAY_TIME, this.dispalyTime);
    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(FetchNames.ON_DISPLAY_TIME);
    }

    public void dispalyTime()
    {
        Found = true;
        //Accept Input as Time

        Debug.Log($"Time: {currTime}");

        TextMeshProUGUI text = timer.GetComponent<TextMeshProUGUI>();

        text.SetText("Time: " + currTime);
        

    }
}
