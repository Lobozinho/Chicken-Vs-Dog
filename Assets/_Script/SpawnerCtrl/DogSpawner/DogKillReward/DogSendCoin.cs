using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSendCoin : BaseDogKillReward
{

    [SerializeField] private int _coinDefault = 10;    
    
    public void SendCoin()
    {
        int scale = this.dogKillReward.GetScale();
        int coin = scale * this._coinDefault;
        ManagerCtrl.Instance.PlayerManager.ReceiveCoin(coin);
    }    

}
