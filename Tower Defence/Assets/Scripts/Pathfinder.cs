using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    Dictionary<Vector2Int, WayPoint> grid = new Dictionary<Vector2Int, WayPoint>();
    [SerializeField] WayPoint startPoint, endPoint;

    void Start()
    {
        
        LoadBlocks();
        SetColorStartAndEnd();
    }

    
    private void LoadBlocks()
    {
        var waypoints = FindObjectsOfType<WayPoint>();
        foreach (WayPoint waypoint in waypoints)
        {
            bool IsOverLapping = grid.ContainsKey(waypoint.GetGridPos());
            if (IsOverLapping)
            {
                Debug.LogWarning("Повтор " + waypoint);
            }
            else
            {
                grid.Add(waypoint.GetGridPos(), waypoint);
                
            }
        }
        print("Grid");
    }

    void SetColorStartAndEnd()
    {
        startPoint.SetTopColor(Color.green);
        endPoint.SetTopColor(Color.red);
    }
    void Update()
    {
        
    }
}
