using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{

    //public float beeStartingSpeed = 100;

    private void OnMouseUpAsButton()
    {
        GameObject.FindGameObjectWithTag("Bee").GetComponent<BeeController>().StartBee();
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
