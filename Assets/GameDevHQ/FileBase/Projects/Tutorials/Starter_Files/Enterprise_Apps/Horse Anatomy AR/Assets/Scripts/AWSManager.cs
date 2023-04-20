using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AWSManager : MonoBehaviour
{
    private static AWSManager _instance;
    public static AWSManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Aws manager is null");
            }
            return _instance;
        }
    }


    public void Awake()
    {
        _instance = this;
    }
}
