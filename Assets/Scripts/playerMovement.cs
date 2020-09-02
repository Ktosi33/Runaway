using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private enum Direction
    {
        straight= 0,
        left=-1,
        right=1
    }


    private Tracks tracks;
    IMove move;
    IMoveToPoint moveToPoint;
    [SerializeField]float speed=1;
    int currentTrack;
    Direction direction;

    
    private void Awake()
    {
        currentTrack = 1;
    }
    void Start()
    {
        tracks = GameObject.FindGameObjectWithTag("Tracks").GetComponent<Tracks>();
        move = new RigidBodyMove(this.gameObject.GetComponent<Rigidbody>());
        direction = Direction.straight;
    }
    private void FixedUpdate()
    {

        if (moveToPoint != null)
        {
            if (!moveToPoint.objectReachedTarget())
            {
                move.move(speed, (float)direction, 1);
            }
            else if(moveToPoint.objectReachedTarget())
            {
                direction = Direction.straight;
                moveToPoint.fixedObject();
                moveToPoint = null;
            }
        }
           


    }
    private void Update()
    {

        if (Input.GetKeyDown("d") && currentTrack < 2)
        {
            direction = Direction.right;
            currentTrack++;
            moveToPoint = new MoveToTrack(currentTrack, this.gameObject, move);
        }

        if (Input.GetKeyDown("a") && currentTrack > 0)
        {
            direction = Direction.left;
            currentTrack--;
            moveToPoint = new MoveToTrack(currentTrack, this.gameObject, move);
        }

        move.move(speed, 0, 1);
    }
}

 