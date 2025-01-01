using System;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager Instance;

    public BattleMap CurrentBattleMap;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (CurrentBattleMap == null) //Try to get the battle map if it is not set
        {
            TryGetBattleMap();
        }
    }

    
    
    private void TryGetBattleMap()
    {
        if (CurrentBattleMap == null)
        {
            CurrentBattleMap = FindFirstObjectByType<BattleMap>();
        }
    }
    
    public void SetBattleMap(BattleMap battleMap)
    {
        CurrentBattleMap = battleMap;
    }
}
