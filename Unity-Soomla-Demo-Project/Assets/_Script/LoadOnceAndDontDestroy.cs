using UnityEngine;
using System.Collections;

public class LoadOnceAndDontDestroy : MonoBehaviour 
{
    public static GameObject _control = null;
    private bool _onlyOnce = true;
    void Awake()
    {
        if (_control == null && _onlyOnce)
        {
            Debug.Log("initializing the once only and once per game ");
            _onlyOnce = false;
            _control = gameObject;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.Log("destroying each time the scene is loaded ");
            Destroy(gameObject);
        }
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("the application is loading");
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
