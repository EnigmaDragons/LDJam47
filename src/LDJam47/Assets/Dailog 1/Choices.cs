using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEditor;
using System.Collections;

public class Choices : MonoBehaviour
{
    [Header("       Settings")]
    [Header("               Choice Opperations")]
    // will detrimin how fast your date talks.
    public string playerName;
    public string dateName;
    public float typeSpeed;
    public TextButton[] buttons;
    public Button nextChoiceButton;
    [HideInInspector] public TextMeshProUGUI dailog;

    private TextMeshProUGUI choice1;
    private Button choice1Button;

    private TextMeshProUGUI choice2;
    private Button choice2Button;

    private TextMeshProUGUI choice3;
    private Button choice3Button;

    private TextMeshProUGUI choice4;
    private Button choice4Button;

    private TextMeshProUGUI choice5;
    private Button choice5Button;
    
    public ChoiceHolder choiceHold;

    private string[] tempArray;
    private List<string> tempChoice;

    // works with button to bring you to the next dailog
    [HideInInspector] public List<int> pointerList;
    // pointer will bring you that number dialog so 3 will bring you to the third dialog option
    public int pointer = 37;

    public DailogEvents dailogE;
    //used for togglein the aviabilty of choices
    List<TextMeshProUGUI> textList;
    List<Button> buttonList;

    public List<List<string>> dateList;
    public int currentDate;
    void Start()
    {
        // points to very first conversation
        //Prep work 
        dailog = GameObject.Find("Dialog").GetComponent<TextMeshProUGUI>();

        if (buttons.Length < 5)
            Debug.Log("Need 5 buttons");

        choice1 = buttons[0].text;
        choice1Button = buttons[0].button;

        choice2 = buttons[1].text;
        choice2Button = buttons[1].button;

        choice3 = buttons[2].text;
        choice3Button = buttons[2].button;

        choice4 = buttons[3].text;
        choice4Button = buttons[3].button;

        choice5 = buttons[4].text;
        choice5Button = buttons[4].button;

        choiceHold = GameObject.Find("Choicelist").GetComponent<ChoiceHolder>();

        textList = new List<TextMeshProUGUI> { choice1, choice2, choice3, choice4, choice5 };
        buttonList = new List<Button> { choice1Button, choice2Button, choice3Button, choice4Button, choice5Button };

        dailogE = GameObject.Find("Overview").GetComponent<DailogEvents>();

        dateList = new List<List<string>> { choiceHold.dateA, choiceHold.dateB, choiceHold.dateC };
        //Begins dailog system
        GrabText();
    }

    public void NextConvo()
    {
        // Find next pointer from button daialog and will bring the player there
        Debug.Log("fired");
        if (EventSystem.current.currentSelectedGameObject != null)
        {
            if (EventSystem.current.currentSelectedGameObject.name == "nextChoice")
            {
                pointer = pointerList[0];
            }
            else
            {
                pointer = pointerList[(Int32.Parse((EventSystem.current.currentSelectedGameObject.name).Replace("Choice", "")) - 1)];
            }
        }
        //runs grabtext again to keep the game going.
        dailogE.NextEvent(pointer);
    }
    public void GrabText()
    {
        // Disables all buttons and makes them blank 
        int count = 0;
        foreach (Button item in buttonList)
        {
            textList[count].text = "";
            item.interactable = false;
            count++;
        }

        //replaces normal english commas with that
        tempArray = dateList.VerboseIndex(currentDate, nameof(dateList))[pointer - 1].Split('=');
        pointerList = new List<int>();

        // gets pointer
        int i = 1;
        while (i < tempArray.Length)
        {
            Debug.Log(tempArray[i]);
            int temp = Int32.Parse(tempArray[i].Split('#')[1]);
            pointerList.Add(temp);
            i++;
        }
        tempChoice = tempArray.ToList();
        while (tempChoice.Count <= 5)
        {
            tempChoice.Add("#");
        }
        // used for printer dailog to screen
        if (gameObject.activeInHierarchy == true)
        {
            StartCoroutine(DailogScroll());
        }
    }
    public void SetUi(List<string> displayChoices)
    {
        tempChoice = displayChoices;

        if (tempArray.Length == 2)
        {
            nextChoiceButton.interactable = true;
        }
        else
        {
            nextChoiceButton.interactable = false;
            //uses list and sets everything up so it looks nice 
            choice1.SetText(tempChoice[1].Split('#')[0].Replace("ComA", " ,"));
            choice2.SetText(tempChoice[2].Split('#')[0].Replace("ComA", " ,"));
            choice3.SetText(tempChoice[3].Split('#')[0].Replace("ComA", " ,"));
            choice4.SetText(tempChoice[4].Split('#')[0].Replace("ComA", " ,"));
            choice5.SetText(tempChoice[5].Split('#')[0].Replace("ComA", " ,"));

            // enables relavent buttons
            int i = 0;
            foreach (Button item in buttonList)
            {

                if (textList[i].text == "")
                {
                    item.interactable = false;
                }
                else
                {
                    item.interactable = true;
                }
                i++;
            }
        }
    }
    IEnumerator DailogScroll()
    {
        nextChoiceButton.interactable = false;
        // reests dialog
        dailog.text = "";
        // fancy smancy text crawl;
        foreach (char item in tempChoice[0]
            .Replace("PLAYER_NAME", playerName)
            .Replace("Player", playerName)
            .Replace("DATE", "Robin")
            .Replace("player", playerName)
            .Replace("Robbin", "Robin"))
        {
            dailog.text += item;
            yield return new WaitForSeconds(typeSpeed);
        }

        // enables and finishes up ui. 
        SetUi(tempChoice);
    }
}