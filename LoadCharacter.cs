using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] characters;
    void Start()
    {
        
        int selectedChar = PlayerPrefs.GetInt("selectedChar");
        GameObject prefab = characters[selectedChar];
        prefab.SetActive(true);

    }

}
