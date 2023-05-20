using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int energyCost;
    public int physicalDamage;
    public int elementalDamage;
    public string cardDescription;
    public int hp; // For Hellions
    public bool primary; //For Hellions


    public Card(){}

    public Card(int Id, string CardName, int EnergyCost, int PhysicalDamage, int ElementalDamage, string CardDescription)
    {
        id = Id;
        cardName = CardName;
        energyCost = EnergyCost;
        physicalDamage = PhysicalDamage;
        elementalDamage = ElementalDamage;
        cardDescription = CardDescription;
    }

    /*
    public HellionCard(){}

    public HellionCard(int Id, string CardName, int Hp, int EnergyCost int PhysicalDamage, int ElementalDamage, string CardDescription, boolean Primary)
    {
        id = Id;
        cardName = CardName;
        hp = Hp;
        energyCost = EnergyCost;
        physicalDamage = PhysicalDamage;
        elementalDamage = ElementalDamage;
        cardDescription = CardDescription;
        primary = Primary;
    }
    */
}
