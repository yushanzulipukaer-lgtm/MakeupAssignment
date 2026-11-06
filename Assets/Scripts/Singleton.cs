using Unity.VisualScripting;
using UnityEngine;

public class Singleton<T> : MonoBehaviour
        where T : MonoBehaviour
{
    public static T instance;
    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this as T;
        }
    }
}
