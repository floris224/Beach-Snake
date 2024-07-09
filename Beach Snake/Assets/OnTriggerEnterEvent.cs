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
    private void Update()
    {
        target = GameObject.FindWithTag("Finish");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(lightf != null && target !=null)
        {
            distanceF = Vector3.Distance(lightf.position, target.transform.position);
        }
        else
        {
            distanceF = float.MaxValue;
        }
        if(lightL != null)
        {
            distanceL = Vector3.Distance(lightL.position, target.transform.position);
        }
        else
        {
            distanceL = float.MaxValue;
        }
        if(lightR != null)
        {
            distanceR = Vector3.Distance(lightR.position, target.transform.position);
        }
        else
        {
            distanceR = float.MaxValue;
        }
       
        

        if (distanceL <= distanceR && distanceL <= distanceF)
        {
            if(lightf != null)
            {
                lightf.gameObject.SetActive(false);
            }
            if(lightR != null)
            {
                lightR.gameObject.SetActive(false);
            }
           
            
        }
        if(distanceR<= distanceF && distanceR <= distanceL)
        {
            if (lightf != null)
            {
                lightf.gameObject.SetActive(false);
            }
            if (lightL != null)
            {
                lightL.gameObject.SetActive(false);
            }
        }
        if(distanceF<= distanceL&& distanceF<= distanceR)
        {
            if (lightR != null)
            {
                lightR.gameObject.SetActive(false);
            }
            if (lightL != null)
            {
                lightL.gameObject.SetActive(false);
            }
           
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if(lightR != null)
        {
            lightR.gameObject.SetActive(true);
        }
        if(lightf != null)
        {
            lightf.gameObject.SetActive(true);
        }
        if(lightL != null)
        {
            lightL.gameObject.SetActive(true);
        }
        
        distanceF = 0;
        distanceL = 0;
        distanceR = 0;
      
    }
}
