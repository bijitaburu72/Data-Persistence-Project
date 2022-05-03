using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
   public void ExitMain()
    {
        SceneManager.LoadScene(0);
    }
}
