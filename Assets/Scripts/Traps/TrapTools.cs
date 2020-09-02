using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using UnityEditor.PackageManager;
using UnityEngine;

public class TrapTools : MonoBehaviour
{
    private GameObject movingObject;
    private delegate void UpdateAction();
    UpdateAction updateAction;  
    private delegate void FixedUpdateAction();
    FixedUpdateAction fixedUpdateAction;
    /// <summary> This method is using to set gameObject to work with
    /// <para> You have to send: Gameobject which you want to work with </para>
    /// </summary>
    public void SetGameObjectToMove(GameObject movingObject)
    {
        this.movingObject = movingObject;

    }
    /// <summary> This method is using to move object on the scene to given points with uniform movement. 
    /// <para> Include: Collision with player </para>
    /// <para> You have to send: Gameobjects array of points, float speed </para>
    /// </summary>
    public void movingToPointsWithOneSpeed(GameObject[] points, float speed)
    {
        foreach(GameObject point in points)
        {
            movingToPointWithOneSpeed(point, speed);
        }    

    }
    /// <summary> This method is using to move object on the scene to given points with different speeds. 
    /// <para>Include: Collision with player </para>
    /// <para>You have to send: Gameobjects array of points, floats array of speed </para>
    /// <para>Moreover: Array index of points is equivalent to the index of speeds - they are same </para>
    /// </summary>
    public void movingToPointsWithDifferentSpeed(GameObject[] points, float[] speeds)
    {
        int totalPoints = points.Count();

        for(int i = 0; i<totalPoints; i++)
        {
            movingToPointWithOneSpeed(points[i], speeds[i]);
        }
           
    }


    /// <summary> This method is using to move object on the scene to given !one! point with uniform movement. 
    /// <para> Include: Collision with player </para>
    /// <para> You have to send: Gameobject point, float speed </para>
    /// </summary>
    public void movingToPointWithOneSpeed(GameObject point, float speed)
    {
        movingObject.GetComponent<Rigidbody>() ;

    }
    private void FixedUpdate()
    {
        fixedUpdateAction();
    }
    private void Update()
    {
        updateAction();
    }

}
