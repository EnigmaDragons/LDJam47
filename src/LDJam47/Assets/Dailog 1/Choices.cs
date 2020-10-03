using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Choices : MonoBehaviour
{
    [Header("       Settings")]
    [Header("               Choice Opperations")]
    private TextMeshProUGUI dailog;

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

    //Used for setting up things
    private string[] tempArray;
    private List<string> tempChoice;

    [HideInInspector]public List<int> pointerList;
    public int pointer = 1;

    void Start()
    {
        pointer = 1;
        // 1 to 5 options
        dailog = GameObject.Find("Dialog").GetComponent<TextMeshProUGUI>();

        choice1 = GameObject.Find("Choice1").transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        choice1Button = GameObject.Find("Choice1").GetComponent<Button>();

        choice2 = GameObject.Find("Choice2").transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        choice2Button = GameObject.Find("Choice2").GetComponent<Button>();

        choice3 = GameObject.Find("Choice3").transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        choice3Button = GameObject.Find("Choice3").GetComponent<Button>();

        choice4 = GameObject.Find("Choice4").transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        choice4Button = GameObject.Find("Choice4").GetComponent<Button>();

        choice5 = GameObject.Find("Choice5").transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        choice5Button = GameObject.Find("Choice5").GetComponent<Button>();

        choiceHold = GameObject.Find("Choicelist").GetComponent<ChoiceHolder>();

        GrabText();
    }

    public void NextConvo()
    {
        pointer = pointerList[(Int32.Parse((EventSystem.current.currentSelectedGameObject.name).Replace("Choice", ""))-1)];
        GrabText();
    }
    public void GrabText()
    {
        //choiceHold.choiceSets[pointer-1].Replace(" ,", "ComA");
        tempArray = choiceHold.choiceSets[pointer-1].Split(',');
        pointerList = new List<int>();

        // gets next link in convo chain
        // start at one to avoid dailog
        int i = 1;
        while (i < tempArray.Length)
        {
            int temp = Int32.Parse(tempArray[i].Split('#')[1]);
            pointerList.Add(temp);
            i++;
        }
        tempChoice = tempArray.ToList();
        while (tempChoice.Count <= 5)
        {
            tempChoice.Add("...#");
        }
        SetUi(tempChoice);
    }
    public void SetUi(List<string> displayChoices)
    {
        tempChoice = displayChoices;
        dailog.text = tempChoice[0].Replace("ComA", " ,");
        choice1.SetText(tempChoice[1].Split('#')[0].Replace("ComA", " ,"));
        choice2.SetText(tempChoice[2].Split('#')[0].Replace("ComA", " ,"));
        choice3.SetText(tempChoice[3].Split('#')[0].Replace("ComA", " ,"));
        choice4.SetText(tempChoice[4].Split('#')[0].Replace("ComA", " ,"));
        choice5.SetText(tempChoice[5].Split('#')[0].Replace("ComA", " ,"));


        // DISABLES CERTIAN BUTTONS
        List<TextMeshProUGUI> textList = new List<TextMeshProUGUI> { choice1, choice2, choice3, choice4, choice5 };
        List<Button> buttonList = new List<Button> { choice1Button, choice2Button, choice3Button, choice4Button, choice5Button };

        int i = 0;
        foreach (Button item in buttonList)
        {

            if (textList[i].text == "...")
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