using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : BasePlayerManager
{

    [SerializeField] private int _level = 1;

    private void Start()
    {
        this.LoadLevel();
    }

    void LoadLevel()
    {
            
    }    

    public void LevelUp()
    {
        this._level++;
        Debug.Log(this._level);
        UICtrl.Instance.GameplayScreen.TopScreen.LevelText.ShowLevel(this._level);
        //UICtrl.Instance.ShowLevelScreen(this._level);
        UICtrl.Instance.ShowExpSlider(0);
    }    

    public int GetLevel()
    {
        return this._level;
    }

}
