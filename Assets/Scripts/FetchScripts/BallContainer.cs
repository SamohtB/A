using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallContainer : MonoBehaviour
{
    [SerializeField] private List<GameObject> ballList;
    private int currIndexActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        ballList[currIndexActive].SetActive(true);
        
        //Add Observer
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Call coming from the Event BroadCasting
    public void changeGoalBall(int count)
    {
        if (count > ballList.Count - 1 && count == currIndexActive)
        {
            Debug.Log("Size too big");
        }

        else
        {
            //Swtiching Active Ball
            ballList[currIndexActive].SetActive(false);
            ballList[count].SetActive(true);
            
        }
    }
}
