using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopScreen : LoboMonoBehaviour
{

    [SerializeField] private LevelText _levelText;
    public LevelText LevelText => _levelText;

    [SerializeField] private CoinText _coinText;
    public CoinText CoinText => _coinText;

    [SerializeField] private LevelExp _levelExp;
    public LevelExp LevelExp => _levelExp;

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

}
