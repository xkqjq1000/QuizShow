using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singletone
    public static GameManager instance;


    public static GameManager GetInstance()
    {
        if (instance == null)   
        {
            GameObject go = new GameObject("@GameManager");    
            instance = go.AddComponent<GameManager>();

            DontDestroyOnLoad(go); 
        }
        return instance;
    }
    #endregion
}
