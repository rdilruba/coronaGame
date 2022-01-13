using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EntityGenerate : MonoBehaviour
{
    public GameObject[] entities;
    public Transform parent;

    void FixedUpdate()
    {
        System.Random randomIf = new System.Random(Guid.NewGuid().GetHashCode());
        float number = (float) randomIf.Next(0, 500);
        if(number<15){
            GameObject prefab = entities[getIndex()];
            GameObject clone = Instantiate(prefab, new Vector3(0,0,0) + getPosition(number), Quaternion.identity) as GameObject;
            clone.transform.SetParent(parent, false);
            clone.SetActive(true);
        }
        
    }

    int getIndex(){
        System.Random random = new System.Random(Guid.NewGuid().GetHashCode());
        if(random.NextDouble()>0.96)
            return 0;
        if(random.NextDouble()>0.93)
            return 1;
        if(random.NextDouble()>0.45)
            return 2;
        
        return 3;
    }

    Vector3 getPosition(float number){
        System.Random ran = new System.Random(Guid.NewGuid().GetHashCode());
        float num = (float) ran.Next(-17, 17);
        float x = num * 17;
        float y = (float) Math.Sqrt(289*289-x*x);
        if(number>7)
            return new Vector3(x,y,0);
        return new Vector3(x,-1*y,0);
    }

}
