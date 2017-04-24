using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(WireArcExample))]

public class DrawWireArc : Editor {

    private void OnSceneGUI()
    {
        Handles.color = Color.red;
        WireArcExample myARC = (WireArcExample)target;

        Handles.DrawWireArc(myARC.transform.position, myARC.transform.up, -myARC.transform.right, myARC.shieldDegree, myARC.shieldArea);
        myARC.shieldArea = (float)Handles.ScaleValueHandle(myARC.shieldArea, myARC.transform.position + myARC.transform.forward * myARC.shieldArea,myARC.transform.rotation,5,Handles.CubeCap,1);
    }
}
