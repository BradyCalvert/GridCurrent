using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ButtonExample))]

public class ButtonExampleEditor : Editor
 {
    private void OnSceneGUI()
    {
        ButtonExample button = (ButtonExample)target;


        Handles.BeginGUI();
        GUILayout.BeginArea(new Rect(10, 10, 100, 50));
        if(GUILayout.Button("Reset"))
        {
            button.transform.position = Vector3.zero;
        }
        

        GUILayout.Label("This will turn the \ncomputer off.");
        GUILayout.EndArea();
        Handles.EndGUI();
    }
}
