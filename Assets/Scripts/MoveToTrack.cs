using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTrack : IMoveToPoint
{

    IMove typeOfMovemnt;
    int targetTrackIndex;
    GameObject objectToMove;
    public MoveToTrack(int targetTrackIndex, GameObject objectToMove, IMove typeOfMovemnt)
    {
        this.targetTrackIndex = targetTrackIndex;
        this.objectToMove = objectToMove;
        this.typeOfMovemnt = typeOfMovemnt;
    }

   public bool objectReachedTarget()
    {
        // Debug.Log(Mathf.Abs(GameObject.FindGameObjectWithTag("Tracks").GetComponent<Tracks>().getMidXTrack(targetTrackIndex) - objectToMove.transform.position.x));
        Debug.Log(targetTrackIndex);
        if(Mathf.Abs(GameObject.FindGameObjectWithTag("Tracks").GetComponent<Tracks>().getMidXTrack(targetTrackIndex) - objectToMove.transform.position.x) < 0.2)
        {
            Debug.Log("true");
            return true;
        } else
        {
            return false;
        }
    }

   public void fixedObject()
    {
        if(objectReachedTarget())
        {
            typeOfMovemnt.move(0, 0, 0);
        }
    }
  
}
