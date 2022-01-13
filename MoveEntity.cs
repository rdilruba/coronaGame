using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;


public class MoveEntity : MonoBehaviour, IPointerClickHandler
{
    public GameObject[] players;
    public Transform parent;
    private BoxCollider2D boxCollider;
    private Rigidbody2D rigidBody;
    AnimationControl animationControl; 
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Awake()
    {
        GameObject player = players[PlayerPrefs.GetInt("selectedChar")];
        animationControl = player.GetComponent<AnimationControl>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 vector = new Vector2(getDist(transform.position.x-parent.position.x,transform.position.y-parent.position.y), 
        getDist(transform.position.y-parent.position.y,transform.position.x-parent.position.x));
        transform.position = (Vector2) transform.position + vector;
    }

    float  getDist(float x, float y){
        if((y*y+x*x) == 0)
            return 0;
        return x*animationControl.speed/(float)Math.Sqrt(y*y+x*x);
    }

     public void RemoveObject(){
        if(this.gameObject.name.Contains("Clone")){
             if(this.gameObject.name.Contains("Covid")){

                animationControl.decreaseHealth();
             }
            Destroy(this.gameObject);
        }
    }

    //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if(this.gameObject.name.Contains("Clone")){
                if(this.gameObject.name.Contains("Sanitizer"))
                    animationControl.initiateHolo();
                else if(this.gameObject.name.Contains("Mask"))
                    animationControl.initiateMask();
                else{
                    animationControl.increaseScore();
                }
			    Destroy(this.gameObject);
           }
    }
}
