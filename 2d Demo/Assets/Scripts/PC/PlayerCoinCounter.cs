using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCoinCounter : MonoBehaviour {

    public string endText;
    public Text coinText;
    public int coinsToWin;

    int coinCount = 0;

    void Start() {
        coinText.text = coinCount.ToString();
    }

    public void addCoin() {
        coinCount++;
        coinText.text = coinCount.ToString();
        checkIfPlayerWon();
    }

    public void checkIfPlayerWon() {
        if (coinCount >= coinsToWin) {
            endText = "Congratulations, you won!";
            GetComponent<PlayerHealth>().endGame(endText, 40);
        }
    }
}
