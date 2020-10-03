using System.Collections.Generic;
using UnityEngine;

public class ChoiceHolder : MonoBehaviour
{
    public List<string> choiceSets;


    public void Start()
    {
        choiceSets = new List<string> 
        {
            "Player: I've never been the type of person to get dates at the drop of a hat. But when I found out Sam and Blake were getting married I knew I couldn’t show my face without a plus one. But knowing me I knew the only chance I had was getting someone to set me up on a blind date. Luckily my friend Dr. Busman has set me up with a date today. Now my only challenge is to get them to be my plus one to Sam and Blake's wedding.=next #2",
            "Robbin: I’ve been waiting for 25 minutes. But Dr. Busman has never let me down so I’ll give you another shot.= Player: Well this place is impossible to find. There is virtually no parking. I’m PLAYER_NAME by the way. #3= Player: Well the weather has been terrible. What was I supposed to do? #3= Player: Well you see my watch broke last week and I ordered a new one online but when it came it was set an hour behind. #3",
            "Robbin: Well PLAYER_NAME you should probably plan ahead better next time. OhComA and you can call me DATE.= Well have you ordered yet? #4= Have you eaten yet #4= This place is kind of whack Do you wanna just get out of here? #4",
            "No. I waited for you. But I can call the waiter over.= Next #5",
            "Waiter: Good evening. I will be your waiter this evening. May I start you two off with something to drink.= I'll have a Pepper Margarita served in a Red Pepper #6= I'll have a Cherry Lane #6= I'll have the Red Beards Rum Barrel #6",
            "Waiter and for you= next #7",
            "Robbin: Just water is fine.= Come on Robbin it's the weekend order whatever you want. My treat. #8= Just water? Are you one of those “hydrate or die-drate” people? Get something else, my treat. #8= Water is so last year! Have something exciting. My treat #8",
            "Robbin: Water is fine. [Looks at PLAYER_NAME. Looks at waiter on “fine”= next #9",
            "Waiter: and do you need more time to decide what to order?= next #10",
            "Robbin: I know what I want but I think PLAYER_NAME needs more time to decide.= Yeah just give me a few minutes to look over the menu. #11= Hmmm, this is more difficult than the Cheesecake Facility! #11= Should I have the chicken or the soup? #11",
            "The waiter leaves and the player looks over the menu for a few minutes in silence. = next #12",
            "Player: [Thinks’] “Man when is that waiter coming back. I’ve known I wanted the soup of the day for the last five minutes and now I can’t think of anything to say.” = next #13",
            "Robbin: Uhmmm… hello? = Oh hi sorry still deciding.  # 14 = Oh, didn’t see ya there! Haha # 14 = Ummmm… hello to you! # 14",
            "The waiter returns = next #15",
            "Waiter: Have you decided yet? = next #16",
            "Player: Yes I’ll have the soup of the day. = next #17",
            "Robbin: and I’ll have the fish. = next #18",
            "Waiter: Absolutely. May I take your menus? = next #19",
            "Robbin and Player hand the waiter their menus. = next #20",
            "Robbin: Did it really take you that long just to choose the soup of the day…? = Well I wasn't sure if I wanted soup or chicken. #21  = Yeah, there are so many days and so many soups, so many flavorful combinations. #21  = To be honest, I’ve always known I wanted soup, it just took me a while to realize it. #21",
            "Robbin: … oh = next #22",
            "Robbin: So… Did you grow up around here? = Yeah # 24  = What? In this restaurant? Oh.. no. I’m from Kalendyr. # 24  = You could say I grew up around here. # 24",
            "Robbin: Oh? Where about’s? How about sharing some details? = Well I grew up on 14th and west street. My family had the same apartment for over 15 years. I went to Castell regional highschool. #25  = Kalendyr is a small town, there is not much to it. Most of us are artisans, woodworkers, etc. #25  = I’d rather not say... But do you know the Kalendyr area? #25",
            "Robbin: Oh I knew some people from there. Do you know Gregory Surf? = next #26",
            "Player: No… can’t say that I do. But I feel like that name is familiar. I never really hung out with people outside of my highschool’s woodworking club. You would have thought that people in the woodworking club would have been really close, but there was actually a lot of drama. I remember this one time... = next #27",
            "You ramble about woodworking club drama until your food arrives = next #28",
            "Waiter: and for you, the soup of the day. = Wow this soup looks amazing! #29 = This soup is the most gorgeous  thing in this room! #29 = Look at this! So sweet and beautiful. How was it made, where were all the components grown. I have so many questions about this soup. #29",
            "Robbin: The soup? = next #30",
            "Player: Yeah, haven’t you ever had soup that was just divine?= next #31",
            "Robbin: The best soup I ever had was last summer when I was in Italy… = next #32",
            "Player: OH! I’ve been to Italy before. My senior year of high school the woodworking club took a trip to Italy. We went and saw all the famous wood in Italy. You would have thought that the woodworking drama would have stayed in highschool but it followed us there. Dave just wouldn’t stop harassing Alton… = Keep talking about woodworking. #33 = Tell a story about woodworking. #33 = Talk about that one time in Italy when Alton took Dave’s wood and it just got ugly. #33",
            "You spend the rest of the evening retelling what you remember as a gripping woodworking drama tale. = next #34",
            "Waiter: Thank you so much for joining us this evening and here is your check. = next #35",
            "Player frantically searches their pockets for money = next #36",
            "Robbin: Don’t tell me… you forgot the money, right!? = next #37",
            "Player: Well... funny story, actually this reminds me of a time in Italy with the woodworking clu- = next #38",
            "Robbin: IF YOU MENTION THE WOODWORKING CLUB ONE MORE TIME! You know what… I’m out of here. = next #39",
        };
    }
}