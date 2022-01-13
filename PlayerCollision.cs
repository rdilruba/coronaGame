using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public MoveEntity moveEntity;

    void OnCollisionEnter2D (Collision2D collisionInfo){
        if(collisionInfo.collider.tag == "SelectedPlayer"){
            moveEntity.RemoveObject();
        }
    }

}
