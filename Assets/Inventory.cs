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

public class Inventory : MonoBehaviour
{
    public Equipment[] currentlyEquipped;
}

