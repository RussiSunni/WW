using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGreetingExercise : MonoBehaviour
{
    // collision
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("MayandEvaExercise");
    }
}






