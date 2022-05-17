using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CubeEditor : MonoBehaviour
{


    [SerializeField] [Range(1f,20f)] private float gridSize = 10f;

    TextMesh label;
    void Update()
    {
        Vector3 snaPos;

        snaPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snaPos.y = 0f;
        snaPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;
        transform.position = snaPos;

        label = GetComponentInChildren<TextMesh>();
        string labelName = snaPos.x / gridSize + "," + snaPos.z / gridSize;
        label.text = labelName;
        gameObject.name = labelName;

    }
}
