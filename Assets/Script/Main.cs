using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main : MonoBehaviour
{
    // entrypoint.
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private void EntryPoint()
    {
        Debug.Log("entry");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
