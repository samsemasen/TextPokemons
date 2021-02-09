using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inherit to create a single, global-accessible instance of a class, available at all times.
public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance = null;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (T)FindObjectOfType(typeof(T));

                if (instance == null)
                {

                    string goName = typeof(T).ToString();

                    GameObject go = GameObject.Find(goName);
                    if (go == null)
                    {
                        go = new GameObject();
                        go.name = goName;
                    }

                    instance = go.AddComponent<T>();
                }
            }

            return instance;
        }

    }

    public virtual void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = GetComponent<T>();

        //the GameObject will persist across multiple scenes
        DontDestroyOnLoad(this);

        if (instance == null)
            return;
    }

    public virtual void OnApplicationQuit()
    {
        // release reference on exit
        instance = null;
    }
}


//using UnityEngine;
//using System.Collections;

//public class Singleton<T> : MonoBehaviour where T : Component
//{
//	private static T _instance;
//	public static T Instance
//	{
//		get
//		{
//			if (_instance == null)
//			{
//				var objs = FindObjectsOfType(typeof(T)) as T[];
//				if (objs.Length > 0)
//					_instance = objs[0];
//				if (objs.Length > 1)
//				{
//					Debug.LogError("There is more than one " + typeof(T).Name + " in the scene.");
//				}
//				if (_instance == null)
//				{
//					GameObject obj = new GameObject();
//					obj.hideFlags = HideFlags.HideAndDontSave;
//					_instance = obj.AddComponent<T>();
//				}
//			}
//			return _instance;
//		}
//	}
//}


//public class MonoBehaviourSingletonPersistent<T> : MonoBehaviour
//	where T : Component
//{
//	public static T Instance { get; private set; }

//	public virtual void Awake()
//	{
//		if (Instance == null)
//		{
//			Instance = this as T;
//			DontDestroyOnLoad(this);
//		} else
//		{
//			Destroy(gameObject);
//		}
//	}
//}