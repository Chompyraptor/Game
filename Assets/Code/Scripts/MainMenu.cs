using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayLevelSelect () {
        SceneManager.LoadScene("LevelSelect");
    }

    public void QuitGame() {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
