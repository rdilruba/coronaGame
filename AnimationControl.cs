using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationControl : MonoBehaviour
{
    public GameObject Holo;
    public GameObject Mask;
    public double healthScore;
    public int score;
    int seconds;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        healthScore = 1;
        score = 0;
        seconds = 5;
        speed = -6f;
    }

    // Update is called once per frame
    void Update()
    {
        if(healthScore<=0.2){
            PlayerPrefs.SetInt("score", score);
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
        if(score != 0 && score % 50 == 0)
            speed = -1f * (6 +(score / 50));
    }

    public void initiateHolo()
     {
         StartCoroutine(timerHolo());
     }

    IEnumerator timerHolo(){

        Holo.SetActive(true);
        yield return new WaitForSeconds(seconds);
        Holo.SetActive(false);

    }

    public void initiateMask()
     {
         StartCoroutine(timerMask());
     }

    IEnumerator timerMask(){

        Mask.SetActive(true);
        yield return new WaitForSeconds(seconds);
        Mask.SetActive(false);

    }

    public void decreaseHealth(){
        if(!(Holo.activeSelf == true || Mask.activeSelf == true))
                healthScore = healthScore - 0.2;
    }

    public void increaseScore(){
        score = score + 1;
    }
}
