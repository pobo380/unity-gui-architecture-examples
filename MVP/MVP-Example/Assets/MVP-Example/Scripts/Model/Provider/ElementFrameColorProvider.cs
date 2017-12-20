using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementFrameColorProvider : SingletonMonoBehaviour<ElementFrameColorProvider>
{
    // properties

    [SerializeField]
    private List<Color> _colors;

    // override methods (SingletonMonoBehavior)

    protected override void OnAwake()
    {
    }

    // public methods

    public bool TryGetColor(CharacterElementType elementType, out Color color)
    {
        color = new Color();

        int index = (int)elementType;
        if (index < 0 || _colors.Count <= index)
        {
            return false;
        }

        color = _colors[index];
        return true;
    }
}
