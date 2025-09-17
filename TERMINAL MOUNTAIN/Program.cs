using System;
using System.ComponentModel.Design;

Console.WriteLine("you are hard addicted to delicous cigs and you NEED one. Search your neibhours house for cigerrete");
Console.WriteLine("you walk over to the house ready to break in and grab the cigs. how should you enter FRONTDOOR or BACKDOOR");
Thread.Sleep(1000);
Console.WriteLine("Choises will appear in all caps and may need to be typed in two times to register");
Thread.Sleep(1000);
Console.ReadLine();


bool search = true;
while (search == true)
{
    string FRONTDOOR = Console.ReadLine();
    if (FRONTDOOR == "FRONTDOOR")
    {
        Console.WriteLine("you decide to go through the front door because, you reach for the cheap wooden door nob and turn it slowly.");
        Console.WriteLine("you see a well decorated living room and many electronic devices scattered around the house. but nothhing matters," +
            "except ciggarettes of course where would someone keep their cigs? GARAGE or BEDROOM");
        Thread.Sleep(1000);
    }
    else if (FRONTDOOR == "BACKDOOR")
    {
        Console.WriteLine("you hop over the back fence and walk up to a sliding glass door, its locked how should you get in?");
        Console.WriteLine("you could BREAK the door and go in or you could try your hand at trying to UNLOCK it");
    }
    string GARAGE = Console.ReadLine();
    if (GARAGE == "GARAGE")
    {
        Console.WriteLine("you enter the garage adn then you see it, your only need in life a divine pack of cigs, you snatch it and run out" +
            "the house laughing like a super villian even though all you took was a half empty pack of cigs");
        Console.WriteLine("You have achieved your goal and now have a warrant for breaking and entering... THE END");
    }
    else if (GARAGE == "BEDROOM")
    {
        Console.WriteLine("you search the master bedroom only to find nothing except 300k in cash splattered with blood and a used handgun, " +
            "which  you cant smoke so it's useless but atleast your neighbor has interesting hobbies");
        Console.WriteLine("Since you didnt find anything you decide to search the GARAGE");
        Console.WriteLine("Please type GARAGE to procead");
        Thread.Sleep(1000);
    }
    string UNLOCK = Console.ReadLine();
    if (UNLOCK == "UNLOCK")
    {
        Console.WriteLine("you attempt to pick the lock but you made one crucial mistake, you forgot you're an idiot and dont actually know " +
            "how to pick a lock so you jam random metal objects into the lock, The glass door shatters as you moronicly fidget with the lock.");
        Console.WriteLine("search GARAGE or BEDROOM");
    }
    else if (UNLOCK == "BREAK")
    {
        Console.WriteLine("You smash your elbow into the glass door shattering it, you barley cut yourself somehow.");
        Console.WriteLine("Where should you begin your search? Search the BEDROOM or the GARAGE?");
    }
}


