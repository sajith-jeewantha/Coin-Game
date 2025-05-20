using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinColletor : MonoBehaviour
{

    private int coin = 0;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coin++;
            Destroy(other.gameObject);
            //Debug.Log(coin);

            scoreText.text = "Score : " + coin;
        }
    }
}
