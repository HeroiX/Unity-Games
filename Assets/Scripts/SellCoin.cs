using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellCoin : MonoBehaviour {

    public GameObject TextBox;

    public void ClickButton() {
        GlobalCoins.CoinCount -= 1;
        GlobalCash.CashCount += 1;
    }
    

}
