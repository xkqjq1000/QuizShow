using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public enum Question
{
    Eminem,
    Notoriousbig,
    KendrickLamar,
    Jcole,
    Nirvana,
    ACDC,
    NothingButThieves,
    RoyalBlood

}


public class Quiz : MonoBehaviour
{
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

    public int score;
    void Start()
    {
        score = 0;
        
    }

    public void QuestionJcole()
    {
        List < string[]> quizTextArray = new List<string[] >();
        quizTextArray.Add(new string[] {"문제", "보기1", "보기2", "보기3" }); 

    }

    public void QuestionKendrick()
    {
        List<string[]> quizText = new List<string[]>();
        quizText.Add(new string[] { "문제", "보기1", "보기2", "보기3" });

        List<TMP_Text[]> quizTxt = new List<TMP_Text[]>();
        quizTxt.Add(new TMP_Text[] {questiontxt, answer1txt, answer2txt, answer3txt });

        for (int i = 0; i >= 4; i++)
        {
            
        }
    }
    public void QuestionEminem()
    {
        List<string[]> quizTextArray = new List<string[]>();
        quizTextArray.Add(new string[] { "문제", "보기1", "보기2", "보기3" });
    }

    public void QuestionNotoriousbig()
    {
        List<string> quizTextArray = new List<string>();
        quizTextArray.Add("보기1");
        quizTextArray.Add("보기2");
        quizTextArray.Add("보기3");

        quizTextArray[0] = answer1txt.text;
        quizTextArray[1] = answer2txt.text;
        quizTextArray[2] = answer3txt.text;
    }

    public void QuestionNirvana()
    {
        List<string> quizTextArray = new List<string>();
        quizTextArray.Add("보기1");
        quizTextArray.Add("보기2");
        quizTextArray.Add("보기3");

        quizTextArray[0] = answer1txt.text;
        quizTextArray[1] = answer2txt.text;
        quizTextArray[2] = answer3txt.text;
    }

    public Question GetRandomEnum()
    {
        var enumValues = System.Enum.GetValues(enumType: typeof(Question));
        return (Question)enumValues.GetValue(Random.Range(0, enumValues.Length));

        
    }

    public void OnClickScore()
    {
        score += 1;
    }

    public void TextQuiz()
    {
        
    }
}
