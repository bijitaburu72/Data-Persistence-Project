using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameScript : MonoBehaviour
{
    InputField inputField;
    DataManager dataManager;
    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();
        dataManager = GameObject.Find("DataManager").GetComponent<DataManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateName()
    {
        dataManager.playerName = inputField.text;
        inputField.text = "";
    }
}
