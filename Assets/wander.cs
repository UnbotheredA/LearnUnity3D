using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wander : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 currentPos;
    Vector3 circle;
    void Start()
    {

        circle = Random.insideUnitCircle * 20;


    }

    // Update is called once per frame
    void Update()
    {


    }
    void FixedUpdate()
    {
        //currentPos = gameObject.transform.position.normalized;

        //currentPos += distance;
        float x = 0f;
        x += Time.deltaTime;
        int timer = 0;
     
        while(timer <= 20) 
        {
            timer++;
            currentPos = transform.forward * 5;
            //currentPos = transform.forward * 5 + circle;
            //Debug.Log(circle);
            //timer = 0;
        }
        timer = 0;
        currentPos = transform.forward * 5 + circle;
        Debug.DrawLine(gameObject.transform.position, currentPos, Color.blue);
      
        Debug.Log(timer);
        //else 
        //{
        //    currentPos = transform.forward * 5 + circle;
        //    Debug.Log(circle);
        //    Debug.DrawLine(gameObject.transform.position, currentPos, Color.red);
        //    Debug.Log(x);
        //}


        // move to the random pos


    }
}
