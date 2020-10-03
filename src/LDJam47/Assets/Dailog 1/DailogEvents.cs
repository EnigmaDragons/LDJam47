using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailogEvents : MonoBehaviour
{
    private GameObject overview;
    private Vector2 origin;
    public int pointer;


    void Start()
    {
        overview = GameObject.Find("Overview");
        origin = overview.transform.position;
        NextEvent(1);
    }

    public void NextEvent(int pointer)
    {
        pointer -= 1;
        if(pointer == 0)
        {
            Debug.Log("Game started");
            // Have date walk in
        }
        if(pointer == 2)
        {
            Debug.Log("Game over");
            overview.transform.position = new Vector2(100, 100);

            // bus-kun 
        }
    }
}
