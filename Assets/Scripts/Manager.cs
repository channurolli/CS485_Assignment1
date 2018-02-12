using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    public static int currentScore;
    public static int highScore;

    public static int currentLevel = 0;
    public static int unlockedLevel;

    public static void CompleteLevel()
    {
        if (currentLevel <=1)
        {
            print(currentLevel);
            
            //Application.LoadLevel(currentLevel);
            SceneManager.LoadScene(1);
            
        }
        else if(currentLevel>1)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            print("YOU WIN!!!");
        }
    }
}
