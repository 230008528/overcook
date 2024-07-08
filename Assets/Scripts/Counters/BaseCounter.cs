﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour, IKitchenObjectParent{
    

    public static event EventHandler OnAnyObjectPlacedHere;

    public static void ResetStaticData(){
        OnAnyObjectPlacedHere = null;
    }

    [SerializeField] private Transform counterTopPoint;
    
    private KitchenObject kitchenObject;
    
    public virtual void Interact(Player player){
        Debug.Log("BaseCounter.Interact()");
    }
    public virtual void Interact2(Player2 player)
    {
        Debug.Log("BaseCounter.Interact()");
    }
    public virtual void InteractAlternate(Player player)
    {
        Debug.LogError("BaseCounter.InteractAlternate()"); // 不是所有的柜台都有这个交互，所以不应该输出Error信息，一开始作者是输出的，但是在后面改了
    }
    public virtual void InteractAlternate2(Player2 player2)
    {
        Debug.LogError("BaseCounter.InteractAlternate()"); // 不是所有的柜台都有这个交互，所以不应该输出Error信息，一开始作者是输出的，但是在后面改了
    }

    public Transform GetKitchenObjectFollowTransform(){
        return counterTopPoint;
    }
    
    public void SetKitchenObject(KitchenObject kitchenObject){
        this.kitchenObject = kitchenObject;
        if (kitchenObject != null){
            OnAnyObjectPlacedHere?.Invoke(this, EventArgs.Empty);
        }
    }

    public KitchenObject GetKitchenObject(){
        return kitchenObject;
    }
    
    public void ClearKitchenObject(){
        kitchenObject = null;
    }
    
    public bool HasKitchenObject(){
        return kitchenObject != null;
    }

    internal void InteractAlternate(Player2 player2)
    {
        throw new NotImplementedException();
    }

    internal void Interact(Player2 player2)
    {
        throw new NotImplementedException();
    }
}