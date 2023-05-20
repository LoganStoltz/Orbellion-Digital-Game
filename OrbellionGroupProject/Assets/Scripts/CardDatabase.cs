using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>(); //Static so that we can have the data be global so it can be used throughout the project

    void CardAwake()
    {
        cardList.Add(new Card(0, "Dwarf", 3, 4, 5, "I am a Dwarf"));
        cardList.Add(new Card(1, "Human", 1, 2, 3, "I am a Human"));
        cardList.Add(new Card(2, "None", 0, 0, 0, "None"));
        cardList.Add(new Card(3, "None", 0, 0, 0, "None"));
    }

    /*
    void HellionAwake()
    {
        cardList.Add(new Card(0,))
    }
    */
}
