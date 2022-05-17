using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoviement : MonoBehaviour
{
   [SerializeField] List<WayPoint> blocksList;    


    void Start()
    {
        PrintWayPointName();
        StartCoroutine(PrintWayPointName());
    }


    IEnumerator PrintWayPointName()
    {
        foreach (WayPoint waypoint in blocksList)
        {
            print("Враг начал движение");
            transform.position = waypoint.transform.position;
            print("Враг пришел на позицию : " + waypoint);
            Debug.Log(waypoint.name);

            yield return new WaitForSeconds(1f);
        }
        print("Враг закончил движение");
    }
}
