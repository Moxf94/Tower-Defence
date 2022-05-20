using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    Dictionary<Vector2Int, WayPoint> grid = new Dictionary<Vector2Int, WayPoint>();
    
    void Start()
    {
        
        LoadBlocks();
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
    void Update()
    {
        
    }
}
