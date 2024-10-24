using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

    public void BackToMenu () {
        SceneManager.LoadScene("MainMenu");
    }

        public void PlayLevel1 () {
        SceneManager.LoadScene("Level1");
    }

    public void PlayLevel2 () {
        SceneManager.LoadScene("Level2");
    }
}
