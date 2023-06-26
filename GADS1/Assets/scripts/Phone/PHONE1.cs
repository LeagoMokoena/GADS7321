using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHONE1 : MonoBehaviour
{
    private static PHONE1 instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(instance);
        }
    }
}
