using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : LoboMonoBehaviour
{
    
    private static UICtrl _instance;
    public static UICtrl Instance => _instance;

    [SerializeField] private DragAndDrop _dragAndDrop;
    public DragAndDrop DragAndDrop => _dragAndDrop;

    [SerializeField] private GameplayScreen _gameplayScreen;
    public GameplayScreen GameplayScreen => _gameplayScreen;

    [SerializeField] private ShoppingMenu _shoppingMenu;
    public ShoppingMenu ShoppingMenu => _shoppingMenu;

    protected override void Awake()
    {
        if (UICtrl._instance != null) Debug.LogError("only 1 UICtrl allow to exist");
        UICtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDragAndDrop();
        this.LoadGameplayScreen();
        this.LoadShoppingMenu();
    }

    void LoadDragAndDrop()
    {
        if (this._dragAndDrop != null) return;
        this._dragAndDrop = GetComponentInChildren<DragAndDrop>();
        Debug.LogWarning(transform.name + ": LoadDragAndDrop", gameObject);
    }

    void LoadGameplayScreen()
    {
        if (this._gameplayScreen != null) return;
        this._gameplayScreen = GetComponentInChildren<GameplayScreen>();
        Debug.LogWarning(transform.name + ": LoadGameplayScreen", gameObject);
    }

    void LoadShoppingMenu()
    {
        if (this._shoppingMenu != null) return;
        this._shoppingMenu = GetComponentInChildren<ShoppingMenu>();
        Debug.LogWarning(transform.name + ": LoadShoppingMenu", gameObject);
    }

    public void CheckAllPriceInUI()
    {
        this.CheckAllPriceInShoppingMenu();
        this.CheckAllPriceInGamePlayScreen();
    }

    /// <summary>
    /// GameplayScreen
    /// </summary>

    void CheckAllPriceInGamePlayScreen()
    {
        this.CheckPriceBuyChickenButton();
    }

    void CheckPriceBuyChickenButton()
    {
        this._gameplayScreen.BottomScreen.BuyChickenButton.CheckPrice();
    }


    public void ShowLevelScreen(int level)
    {
        this._gameplayScreen.TopScreen.LevelText.ShowLevel(level);
    }

    public void ShowCoin(int coin)
    {
        this._gameplayScreen.TopScreen.CoinText.ShowCoin(coin);
    }

    public void ShowExpSlider(float newValue)
    {
        this._gameplayScreen.TopScreen.LevelExp.ShowExpSlider(newValue);
    }

    public void OnEnableGameplayScreen()
    {
        this._gameplayScreen.gameObject.SetActive(true);
    }

    public void DisableGameplayScreen()
    {
        this._gameplayScreen.gameObject.SetActive(false);
    }

    /// <summary>
    /// ShoppingMenu
    /// </summary>

    public void ShowLevelShoppingMenu(int index, int level)
    {
        this._shoppingMenu.ItemBuyList.ShowLevel(index, level);
    }

    public void OnEnableButtonOff(int index)
    {
        this._shoppingMenu.ItemBuyList.OnEnableButtonOff(index);
    }

    public void DisableShoppingMenu()
    {
        this._shoppingMenu.gameObject.SetActive(false);
    }

    public void OnEnableShoppingMenu()
    {
        this._shoppingMenu.gameObject.SetActive(true);
    }

    void CheckAllPriceInShoppingMenu()
    {
        this._shoppingMenu.CheckPriceAll();
    }    

}
