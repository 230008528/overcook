using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCounter : BaseCounter{
     
    public static event EventHandler OnAnyObjectTrashed;

    new public static void ResetStaticData(){
        OnAnyObjectTrashed = null;
    }
    public override void Interact(Player player){

        if (player.HasKitchenObject()){
            player.GetKitchenObject().DestroySelf();

            OnAnyObjectTrashed?.Invoke(this, EventArgs.Empty);
        }
       
    }
    public override void Interact2( Player2 player2)
    {

      
        if (player2.HasKitchenObject())
        {
            player2.GetKitchenObject().DestroySelf();

            OnAnyObjectTrashed?.Invoke(this, EventArgs.Empty);
        }
    }
}
