using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndScore : MonoBehaviour
{
    public TextMeshProUGUI Score;
    public TextMeshProUGUI HighScoreText;
    //AddController addController;
  
    // Start is called before the first frame update
    void Start()
    {
        //addController = this.GetComponent<AddController>();
        int highscore = PlayerPrefs.GetInt ("highscore");
        int score = PlayerPrefs.GetInt("score");
        Score.text = score.ToString();
        //PlayerPrefs.SetInt ("dead", (PlayerPrefs.GetInt ("dead") + 1));
        if(score>highscore){
            PlayerPrefs.SetInt ("highscore", score);
            PlayerPrefs.Save();
            HighScoreText.text = "New High Score";
        }
        /*if( PlayerPrefs.GetInt ("dead") % 3 == 0)
            addController.ShowInterstitialAd(); */
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onTryAgain(){
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
