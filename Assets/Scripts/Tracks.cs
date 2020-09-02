using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracks : MonoBehaviour
{
    public GameObject[] tracks;
   

    public float getMidXTrack(int index)
    {
        return tracks[index].transform.position.x;
    }
  
    public  GameObject this[int index]
    {
        get
        {
            return  this.tracks[index];
        }
    }
 
}
