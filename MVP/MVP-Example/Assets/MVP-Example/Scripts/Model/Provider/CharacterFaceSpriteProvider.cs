using System.Collections.Generic;
using UnityEngine;

public class CharacterFaceSpriteProvider : SingletonMonoBehaviour<CharacterFaceSpriteProvider>
{
    // properties

    [SerializeField]
    private List<Sprite> _sprites;

    // override methods (SingletonMonoBehavior)

    protected override void OnAwake()
    {
    }

    // public methods

    public bool TryGetSprite(int characterId, out Sprite sprite)
    {
        sprite = null;

        int index = characterId - 1;
        if (index < 0 || _sprites.Count <= index)
        {
            return false;
        }

        sprite = _sprites[index];
        return true;
    }
}
