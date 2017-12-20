using System.Collections.Generic;
using UnityEngine;

public class CharacterMasterDataProvider : SingletonMonoBehaviour<CharacterMasterDataProvider>
{
    // properties

    [SerializeField]
    private List<Character> _characters;

    // override methods (SingletonMonoBehavior)

    protected override void OnAwake()
    {
    }

    // public methods

    public bool TryGetData(int characterId, out Character data)
    {
        data = new Character();

        int index = characterId - 1;
        if (index < 0 || _characters.Count <= index)
        {
            return false;
        }

        data = _characters[index];

        return true;
    }
}
