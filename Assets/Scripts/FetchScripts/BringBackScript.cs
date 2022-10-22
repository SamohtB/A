using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringBackScript : MonoBehaviour
{
    [SerializeField] private GameObject targetContainer;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == FetchNames.PLAYER)
        {
            int spawnOwner = Random.Range(0,4);
            //Set active random child
            targetContainer.gameObject.transform.GetChild(spawnOwner).gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
