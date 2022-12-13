using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonCont : MonoBehaviour
{
    public Button menuStartbtn;
    public Button mainQuestion1btn;
    public Button mainQuestion2btn;
    public Button mainQuestion3btn;
    void Start()
    {
        menuStartbtn.onClick.AddListener(OnClickMenuStart);
        mainQuestion1btn.onClick.AddListener(OnclickMainQuestion1);
        mainQuestion2btn.onClick.AddListener(OnclickMainQuestion2);
        mainQuestion3btn.onClick.AddListener(OnclickMainQuestion3);
    }

    void OnClickMenuStart()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.MainScene);
    }

    void OnclickMainQuestion1()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.QuizScene);
    }

    void OnclickMainQuestion2()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.QuizScene);
    }

    void OnclickMainQuestion3()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.QuizScene);
    }
}
