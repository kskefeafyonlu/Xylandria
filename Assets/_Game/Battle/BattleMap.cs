using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleMap : MonoBehaviour
{
    public List<BattleSocket> BattleSockets = new List<BattleSocket>();

    private void Awake()
    {
        FindSocketsInChild();
    }

    
    
    

    private void FindSocketsInChild()
    {
        BattleSockets.Clear();
        BattleSocket[] sockets = GetComponentsInChildren<BattleSocket>();
        foreach (BattleSocket socket in sockets)
        {
            BattleSockets.Add(socket);
        }
    }
    
    
}
