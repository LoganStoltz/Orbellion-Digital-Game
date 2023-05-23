using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 [System.Serializable]

public class Card
{
    /* --- Used by all Cards ---*/
    public int id;
    public string cardName;
    public string cardDescription;
    public string cardType; // Make into ENUM
    public Sprite cardArtwork;

    /* --- Used by Regular Cards ---*/
    public int energyCost;

    /* --- Used by Hellion --- */
    public int physicalDamage;
    public int elementalDamage;
    public int hp;
    public bool primary;
    


    public Card(){}

    public Card(int Id, string CardName, int EnergyCost, string CardDescription, string CardType, Sprite CardArtwork)
    {
        id = Id;
        cardName = CardName;
        energyCost = EnergyCost;
        cardDescription = CardDescription;
        cardType = CardType;
    }
}
