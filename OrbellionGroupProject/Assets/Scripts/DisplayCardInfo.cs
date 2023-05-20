using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCardInfo : MonoBehaviour
{
    public List<Card> displayCardInfo = new List<Card>();
    public int displayId; // To see what card we are using
    
    /* ---  Declaring Card Variables --- */
    public int id;
    public string cardName;
    public int energyCost;
    public int physicalDamage;
    public int elementalDamage;
    public string cardDescription;
    public int hp; // For Hellions
    public bool primary; // For Hellions

    /* --- Variables for the Text components of our cards --- */
    public Text nameText;
    public Text energyCostText;
    public Text physicalDamageText;
    public Text elementalDamageText;
    public Text cardDescirptionText;
    public Text hpText; // For Hellions

    void Start()
    {
        displayCardInfo[0] = CardDatabase.cardList[displayId];
    }

    void Update()
    {
        // TODO: make a function to handle DisplayCardInfo rather than a massive list in update & add Hellion variables
        id = displayCardInfo[0].id;
        cardName = displayCardInfo[0].cardName;
        energyCost = displayCardInfo[0].energyCost;
        physicalDamage = displayCardInfo[0].physicalDamage;
        elementalDamage = displayCardInfo[0].elementalDamage;
        cardDescription = displayCardInfo[0].cardDescription;

        nameText.text = " " + cardName;
        energyCostText.text = " " + energyCost;
        physicalDamageText.text = " " + physicalDamage;
        elementalDamageText.text = " " + elementalDamage;
        cardDescirptionText.text = " " + cardDescription;
    }
}
