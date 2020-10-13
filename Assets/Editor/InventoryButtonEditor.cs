using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Inventory))]
public class InventoryButtonEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Inventory inventory = (Inventory)target;

        DrawUIDivider(Color.gray);

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Calculate Total Defense Rating"))
        {
            inventory.CalculateTotalDefense();
        }

        if (GUILayout.Button("Clear Rating"))
        {
            inventory.Clear();
        }

        if (GUILayout.Button("Clear Currently Equipped"))
        {
            inventory.ClearList();
        }

        GUILayout.EndHorizontal();
    }

    public static void DrawUIDivider(Color color, int thickness = 2, int padding = 10)
    {

        Rect rect = EditorGUILayout.GetControlRect(GUILayout.Height(thickness + padding));
        rect.height = thickness;
        rect.y += padding/2;
        rect.x -= 2;
        rect.width += 6;
        EditorGUI.DrawRect(rect, color);
    }
}