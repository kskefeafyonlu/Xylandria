using _Game.Character;
using UnityEngine;

public class BattleSocket : MonoBehaviour
{
    public Character Character;
    public bool IsPlaceable;
    
    
    
    
    
    public void SetCharacter(Character character)
    {
        Character = character;
    }
    
    public Character RemoveCharacter()
    {
        Character character = Character;
        Character = null;
        return character;
    }
    

    public bool IsOccupied()
    {
        return Character != null;
    }
}
