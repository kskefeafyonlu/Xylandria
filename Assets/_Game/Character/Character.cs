using JetBrains.Annotations;
using UnityEngine;

namespace _Game.Character
{
    public class Character : MonoBehaviour
    {
        public string CharacterName { get; private set; }
        [CanBeNull] public string CharacterNickname { get; private set; }
        public string CharacterSurname { get; private set; }
        
        public void SetCredentials(string cname, [CanBeNull] string nickname, string surname)
        {
            CharacterName = cname;
            CharacterNickname = nickname;
            CharacterSurname = surname;
        }
        
    }
}
