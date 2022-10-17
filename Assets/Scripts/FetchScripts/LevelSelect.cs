using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject dropDown;
    [SerializeField] private Sprite backyard;
    [SerializeField] private Sprite warehouse;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
}
