using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowListener : MonoBehaviour
{
    private void Start()
    {
        randomStart(); // random throw ball
    }

    public void gameStart()
    {
        EventBroadcaster.Instance.PostEvent(EventNames.FetchEvents.ON_GAME_START);
    }

    public void randomStart()
    {
        EventBroadcaster.Instance.PostEvent(EventNames.FetchEvents.ON_RANDOM_START);
    }
}
