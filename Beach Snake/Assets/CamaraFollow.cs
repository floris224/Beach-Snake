using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public GameObject[] moveToPoints;
    public Transform cam;
    public int pointIndex;


    public void Update()
    {
        CheckMovePoint();
        cam.position = Vector3.MoveTowards(cam.position, moveToPoints[pointIndex].transform.position, 5f * Time.deltaTime);
        cam.rotation = Quaternion.RotateTowards(cam.rotation, moveToPoints[pointIndex].transform.rotation, 40f  * Time.deltaTime);
    }
    public void CheckMovePoint()
    {

        if (cam.position == moveToPoints[pointIndex].transform.position)
        {
            pointIndex++;

            if(pointIndex >= moveToPoints.Length)
            {
                pointIndex = 0;
            }
        }
    }
}
