using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    void Start()
    {
        UIManager.GetInstance().OpenUI("MainUI");
        UIManager.GetInstance().SetEventSystem();
    }

    
}
