using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCleanerController : MonoBehaviour {

    public GameObject punishment;
    public int damageTaken;
    
    public void restartGame() {
        SceneManager.LoadScene("Main");
    }

    public void quitGame() {
        Debug.Log("Quitting");
        Application.Quit();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Instantiate(punishment, other.transform.position, Quaternion.identity);
            int updatedHealth = other.gameObject.GetComponent<PlayerHealth>().takeCustomDamage(damageTaken);
            Debug.Log("Health is now :" + updatedHealth);
        }
    }

}
