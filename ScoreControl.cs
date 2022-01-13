using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreControl : MonoBehaviour
{
    public TextMeshProUGUI Score;
    public GameObject[] players;
    GameObject player;
    AnimationControl animationControl; 
    // Start is called before the first frame update
    void Start()
    {
        Score.text = "";
    }

    void Awake()
    {
        player = players[PlayerPrefs.GetInt("selectedChar")];
        animationControl = player.GetComponent<AnimationControl>();
    }
    // Update is called once per frame
    void Update()
    {
      Score.text =  animationControl.score.ToString();
 
    }
}
