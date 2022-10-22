using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonListeners : MonoBehaviour
{
    public void PlayPressed()
    {
        EventBroadcaster.Instance.PostEvent(FetchNames.PLAY_PRESSED);
    }
    public void QuitPressed()
    {
        EventBroadcaster.Instance.PostEvent(FetchNames.QUIT_PRESSED);
    }
    public void MainMenuPressed()
    {
        EventBroadcaster.Instance.PostEvent(FetchNames.MAINMENU_PRESSED);
    }
    public void RetryPressed()
    {
        EventBroadcaster.Instance.PostEvent(FetchNames.RETRY_PRESSED);
    }
    public void LevelSelectPressed()
    {
        EventBroadcaster.Instance.PostEvent(FetchNames.LEVEL_SELECT);
    }
}
