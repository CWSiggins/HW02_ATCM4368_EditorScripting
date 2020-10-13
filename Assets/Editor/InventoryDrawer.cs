using UnityEditor;
using UnityEngine;

// InventoryDrawer
[CustomPropertyDrawer(typeof(Equipment))]
public class InventoryDrawer : PropertyDrawer
{
    // Draw the property inside the given rect
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // Using BeginProperty / EndProperty on the parent property means that
        // prefab override logic works on the entire property.
        EditorGUI.BeginProperty(position, label, property);

        // Draw label
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        // Don't make child fields be indented
        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        // Calculate rects
        var ratingRect = new Rect(position.x, position.y, 30, position.height);
        var slotRect = new Rect(position.x + 35, position.y, 50, position.height);
        var rarityRect = new Rect(position.x + 90, position.y, 70, position.height);
        var nameRect = new Rect(position.x + 165, position.y, 125, position.height);

        // Draw fields - pass GUIContent.none to each so they are drawn without labels
        EditorGUI.PropertyField(ratingRect, property.FindPropertyRelative("rating"), GUIContent.none);
        EditorGUI.PropertyField(slotRect, property.FindPropertyRelative("slot"), GUIContent.none);
        EditorGUI.PropertyField(rarityRect, property.FindPropertyRelative("rarity"), GUIContent.none);
        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("name"), GUIContent.none);

        // Set indent back to what it was
        EditorGUI.indentLevel = indent;

        EditorGUI.EndProperty();
    }
}
