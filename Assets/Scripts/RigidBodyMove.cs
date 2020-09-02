using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMove: IMove
{
   private Rigidbody rigidbody;
    
    public RigidBodyMove(Rigidbody rigidbody)
    {
        this.rigidbody = rigidbody;
    }

    public void move(float speed, float HorizontalValue, float VerticalValue)
    {
        rigidbody.velocity = new Vector3(HorizontalValue, 0, VerticalValue) * speed;
    }
 

}

