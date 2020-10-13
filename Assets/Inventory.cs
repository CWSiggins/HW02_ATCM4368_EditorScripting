using System;
using UnityEngine;

public enum EquipmentSlot { Arm, Head, Leg, Chest }
public enum RaritySlot { Common, Rare, Epic, Legendary }


// Custom serializable class
[Serializable]
public class Equipment
{
    public string name;
    public int rating = 1;
    public EquipmentSlot slot;
    public RaritySlot rarity;
}

[Serializable]
public class Button
{
    Inventory inventory;
}

public class Inventory : MonoBehaviour
{
    public int totalRating;
    public Button totalDefenseRating;
    public Equipment[] currentlyEquipped;

    public void CalculateTotalDefense()
    {
        if(totalRating == 0)
        {
            foreach (Equipment r in currentlyEquipped)
            {
                totalRating += r.rating;
            }
        }
    }

    public void Clear()
    {
        totalRating = 0;
    }

    public void ClearList()
    {
        Array.Clear(currentlyEquipped, 0, currentlyEquipped.Length);
    }
}

