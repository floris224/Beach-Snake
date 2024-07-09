using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public Transform targetPos;
    public Vector3 targetOldPos;
    public Transform startingPos;
    public Vector3 startingNewPos;
    public float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingNewPos = startingPos.position;
        targetOldPos = targetPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos.position,time);
        if(transform.position == targetPos.position)
        {
            startingNewPos = startingPos.position;
            targetOldPos = targetPos.position;

            targetPos.position = startingNewPos;
            startingPos.position = targetOldPos;
        }
    }
}
