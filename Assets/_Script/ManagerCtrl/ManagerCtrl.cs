using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCtrl : LoboMonoBehaviour
{

    private static ManagerCtrl _instance;
    public static ManagerCtrl Instance => _instance;

    [SerializeField] private InputManager _inputManager;
    public InputManager InputManager => _inputManager;

    [SerializeField] private SpawnerManager _spawnerManager;
    public SpawnerManager SpawnerManager => _spawnerManager;

    protected override void Awake()
    {
        if (ManagerCtrl._instance != null) Debug.LogError("only 1 ManagerCtrl allow to exist");
        ManagerCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadInputManager();
        this.LoadSpawnerManager();
    }

    void LoadInputManager()
    {
        if (this._inputManager != null) return;
        this._inputManager = GetComponentInChildren<InputManager>();
        Debug.LogWarning(transform.name + ": LoadInputManager", gameObject);
    }

    void LoadSpawnerManager()
    {
        if (this._spawnerManager != null) return;
        this._spawnerManager = GetComponentInChildren<SpawnerManager>();
        Debug.LogWarning(transform.name + ": LoadSpawnerManager", gameObject);
    }

}
