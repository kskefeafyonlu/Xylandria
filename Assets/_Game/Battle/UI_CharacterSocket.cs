using UnityEngine;

namespace _Game.Battle
{
    public class UI_CharacterSocket : MonoBehaviour
    {
        public Character.Character Character;
    
        public void SetCharacter(Character.Character character)
        {
            Character = character;
        }
    
        public Character.Character RemoveCharacter()
        {
            Character.Character character = Character;
            Character = null;
            return character;
        }

        public bool IsOccupied()
        {
            return Character != null;
        }
    }
}
