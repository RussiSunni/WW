using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBase : MonoBehaviour
{
    public int number;
    public string questionName;
    public Sprite sprite;
    public List<string> answerOptions = new List<string>();
}