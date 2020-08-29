using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Tracks tracks;
   
    void Start()
    {
        tracks = GameObject.FindGameObjectWithTag("Tracks").GetComponent<Tracks>();
    }
}
