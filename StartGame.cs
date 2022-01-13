using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void onSelect(int character){
        PlayerPrefs.SetInt("selectedChar", character);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
