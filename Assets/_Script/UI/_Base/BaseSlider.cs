using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseSlider : LoboMonoBehaviour
{
    [Header("Base Slider")]
    [SerializeField] protected Slider slider;

    protected virtual void Start()
    {
        this.AddOnClickEvent();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSlider();
    }

    protected virtual void LoadSlider()
    {
        if (this.slider != null) return;
        this.slider = GetComponent<Slider>();
        Debug.LogWarning(transform.name + ": LoadSlider", gameObject);
    }

    protected virtual void AddOnClickEvent()
    {
        this.slider.onValueChanged.AddListener(this.OnChanged);
    }

    protected abstract void OnChanged(float newValue);
}
