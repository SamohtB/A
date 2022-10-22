using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject dropDown;
    [SerializeField] private Sprite backyard;
    [SerializeField] private Sprite warehouse;


    private void Awake()
    {
        EventBroadcaster.Instance.AddObserver(FetchNames.PLAY_PRESSED, this.OnPressPlay);
        EventBroadcaster.Instance.AddObserver(FetchNames.QUIT_PRESSED, this.OnPressQuit);
        EventBroadcaster.Instance.AddObserver(FetchNames.RETRY_PRESSED, this.OnPressRetry);
        EventBroadcaster.Instance.AddObserver(FetchNames.MAINMENU_PRESSED, this.OnPressMain);
        EventBroadcaster.Instance.AddObserver(FetchNames.LEVEL_SELECT, this.LevelSelect);
    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(FetchNames.PLAY_PRESSED);
        EventBroadcaster.Instance.RemoveObserver(FetchNames.QUIT_PRESSED);
        EventBroadcaster.Instance.RemoveObserver(FetchNames.RETRY_PRESSED);
        EventBroadcaster.Instance.RemoveObserver(FetchNames.MAINMENU_PRESSED);
        EventBroadcaster.Instance.RemoveObserver(FetchNames.LEVEL_SELECT);
    }

    private void LevelSelect()
    {
        if (dropDown.GetComponent<TMP_Dropdown>().value == 0)
        {
            canvas.GetComponent<Image>().sprite = backyard;
        }
        else if (dropDown.GetComponent<TMP_Dropdown>().value == 1)
        {
            canvas.GetComponent<Image>().sprite = warehouse;
        }

    }
    private void OnPressPlay()
    {
        switch (dropDown.GetComponent<TMP_Dropdown>().value)
        {
            case 0:
                SceneManager.LoadScene(FetchNames.BACKYARD_LEVEL);
                break;

            case 1:
                SceneManager.LoadScene(FetchNames.WAREHOUSE_LEVEL);
                break;
        }
    }
    private void OnPressQuit()
    {
        Application.Quit();
    }
    private void OnPressRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnPressMain() 
    {
        SceneManager.LoadScene(FetchNames.MAIN_MENU);
    }
}
