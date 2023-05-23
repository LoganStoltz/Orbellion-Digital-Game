using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>(); //Static so that we can have the data be global so it can be used throughout the project

    void Awake()
    {
        cardList.Add(new Card(0, "Accelerate", 1, "The next card you play this turn costs 2", "Action"));
        cardList.Add(new Card(1, "Bite Back", 2, "Play when an opponent plays an Attack card. Hit that opponenet's active Hellion for 3 Physical damage.", "Reaction"));
        cardList.Add(new Card(2, "Blessed Strength", 3, "Play only on a Light Hellion. While affected Hellion is action, your first hot on each of your turns does 2 additional damage.", "Status"));
        cardList.Add(new Card(3, "Blinding Parry", 3, "Play when an opponent plays an Attack card. Counter that card.", "Reaction"));
    }

    /*
    void HellionAwake()
    {
        cardList.Add(new Card(0,))
    }
    */
}
