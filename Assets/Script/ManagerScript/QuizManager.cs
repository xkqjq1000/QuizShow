using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    #region Singletone
    public static QuizManager instance;

    public static QuizManager GetInstance()
    {
        if(instance == null)
        {
            GameObject go = new GameObject("@QuizManager");
            instance = go.AddComponent<QuizManager>();

            DontDestroyOnLoad(go);
        }
        return instance;
    }
    #endregion


    public Text quizText;
    public Button questionbtn;
    public Button answer1btn;
    public Button answer2btn;
    public Button answer3btn;
    private int RandomNum;

    public TMP_Text questiontxt;
    public TMP_Text answer1txt;
    public TMP_Text answer2txt;
    public TMP_Text answer3txt;
    void Start()
    {
        List<string> quizText = new List<string>();
        quizText.Add("보기1");
        quizText.Add("보기2");
        quizText.Add("보기3");

        answer1txt.text = quizText[0];
        answer2txt.text = quizText[1];
        answer3txt.text = quizText[2];
    }
    

}


