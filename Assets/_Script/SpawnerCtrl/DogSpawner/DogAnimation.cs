using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAnimation : BaseDogPrefab
{
    [SerializeField] private const string IS_DEAD = "isDead";
    
    public void SetDead()
    {
        this.dogPrefabCtrl.Animator.SetBool(IS_DEAD, true);
    }

}
