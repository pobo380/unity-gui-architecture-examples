using UnityEngine;

public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
    public static T Instance { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogError("This singleton has already instantiated.");
            Destroy(this);
            return;
        }

        Instance = this as T;
        OnAwake();
    }

    protected abstract void OnAwake();
}
