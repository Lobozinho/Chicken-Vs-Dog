using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : LoboMonoBehaviour
{

    [SerializeField] private PlayerExperience _playerExperience;
    [SerializeField] private PlayerLevel _playerLevel;
    [SerializeField] private PlayerCoin _playerCoin;
    
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

    /// <summary>
    /// PlayerExperience
    /// </summary>

    public void ReceiveExp(int expPoint)
    {
        this._playerExperience.ReceiveExp(expPoint);
    }

    /// <summary>
    /// PlayerLevel
    /// </summary>

    public int GetLevel()
    {
        return this._playerLevel.GetLevel();
    }

    public void LevelUp()
    {
        this._playerLevel.LevelUp();
    }

    /// <summary>
    /// PlayerCoin
    /// </summary>

    public int GetCoin()
    {
        return this._playerCoin.GetCoin();
    }

    public void IncreaseCoin(int coin)
    {
        this._playerCoin.IncreaseCoin(coin);
        this.CheckAllCoin();
    }

    public void DecreaseCoin(int coin)
    {
        this._playerCoin.DecreaseCoin(coin);
        this.CheckAllCoin();
    }

    public void CheckAllCoin()
    {
        UICtrl.Instance.CheckAllPriceInUI();
    }    


}
