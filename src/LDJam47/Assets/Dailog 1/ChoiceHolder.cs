using System.Collections.Generic;
using UnityEngine;

public class ChoiceHolder : MonoBehaviour
{
    public List<string> choiceSets;


    public void Start()
    {
        choiceSets = new List<string> 
        {
            "Player: I've never been the type of person to get dates at the drop of a hat. But when I found out Sam and Blake were getting married I knew I couldn’t show my face without a plus one. But knowing me I knew the only chance I had was getting someone to set me up on a blind date. Luckily my friend Dr. Busman has set me up with a date today. Now my only challenge is to get them to be my plus one to Sam and Blake's wedding.,next #2,next #3",
            "Robbin: I’ve been waiting for 25 minutes. But Dr. Busman has never let me down so I’ll give you another shot.,Player: Well this place is impossible to find. There is virtually no parking. I’m PLAYER_NAME by the way. #3, Player: Well the weather has been terrible. What was I supposed to do? #3, Player: Well you see my watch broke last week and I ordered a new one online but when it came it was set an hour behind. #3",
            "afdsasfd: I’ve been asdfsafd for 25 minutes. But Dr. Busman has never let me down so I’ll give you another shot.,Player: Well this place is sfadsdfa to find. There is virtually no asffsad. I’m fasd by the way. #1, Player: Well the weather has been terrible. What was I supposed to do? #1, Player: Well you see my watch broke last week and I ordered a new one online but when it came it was set an hour behind. #1",
        };
    }
}


