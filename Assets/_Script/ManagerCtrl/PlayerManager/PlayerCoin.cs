using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{

    [SerializeField] private int _coin = 10;

    private void Awake()
    {
        this.GetCoinFromPlayerPrefs();
        this.ShowCoin();
    }

    public int GetCoin()
    {
        return this._coin;
    }    

    public void IncreaseCoin(int coin)
    {
        this._coin += coin;
        this.ShowCoin();
        this.SaveCoin();
    }

    public void DecreaseCoin(int coin)
    {
        this._coin -= coin;
        this.ShowCoin();
        this.SaveCoin();
    }

    void ShowCoin()
    {
        UICtrl.Instance.ShowCoin(this._coin);
    }

    void SaveCoin()
    {
        PlayerPrefs.SetInt("Coin", this._coin);
    }    

    void GetCoinFromPlayerPrefs()
    {
        PlayerPrefs.GetInt("Coin", this._coin);
    }    

}
