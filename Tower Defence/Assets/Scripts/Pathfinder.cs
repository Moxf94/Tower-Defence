using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    Dictionary<Vector2Int, WayPoint> grid = new Dictionary<Vector2Int, WayPoint>();
    [SerializeField] WayPoint startPoint, endPoint;

    Vector2Int[] directions =
    {
        Vector2Int.up,
        Vector2Int.right,
        Vector2Int.down,
        Vector2Int.left
    };

    void Start()
    {
        
        LoadBlocks();
        SetColorStartAndEnd();
        ExploreNearPoints();
    }


    private void ExploreNearPoints()
    {
        foreach(Vector2Int direction in directions)
        {
            Vector2Int nearPointCordinates =  startPoint.GetGridPos() + direction;

            try
            {
                grid[nearPointCordinates].SetTopColor(Color.blue);
            }
            catch
            {
                Debug.LogWarning("Блок : " + nearPointCordinates + "отсутствует");
            }
            print("Проверено : " + nearPointCordinates);

        }
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
