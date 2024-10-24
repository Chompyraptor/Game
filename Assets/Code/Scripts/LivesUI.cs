using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lives : MonoBehaviour {
    
    [Header("References")]
    [SerializeField] TextMeshProUGUI LivesUI;

    private void OnGUI() {
        LivesUI.text = LevelManager.main.Lives.ToString();
    }

    public void SetSelected() {
        
    }
}

