using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId; // To see what card we are using
    
    /* ---  Declaring Card Variables --- */
    public int id;
    public string cardName;
    public int energyCost;
    public string cardDescription;
    public string cardType;

    /* --- Variables for the Text components of our cards --- */
    public Text nameText;
    public Text energyCostText;
    public Text cardDescirptionText;
    public Text cardTypeText;

    void Start()
    {
        displayCard[0] = CardDatabase.cardList[displayId];
    }

    void Update()
    {
        // TODO: make a function to handle DisplayCardInfo rather than a massive list in update & add Hellion variables
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        energyCost = displayCard[0].energyCost;
        cardDescription = displayCard[0].cardDescription;
        cardType = displayCard[0].cardType;

        // Replacing current text
        nameText.text = "" + cardName;
        energyCostText.text = "" + energyCost;
        cardDescirptionText.text = "" + cardDescription;
        cardTypeText.text = "" + cardType;
    }
}
