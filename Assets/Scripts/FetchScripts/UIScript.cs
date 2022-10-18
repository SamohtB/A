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

    public void levelSelect()
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

    public void OnPressPlay()
    {
        switch (dropDown.GetComponent<TMP_Dropdown>().value)
        {
            case 0:
                SceneManager.LoadScene("BackyardScene");
                break;

            case 1:
                SceneManager.LoadScene("WarehouseScene");
                break;
        }
    }

    public void OnPressQuit()
    {
        Application.Quit();
    }
}
