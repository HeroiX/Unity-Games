using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour {

    public GameObject TextBox;

    public void ClickButton() {
        GlobalCoins.CoinCount += 1;
    }
    

}
