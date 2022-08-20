using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public string endText;
    public int healthCounter;
    public Image uiDeathScreen;
    public Image uiCoinCounter;
    public CanvasGroup uiCanvasGroup;
    public Text uiEndGameText;


    public void Start() {}

    public int takeCustomDamage(int damageTaken) {
        healthCounter -= damageTaken;
        if (checkIfDead()) {
            makeDead();
            return 0;
        } else {
            return healthCounter;
        }
    }

    bool checkIfDead() {
        if (healthCounter <= 0) {
            return true;
        } else {
            return false;
        }
    }

    public void makeDead() {
        endText = "You Died";
        endGame(endText, 72);
        setDeathUiElements();
    }

    public void endGame(string endGameText, int fontSize) {
        uiEndGameText.text = endGameText;
        uiEndGameText.fontSize = fontSize;
        uiCanvasGroup.alpha = 1;
        Destroy(gameObject.transform.root.gameObject);
    }

    void setDeathUiElements() {
        uiDeathScreen.color = Color.white;
        uiCoinCounter.color = Color.clear;
    }

}
