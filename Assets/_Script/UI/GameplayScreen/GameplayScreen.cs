using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayScreen : LoboMonoBehaviour
{

    [SerializeField] private LevelText _levelText;
    [SerializeField] private CoinText _coinText;
    [SerializeField] private LevelExp _levelExp;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadLevelText();
        this.LoadCoinText();
        this.LoadLevelExp();
    }

    void LoadLevelText()
    {
        if (this._levelText != null) return;
        this._levelText = GetComponentInChildren<LevelText>();
        Debug.LogWarning(transform.name + ": LoadLevelText", gameObject);
    }

    void LoadCoinText()
    {
        if (this._coinText != null) return;
        this._coinText = GetComponentInChildren<CoinText>();
        Debug.LogWarning(transform.name + ": LoadCoinText", gameObject);
    }

    void LoadLevelExp()
    {
        if (this._levelExp != null) return;
        this._levelExp = GetComponentInChildren<LevelExp>();
        Debug.LogWarning(transform.name + ": LoadLevelExp", gameObject);
    }

    public void ShowLevel(int level)
    {
        this._levelText.ShowLevel(level);
    }

    public void ShowCoin(int coin)
    {
        this._coinText.ShowCoin(coin);
    }

    public void ShowExpSlider(float newValue)
    {
        this._levelExp.ShowExpSlider(newValue);
    }

}
