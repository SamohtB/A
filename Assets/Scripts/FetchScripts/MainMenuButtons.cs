using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject dropDown;

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
