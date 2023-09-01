using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainersCtrl : LoboMonoBehaviour
{
    private static ContainersCtrl _instance;
    public static ContainersCtrl Instance => _instance;

    protected override void Awake()
    {
        if (ContainersCtrl._instance != null) Debug.LogError("only 1 ContainersCtrl allow to exist");
        ContainersCtrl._instance = this;
    }
}
