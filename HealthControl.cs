using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthControl : MonoBehaviour
{
    Vector3 localScale;
    public GameObject[] players;
    GameObject player;
    AnimationControl animationControl; 
    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
    }

    void Awake()
    {
        player = players[PlayerPrefs.GetInt("selectedChar")];
        animationControl = player.GetComponent<AnimationControl>();
    }
    // Update is called once per frame
    void Update()
    {
      localScale.x = (float) animationControl.healthScore;
      transform.localScale = localScale;   
    }
}
