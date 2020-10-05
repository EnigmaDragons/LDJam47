using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailogEvents : MonoBehaviour
{
    private GameObject overview;
    private Vector2 origin;
    public int pointer;
    private Choices choice;

    // Character Animation Controllers
    CharacterAnimationController dateCharacterController = null;

    void Start()
    {
        overview = GameObject.Find("DialogueView2");
        choice = GameObject.Find("ChoiceManager").GetComponent<Choices>();
        origin = overview.transform.position;
        dateCharacterController = GameObject.FindGameObjectWithTag("DateCharacter").GetComponent<CharacterAnimationController>();
        StartCoroutine(StartGame());
    }

    // Starts the game little delay to avoid null reference exceptions. In the start method, some things may have not loaded yet
    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(0.2f);
        NextEvent(1); 
    }

    public void NextEvent(int pointer)
    {
        pointer -= 1;
        if(pointer == 0 && choice.currentDate == 0)
        {
            Debug.Log("Game started");

            // Have date walk in
            dateCharacterController.SetTrigger("sitDownTrigger");
            dateCharacterController.ChangeFacialExpression("Happy");
        }
        //End of date 
        else if (pointer == 49 && choice.currentDate == 0)
        {
            Debug.Log("Game over");
            //gameObject.SetActive(false);

            // sets current date to second date dailog
            choice.currentDate = 1;
            choice.pointer = 1;

            //testing purpose put scene end here
            overview.active = false;
            // bus-kun  put some sort of delay here
            //choice.GrabText();
        }

        //DATE B DAILOG STUFF


        //DATE C DAILOG STUFF
        else if (pointer == 42 && choice.currentDate == 2)
        {
            Debug.Log("Game over");
            //gameObject.SetActive(false);

            // sets current date to second date dailog
            choice.currentDate = 1;
            choice.pointer = 1;

            // bus-kun  put some sort of delay here
            choice.GrabText();
        }

        else
        {
            choice.GrabText();
        }
    }
}
