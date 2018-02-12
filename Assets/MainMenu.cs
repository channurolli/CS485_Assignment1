using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void Roll()
    {
        SceneManager.LoadScene(1);
    }

    public void Maze()
    {
        SceneManager.LoadScene(2);
        SceneManager.LoadScene(3);

    }

    public void Quit()
    {
        Application.Quit();
    }

}
