using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailogEvents : MonoBehaviour
{
    private GameObject overview;
    private Vector2 origin;
    public int pointer;
    private Choices choice;

    void Start()
    {
        overview = GameObject.Find("Overview");
        choice = GameObject.Find("ChoiceManager").GetComponent<Choices>();
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
        else if(pointer == 38)
        {
            Debug.Log("Game over");
            gameObject.SetActive(false);

            // bus-kun 
        }
        else
        {
            choice.GrabText();
        }
    }
}
