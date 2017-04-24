using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridDrawer : MonoBehaviour
{


    public Color normalColor, selectedColor;
    public  float GridSize = 1.5f;
    public int width, height;


    private void OnDrawGizmos()
    {
        Color oldColor = Gizmos.color;
        Gizmos.color = normalColor;
        GridGizmo(width, height);
        GridFrameGizmo(width, height);
        Gizmos.color = oldColor;
    }

    private void OnDrawGizmosSelected()
    {
        Color oldColor = Gizmos.color;
        Gizmos.color = selectedColor;
        GridFrameGizmo(width, height);
        Gizmos.color = oldColor;
    }

    void GridFrameGizmo(int cols, int rows)
    {
        Gizmos.DrawLine(new Vector3(0, 0, 0), new Vector3(0, rows * GridSize, 0));
        Gizmos.DrawLine(new Vector3(0, 0, 0), new Vector3(cols * GridSize, 0, 0));
        Gizmos.DrawLine(new Vector3(cols * GridSize, 0, 0), new Vector3(cols * GridSize, rows * GridSize, 0));
        Gizmos.DrawLine(new Vector3(0, rows * GridSize, 0), new Vector3(cols * GridSize, rows * GridSize, 0));
    }

    void GridGizmo(int cols, int rows)
    {
        for (int i = 0; i < cols; i++)
        {
            Gizmos.DrawLine(new Vector3(i * GridSize, 0, 0), new Vector3(i * GridSize, rows * GridSize, 0));
        }
        for (int j = 0; j < rows; j++)
        {
            Gizmos.DrawLine(new Vector3(0, j * GridSize, 0), new Vector3(cols * GridSize, j * GridSize, 0));
        }
    }
    public Vector3 WorldToGridSpace(Vector3 point)
    {

        Vector3 gridPoint = new Vector3(
            (int)((point.x - transform.position.x) / GridSize),
            (int)((point.y - transform.position.y) / GridSize), 0);

        return gridPoint;
    }
    public Vector3 GridToWorld(int col, int row )
    {
        Vector3 worldPoint = new Vector3(
            transform.position.x + (width * GridSize + GridSize / 2),
            transform.position.y + (height * GridSize + GridSize / 2), 0);
        return worldPoint;
    }

    public bool IsInsideGridBounds(Vector3 point)
    {
        float minX = transform.position.x;
        float maxX = minX + width * GridSize;
        float minY = transform.position.y;
        float maxY = minY + height * GridSize;

        return (point.x > minX && point.x <= maxX && point.y >= minY && point.y <= maxY);
    }

    public bool IsInsideGridBounds(int col, int row)
    {
        return (col >= 0 && col < width && row >= 0 && row < height);
    }
}
    


