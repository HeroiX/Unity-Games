using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCoin : MonoBehaviour {

    public GameObject textBox;
    public GameObject StatusBox;

    public void ClickButton() {

        if (GlobalCoins.CoinCount == 0)
        {
            StatusBox.GetComponent<Text>().text = "Not Enough Coins To Sell.";
            StatusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            GlobalCoins.CoinCount -= 1;
            GlobalCash.CashCount += 1;
        }
    }

    

}
