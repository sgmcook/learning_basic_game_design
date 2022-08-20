using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

    public GameObject reward;
    
    //Checks when the first collider hits the item, so that multiple colider entities don't set off
    bool collected = false; 

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player" && !collected) {
            Instantiate(reward, transform.position, Quaternion.identity);
            other.gameObject.GetComponent<PlayerCoinCounter>().addCoin();
            Destroy(gameObject.transform.root.gameObject);
            collected = true;
        }
    }

}
