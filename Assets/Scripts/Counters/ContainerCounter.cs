using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter {
    
    
    public event EventHandler OnPlayerGrabbedObject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    

    public override void Interact(Player player){
        if (!player.HasKitchenObject()){
            
            KitchenObject.SpawnKitchenObject(kitchenObjectSO,player);
            
            OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }
        
    }
    public override void Interact2( Player2 player2)
    {
        if (!player2.HasKitchenObject())
        {
            KitchenObject.SpawnKitchenObject(kitchenObjectSO, player2);
            OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }
    }

}