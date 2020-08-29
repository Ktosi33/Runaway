using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracks : MonoBehaviour
{
public GameObject[] tracks;


 public  GameObject this[int index]
    {
        get
        {
            return  this.tracks[index];
        }
    }

}
