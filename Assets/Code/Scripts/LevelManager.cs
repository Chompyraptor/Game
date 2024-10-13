using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    
    public static LevelManager main;

    public Transform startPoint;
    public Transform[] path;

    public int currency;
    public int Lives;
    
    private void Awake() {
        main = this;
    }

    private void Start() {
        currency = 150;
        Lives = 20;
    }

    public void IncreaseCurrency(int amount) {
        currency += amount;
    }

    public bool SpendCurrency(int amount) {
        if (amount <= currency) {
            currency -= amount;
            return true;
            // Buy Item
        } else {
            return false;
        }
    }

    private bool gameEnded = false;

    public GameObject gameOverUI;

    void Update () {
        if (gameEnded)
            return;

        if (Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame () {
        gameEnded = true;

        gameOverUI.SetActive(true);
    }

}