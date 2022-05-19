using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(WayPoint))]
public class CubeEditor : MonoBehaviour
{
   
    const int gridSize = 10;

    TextMesh label;
    Vector3 snaPos;
    WayPoint waypoint;

    private void Awake()
    {
        waypoint = GetComponent<WayPoint>();
    }
    void Update()
    {
        SnapToGrid();

        UpdateLabel();

    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GetGridSize();
     
        transform.position = new Vector3(waypoint.GetGridPos().x * gridSize, 0f, waypoint.GetGridPos().y * gridSize);
    }

    private void UpdateLabel()
    {
        int gridSize = waypoint.GetGridSize();
        label = GetComponentInChildren<TextMesh>();
        string labelName = snaPos.x / gridSize + "," + snaPos.z / gridSize;
        label.text = labelName;
        gameObject.name = labelName;
    }
}
