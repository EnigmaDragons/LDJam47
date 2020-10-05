using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailogEvents : MonoBehaviour
{
    private GameObject overview;
    private Vector2 origin;
    public int pointer;
    private Choices choice;
    private int currentBad;
    public int maxBad = 5;

    // Character Animation Controller
    CharacterAnimationController dateCharacterController = null;
    SceneLoader sceneLoader = null;

    void Start()
    {
        overview = GameObject.Find("DialogueView2");
        choice = GameObject.Find("ChoiceManager").GetComponent<Choices>();
        origin = overview.transform.position;
        dateCharacterController = GameObject.FindGameObjectWithTag("DateCharacter").GetComponent<CharacterAnimationController>();
        sceneLoader = SceneLoader.SceneLoaderInstance;
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
        if (pointer == 0 && choice.currentDate == 0)
        {
            Debug.Log("Game started");
            // Text fades in here

            // Have date start already sitting down
            dateCharacterController.SetTrigger("sitDownTrigger");
            dateCharacterController.ChangeFacialExpression("Happy");
        }
        else if (pointer == 4 && choice.currentDate == 0)
        {
            sceneLoader.FadeFromBlack();
            choice.GrabText();
        }
        else if (pointer == 45 && choice.currentDate == 0)
        {
            sceneLoader.FadeFromBlack();
            choice.GrabText();
        }
        else if ((pointer == 46 || pointer == 47 || pointer == 48) && choice.currentDate == 0)
        {
            Debug.Log("Game over");
            //gameObject.SetActive(false);

            // Deactivate text progression
            // Play bus crash sound (a few seconds after?)
            // Activate text progression after sound finishes playing

            //testing purpose put scene end here
            //overview.active = false;
            // bus-kun  put some sort of delay here
            //choice.GrabText();

            // Have date get angry and walk out
            dateCharacterController.ChangeFacialExpression("Angry");
            dateCharacterController.SetTrigger("walkTrigger");
            dateCharacterController.MoveCharacter(
                dateCharacterController.startingPos,
                dateCharacterController.walkOutPos,
                1f
            );
            choice.GrabText();
        }
        else if (pointer == 50 && choice.currentDate == 0)
        {
            // Fade To Black or Bus Crash Here
            sceneLoader.FadeToBlack();
            choice.GrabText();
        }
        // End of date 1
        else if (pointer == 56 && choice.currentDate == 0)
        {
            // Switch Dates Here
            StartCoroutine(GoToDate(1));
        }

        //DATE B DAILOG STUFF
        else if ((pointer == 0) && choice.currentDate == 1)
        {
            //sceneLoader.FadeFromBlack();
            //choice.GrabText();
        }
        else if ((pointer == 43) && choice.currentDate == 1)
        {
            // Have date get angry and walk out
            dateCharacterController.ChangeFacialExpression("Angry");
            dateCharacterController.SetTrigger("walkTrigger");
            dateCharacterController.MoveCharacter(
                dateCharacterController.startingPos,
                dateCharacterController.walkOutPos,
                1f
            );

            StartCoroutine(GoToBusScene());

            //choice.GrabText();
        }
        // End of date 2
        else if ((pointer == 48) && choice.currentDate == 1)
        {
            StartCoroutine(GoToDate(2));
            choice.GrabText();
        }

        //DATE C DAILOG STUFF
        else if ((pointer == 1) && choice.currentDate == 2)
        {
            sceneLoader.FadeFromBlack();
        }
        else if ((pointer == 1 || pointer == 2 || pointer == 3) && choice.currentDate == 2)
        {
            maxBad += 1;

            if (currentBad >= maxBad)
            {
                //Jumps to bad ending
                choice.pointer = 50;

                choice.GrabText();
            }
            else
            {
                // not enough bad keep playing game
                choice.GrabText();
            }
        }

        else
        {
            choice.GrabText();
        }
    }

    private IEnumerator GoToDate(int dateNumber)
    {
        // Reset Pointer and Move to Next Date
        choice.pointer = 1;
        choice.currentDate = dateNumber;

        // Deactivate text progression
        //choice.enabled = false;

        // Fade To Black
        yield return new WaitForSeconds(2f); // duration of the fade

        // Fade To Black
        sceneLoader.FadeFromBlack();
        yield return new WaitForSeconds(1f); // duration of the fade

        // Reactivate text progression
        //choice.enabled = true;
        choice.GrabText();
    }

    private IEnumerator GoToBusScene()
    {
        // Deactivate text progression
        choice.enabled = false;

        // Fade To Black
        sceneLoader.FadeToBlack();
        yield return new WaitForSeconds(1f); // duration of the fade

        // Bus Stuff here
        // TODO: Play bus crash sound
        yield return new WaitForSeconds(3f);

        // Activate text progression after sound finishes playing
        choice.enabled = true;
        choice.GrabText();
    }
}
