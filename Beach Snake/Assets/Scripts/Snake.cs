using UnityEngine;
using System.Collections.Generic;

public class Snake : MonoBehaviour
{
    private PlayerControls playerControls;
    public List<Transform> BodyParts = new List<Transform>();
    public float minDistance = 0.25f;
    public float speed;
    public float rotationSpeed;
    public GameObject bodyPrefab;
    public int beginingSize;
    public float distance;
    private Transform currentBodyPart;
    private Transform previousBodyPart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < beginingSize -1; i++)
        {
            AddBodyPart();
        }
    }
    private void Awake()
    {
        playerControls = new PlayerControls();
    }
    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void OnDisable()
    {
        playerControls.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            AddBodyPart();
        }
    }
    public void Move()
    {
        float curSpeed = speed;
        Vector2 move = playerControls.Player.Move.ReadValue<Vector2>();
        if (move.y > 1) 
        {
            curSpeed *= 2;

        }
        
        BodyParts[0].Translate(BodyParts[0].forward*curSpeed*Time.smoothDeltaTime,Space.World);
       
        if (move.x < 0)
        {
            BodyParts[0].Rotate(Vector3.up * -rotationSpeed * Time.deltaTime, move.x);
        }
        else if (move.x > 0)
        {
            BodyParts[0].Rotate(Vector3.up * -rotationSpeed * Time.deltaTime, move.x);
        }
        for (int i = 1; i < BodyParts.Count; i++)
        {
            currentBodyPart = BodyParts[i];
            previousBodyPart = BodyParts[i-1];

            distance = Vector3.Distance(previousBodyPart.position, currentBodyPart.position);

            Vector3 newPos = previousBodyPart.position;
            newPos.y = BodyParts[0].transform.position.y;
            float T = Time.deltaTime* distance / minDistance * curSpeed;
            if (T > 0.5f)
            {
                T = 0.5f;
            }
            currentBodyPart.position = Vector3.Slerp(currentBodyPart.position, newPos, T);
            currentBodyPart.rotation = Quaternion.Slerp(currentBodyPart.rotation, previousBodyPart.rotation, T);
        }
    }
    public void AddBodyPart()
    {
        Transform newpart = (Instantiate(bodyPrefab, BodyParts[BodyParts.Count - 1].position, BodyParts[BodyParts.Count - 1].rotation) as GameObject).transform ;
        newpart.SetParent(transform);
        BodyParts.Insert(1,newpart);
    }
}
