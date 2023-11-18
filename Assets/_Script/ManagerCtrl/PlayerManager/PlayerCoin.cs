using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{

    [SerializeField] private int _coin = 10;

    public int GetCoin()
    {
        return this._coin;
    }    

    public void IncreaseCoin(int coin)
    {
        this._coin += coin;
        this.ShowCoin();
    }

    public void DecreaseCoin(int coin)
    {
        this._coin -= coin;
        this.ShowCoin();
    }

    void ShowCoin()
    {
        UICtrl.Instance.ShowCoin(this._coin);
    }

}
