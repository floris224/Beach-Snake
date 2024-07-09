using UnityEngine;
using System.Collections.Generic;
public class OnTriggerEnterEvent : MonoBehaviour
{
    public Transform lightL;
    public Transform lightR;
    public Transform lightf;
    public GameObject target;
    public float distanceL;
    public float distanceR;
    public float distanceF;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.FindWithTag("Finish");
    }

    private void OnTriggerEnter(Collider other)
    {
        distanceL = Vector3.Distance(lightL.position, target.transform.position);
        distanceR = Vector3.Distance(lightR.position, target.transform.position);
        distanceF = Vector3.Distance(lightf.position, target.transform.position);

        if (distanceL <= distanceR && distanceL <= distanceF)
        {
            lightR.gameObject.SetActive(false);
            lightf.gameObject.SetActive(false);
        }
        if(distanceR<= distanceF && distanceR <= distanceL)
        {
            lightf.gameObject.SetActive(false);
            lightL.gameObject.SetActive(false);
        }
        if(distanceF<= distanceL&& distanceF<= distanceR)
        {
            lightR.gameObject.SetActive(false);
            lightL.gameObject.SetActive(false);
        }

    }
}
