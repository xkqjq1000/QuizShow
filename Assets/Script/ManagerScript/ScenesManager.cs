using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum Scene
{
    MenuScene,
    MainScene,
    QuizScene
}
public class ScenesManager : MonoBehaviour
{
    #region Singletone
    public static ScenesManager instance;

    public static ScenesManager GetInstance()
    {
        if(instance == null)
        {
            GameObject go = new GameObject("@ScenesManager");
            instance = go.AddComponent<ScenesManager>();

            DontDestroyOnLoad(go);
        }
        return instance;
    }
    #endregion

    #region Scene Control
    public Scene currentScene;

    public void ChangeScene(Scene scene)
    {
        UIManager.GetInstance().ClearList();

        currentScene = scene;
        SceneManager.LoadScene(scene.ToString());

    }

    #endregion
}
