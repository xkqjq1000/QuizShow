using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
    #region Singletone
    public static UIManager Instance;

    public static UIManager GetInstance()
    {
        if (Instance == null)
        {
            GameObject go = new GameObject("@UIManager");
            Instance = go.AddComponent<UIManager>();

            DontDestroyOnLoad(go);
        }
        return Instance;
    }
    #endregion

    #region UIControl

    public void SetEventSystem()
    {
        if (FindObjectOfType<EventSystem>() == false)
        {
            GameObject go = new GameObject("@EventSystem");
            go.AddComponent<EventSystem>();
            go.AddComponent<StandaloneInputModule>();
        }
    }

    Dictionary<string, GameObject> uiList = new Dictionary<string, GameObject>();

    public void OpenUI(string uiName)
    {
        if (uiList.ContainsKey(uiName) == false)
        {
            Object uiObj = Resources.Load("UI/" + uiName);
            GameObject go = (GameObject)Instantiate(uiObj);
            uiList.Add(uiName, go);
        }
        else
            uiList[uiName].SetActive(true);
    }

    public void CloseUI(string uiName) 
    {
        if(uiList.ContainsKey(uiName))
            uiList[uiName].SetActive(false);
    }

    public GameObject GetUI(string uiName)
    {
        if(uiList.ContainsKey(uiName))
            return uiList[uiName];

        return null;
    }

    public void ClearList()
    {
        uiList.Clear();
    }

    #endregion
}
