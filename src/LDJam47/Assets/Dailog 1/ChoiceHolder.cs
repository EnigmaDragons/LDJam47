﻿using System.Collections.Generic;
using UnityEngine;

public class ChoiceHolder : MonoBehaviour
{
    public List<string> dateA;
    public List<string> dateB;
    public List<string> dateC;

    public void Awake()
    {
        dateA = new List<string>
        {
           "PLAYER_NAME: No matter how polite I am, how many doors I hold open, how many dates I compliment they just don’t have the ability to keep up with me. = next #2",
           "PLAYER_NAME: Being both a line chef and a motorbike stunt driver… Well it intimidates a lot of people. = next #3",
           "PLAYER_NAME: But finally my cousin Tim set me up with one of his sister’s friends. = next #4",
           "PLAYER_NAME: And knowing how smooth I am with the ladies this should be a cinch. = next #5", // Player enters scene on #5
           "Robin: Hi PLAYER_NAME I’m Robin nice to meet you. = next #6",
           "PLAYER_NAME: Damn you got here before me? = next #7",
           "Robin: Well we were supposed to meet here 20 minutes ago. You should plan ahead better next time. = No need to get all sobby on me. We’re here to have fun right? #8 = Geez I’m here for two seconds and you’re already bitching. #9 = Hey if I got to wait around in a place like this I wouldn’t be complaining. Lighten up. #10 ",
           "PLAYER_NAME: No need to get all sobby on me. We’re here to have fun right? = next #11",
           "PLAYER_NAME: Geez I’m here for two seconds and you’re already bitching. = next #11",
           "PLAYER_NAME: Hey if I got to wait around in a place like this I wouldn’t be complaining. Lighten up. = next #11",
           "Robin: Yeah... sure… = Don’t be mad. Hey waiter! We’ll take two beers. #12 = It’s Friday baby! Hey waiter! A round of tequila shots! #13 = Drinks? Hey waiter! I’m thinking margs for the table. #14",
           "PLAYER_NAME: Don’t be mad. Hey waiter! We’ll take two beers. = next #15",
           "PLAYER_NAME: It’s Friday baby! Hey waiter! A round of tequila shots! = next #15",
           "PLAYER_NAME: Drinks? Hey waiter! I’m thinking margs for the table. = next #15",
           "Robin: Actually water is fine for me. = You’re gonna get something a little stronger. My treat. #16 = You’re not gonna make me drink alone are you? Plus I’m paying. #17 = Come on you didn’t come out tonight to drink water? Don’t worry I’ll cover this round. #18",
           "PLAYER_NAME: You’re gonna get something a little stronger. My treat. = next #19",
           "PLAYER_NAME: You’re not gonna make me drink alone are you? Plus I’m paying. = next #19",
           "PLAYER_NAME:  Come on you didn’t come out tonight to drink water? Don’t worry I’ll cover this round. = next #19",
           "Robin: Ok fine but could I also get some water. = next #20",
           "Waiter: No problem I’ll be back with your drinks soon. = next #21",
           "Robin: I really can’t drink too much tonight I have to drive home after. = Oh come on. I’m not saying we should get black out drunk. #22 = Hey, worst case we can get an uber back to my place. #23 = There are literally never cops in this part of town. You’ll be fine. #24 ",
           "PLAYER_NAME: Oh come on. I’m not saying we should get black out drunk. = next #25",
           "PLAYER_NAME: Hey, worst case we can get an uber back to my place. = next #25",
           "PLAYER_NAME: There are literally never cops in this part of town. You’ll be fine. = next #25",
           "Robin: Right… So... what do you do for a living? = [Panera] #26 = [Motocross] #27 = [Jewelry] #28",
           "PLAYER_NAME: Well I used to be chef at the Panera until my ex got me fired. After each shift they would just throw away the extra bagels. Once I found out I volunteered to do it and just stashed the extras. I thought they would be happy for the free food. How about you? = next #29",
           "PLAYER_NAME: I had this gig managing a motocross park during the week but my ex got pissed and told the manager about the parties I was throwing there so now on Monday I gotta go in and apologize and shit. How about you? = next #29",
           "PLAYER_NAME: My ex used to make these jewelry things and I was helping her sell them online before we broke up. But I still have access to the paypal which is nice. How about you? = next #29",
           "Robin: Oh I’m an agent at Compass Realty Group. = [Horse Betting] #30 = [Can you sell my RV] #31 = [I could be a realtor] #32",
           "PLAYER_NAME: Oh shit. Yeah y'all have a big billboard on route 183 right outside the horse racing track. Two weekends ago I went to the track with some friends and my buddy Eric and I bet $250 on the race. I’ve never seen someone lose their paycheck that fast. = next #33",
           "PLAYER_NAME: Oh so you sell houses and shit? I have this old RV my Grandad left me that I was thinking about selling. But I put a lot of work into it so maybe not. When I turn on all the interior lights it looks like one of those professional party buses and I have some pretty nice speakers too. = next #33",
           "PLAYER_NAME: I bet I could sell a house better than 99% of the people you work with. I’m really good at convincing people that they need stuff. I could even pull out an old suit I have and get all fancy. I’m such a great salesman, I could sell a glass of water to a scuba diver. = #33",
           "Robin: Well that’s interesting… = Man when are those drinks getting here… #34 = Fuck I thought this was a nice place. #35 = Didn’t I order our drinks like ten minutes ago? #36",
           "PLAYER_NAME: Man when are those drinks getting here… Have you been here before? Are they usually this slow? = next #37",
           "PLAYER_NAME: Fuck I thought this was a nice place. Where the hell are our drinks. Don’t you hate places with slow service? = next #37",
           "PLAYER_NAME: Didn’t I order our drinks like ten minutes ago? What’s taking them so long? = next #37",
           "Robin: I’m sure they are working as fast as they can. = Don’t be so idiotic. If you want shit in life you gotta take it. #38 = Don’t be so naive. These people will try to scam you if you give them the chance. #39 = You can’t be that dumb. I’ve seen our waiter pass by the bar 3 times by now and not get our drinks. #40",
           "PLAYER_NAME: Don’t be so idiotic. If you want shit in life you gotta take it. = next #41",
           "PLAYER_NAME: Don’t be so naive. These people will try to scam you if you give them the chance. = next #41",
           "PLAYER_NAME: You can’t be that dumb. I’ve seen our waiter pass by the bar 3 times by now and not get our drinks. = next #41",
           "Robin: Excuse me? You can't be serious. = What, you don’t believe me? #42 = Oh I’m serious alright. #43 = Fuck me I’m so thirsty. #44",
           "PLAYER_NAME: What, you don’t believe me? Here I’ll prove it. Hey Waiter, could you make our drinks any slower?! = next #45",
           "PLAYER_NAME: Oh I’m serious alright. Excuse me!? Are you really going to make my date wait this long for their simple drink order?! = next #45",
           "PLAYER_NAME: Fuck me I’m so thirsty. If only someone whose job it is to serve me drinks would get off their lazy ass! = next #45",
           "Waiter: Sir your drinks are being made right now and I assure you they are coming as quickly as possible. = next #46",
           "Robin: You know what fuck this. This date is over. You know you’re a complete ass right? = Hey it's not my fault #47 = What are you talking about? #48 = I’m an ass? #49",
           "PLAYER_NAME: Hey it's not my fault they screwed up our orders. = next #50",
           "PLAYER_NAME: What are you talking about? Don’t go. They just said our drinks were about to get here. = next #50",
           "PLAYER_NAME: I’m an ass? At least I’m not some boring bitch that orders water on Friday night. = next #50",
        };

        dateB = new List<string>
        {
            "Robin: Well we were supposed to meet here 20 minutes ago. You should probably just plan ahead better next time. = ... #2 = ... #2 = ... #2",
            "PLAYER_NAME: ... = next #3",
            "Robin: Um… So… have you ever eaten here before? I’m not sure what to order. = Pinch yourself. #4 = Hit your hand with your spoon. #5 = Slap yourself. #6",
            "You pinch yourself = next #7",
            "You hit your hand with your spoon = next #7",
            "You slap yourself = next #7",
            "Robin: Hey don’t hurt yourself. What are you doing? = So I guess this isn’t a dream. #8 = This can’t be real. #9 = Am I high? #10",
            "PLAYER_NAME: So I guess this isn’t a dream. = next #11",
            "PLAYER_NAME: This can’t be real. = next #11",
            "PLAYER_NAME: Am I high? = next #11",
            "Robin: Hey you don’t look so good. Hey Waiter, could we get some water? = next #12",
            "Waiter: Yeah of course. Is everything alright PLAYER_NAME? = Water is fine. #13 = … #14 = Sure. Water.  #15",
            "PLAYER_NAME: Water is fine = next #16",
            "PLAYER_NAME: ... = next #16",
            "PLAYER_NAME: Sure. Water. = next #16",
            "Waiter: Here are your waters. = Take a drink of water #17 = … #18",
            "You drink your water = next #19",
            "PLAYER_NAME: ... = next #19",
            "Robin: How are you feeling now? = I never thought I’d see you again.  #20 = You were just lying there. Motionless on the street. #21 = No matter how hard I try I can’t get that image out of my head. #22",
            "PLAYER_NAME: I never thought I’d see you again. = next #23",
            "PLAYER_NAME: You were just lying there. Motionless on the street. = next #23",
            "PLAYER_NAME: No matter how hard I try I can’t get that image out of my head. = next #23",
            "Robin: You know what. It seems like you are going through some stuff. Do you want to just call tonight off? I can order an Uber to take you home if you want? = If I’m not dreaming or high then what is all this? #24 = I don’t need to go home. I need to figure out what’s going on here.  #25 = … #26",
            "PLAYER_NAME: If I’m not dreaming or high then what is all this? = next #27",
            "PLAYER_NAME: I don’t need to go home. I need to figure out what’s going on here. = next #27",
            "PLAYER_NAME: ... = next #27",
            "Robin: Ok well if you’re not even going to pretend like you are interested in our date then I’ll just head out. I hope everything works out for you. = Wait! I can’t let you leave. #28 = NO! You have to stay. #29 = Please… Don’t go. #30",
            "PLAYER_NAME: Wait! I can’t let you leave. = next #31",
            "PLAYER_NAME: NO! You have to stay. = next #31",
            "PLAYER_NAME: Please… Don’t go. = next #31",
            "Robin: Why? There is clearly something in the matter and if you won’t talk to me about it then what am I supposed to do? = Please… Don’t go. #32 = Please… Don’t go. #32 = Please… Don’t go. #32",
            "PLAYER_NAME: Please… Don’t go. = next #33",
            "Robin: Hey look, you seem nice enough, but I don’t know you and you have to admit you’re acting very strange. = next #34",
            "Robin: I came out tonight because I wanted to have some fun. You have to understand that whatever is going on here…  = next #35",
            "Robin: Like I’m no one to judge… but if you’re not going to tell me what’s wrong I’m not going to sit here and babysit you. = If you leave you’ll die!  #36 = A bus is going to hit you for christ sake! #37 = Please… Don’t go. #38",
            "PLAYER_NAME: If you leave you’ll die! = next #39",
            "PLAYER_NAME: A bus is going to hit you for christ sake! = next #39",
            "PLAYER_NAME: Please… Don’t go. = next #39",
            "Robin: Alright then... I’m going to go.  = Don’t go. I'm trying to save you! #40 = Someone stop her! #41 = Please… Don’t go. #42",
            "PLAYER_NAME: Don’t go. I'm trying to save you! = next #43",
            "PLAYER_NAME: Someone stop her! = next #43",
            "PLAYER_NAME: Please… Don’t go. = next #43",
            "Robin: …  = next #44",
            "PLAYER_NAME: I had been almost paralized sitting in front of Robin. = next #45",
            "PLAYER_NAME: But when I heard that sound my instincts took over. = next #46",
            "PLAYER_NAME: I was already on the line with 911 before I got outside. = next #47",
            "PLAYER_NAME: But the scene was the same as the image burned into my mind. = next #48",

            "Player: This is all my fault.",
        };

        dateC = new List<string>
        {
            "Robin: Well PLAYER_NAME you should probably plan ahead better next time.  = next #2",
            "Player: Okay, It’s happening again.  Play it cool, PLAYER_NAME.  If she has a nice time on the date, she won’t walk away and get hit by the bus.  =  Well let's order. I’ve been excited to try this place. #3 = I’ll get the waiter. #3 = This place is kind of whack. Do you wanna just get out of here? #4",
            "Player calls over the waiter. = next #5",
            "Robin: No I think it's fine. Lets just order. Robin calls over the waiter. = next #5",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
        };
    }
}