using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCtrl : LoboMonoBehaviour
{

    private static ManagerCtrl _instance;
    public static ManagerCtrl Instance => _instance;

    [SerializeField] private InputManager _inputManager;
    public InputManager InputManager => _inputManager;

    protected override void Awake()
    {
        if (ManagerCtrl._instance != null) Debug.LogError("only 1 ManagerCtrl allow to exist");
        ManagerCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadInputManager();
    }

    void LoadInputManager()
    {
        if (this._inputManager != null) return;
        this._inputManager = GetComponentInChildren<InputManager>();
        Debug.Log(transform.name + ": LoadInputManager", gameObject);
    }

}
