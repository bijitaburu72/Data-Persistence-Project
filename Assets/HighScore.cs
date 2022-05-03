using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    DataManager dataManager;
    private Text scoretText;
    // Start is called before the first frame update
    void Start()
    {
        dataManager = GameObject.Find("DataManager").GetComponent<DataManager>();
        scoretText = GetComponent<Text>();
        scoretText.text =" HighScore:" + dataManager.score;
    }

    private void Update()
    {
        scoretText.text = dataManager.playerName + " HighScore:" + dataManager.score;
    }
}
