using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class SnapToGrid : MonoBehaviour {

    public GridDrawer gd;
    void Update()
    {
        Vector3 gridCoord = gd.WorldToGridSpace(transform.position);
        transform.position = gd.GridToWorld((int) gridCoord.x, (int) gridCoord.y);
    }
}
