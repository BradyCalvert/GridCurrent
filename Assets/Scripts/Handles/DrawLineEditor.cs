using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(DrawLine))]
public class DrawLineEditor : Editor {

    private void OnSceneGUI()
    {
        DrawLine dl = (DrawLine)target;

        if (dl == null || dl.GameObjects == null)
            return;

        Vector3 center = dl.transform.position;

        for(int i =0;i<dl.GameObjects.Length; i++)
        {
            if(dl.GameObjects[i]!=null)
            {
                Handles.DrawLine(center, dl.GameObjects[i].transform.position);
            }
        }
    }
}
