using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : LoboMonoBehaviour
{

    [SerializeField] private PlayerExperience _playerExperience;
    [SerializeField] private PlayerLevel _playerLevel;
    [SerializeField] private PlayerCoin _playerCoin;

    public int GetLevel()
    {
        return this._playerLevel.GetLevel();
    }

    public int GetCoin()
    {
        return this._playerCoin.GetCoin();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerExperience();
        this.LoadPlayerLevel();
        this.LoadPlayerCoin();
    }

    void LoadPlayerExperience()
    {
        if (this._playerExperience != null) return;
        this._playerExperience = GetComponentInChildren<PlayerExperience>();
        Debug.LogWarning(transform.name + ": LoadPlayerExperience", gameObject);
    }

    void LoadPlayerLevel()
    {
        if (this._playerLevel != null) return;
        this._playerLevel = GetComponentInChildren<PlayerLevel>();
        Debug.LogWarning(transform.name + ": LoadPlayerLevel", gameObject);
    }

    void LoadPlayerCoin()
    {
        if (this._playerCoin != null) return;
        this._playerCoin = GetComponentInChildren<PlayerCoin>();
        Debug.LogWarning(transform.name + ": LoadPlayerCoin", gameObject);
    }

    public void ReceiveExp(int expPoint)
    {
        this._playerExperience.ReceiveExp(expPoint);
    }

    public void ReceiveCoin(int coin)
    {
        this._playerCoin.IncreaseCoin(coin);
    }

    public void LevelUp()
    {
        this._playerLevel.LevelUp();
    }

    public void DecreaseCoin(int coin)
    {
        this._playerCoin.DecreaseCoin(coin);
    }


}
