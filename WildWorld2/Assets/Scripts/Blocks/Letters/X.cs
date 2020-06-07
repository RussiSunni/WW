﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X : Block
{
    private GameObject fairy;
    Animator fairyAnimator;


    // instantiate copy
    GameObject letterX;
    Transform parent;

    protected override void Start()
    {
        base.Start();
        if (sceneName == "ArtemisExercise")
        {
            fairy = GameObject.Find("Fairy");
            fairyAnimator = fairy.GetComponent<Animator>();
        }

        //instantiate copy
        parent = GameObject.Find("ExerciseArea").transform;
        letterX = (GameObject)Resources.Load("prefabs/x", typeof(GameObject));
    }

    protected override void OnMouseDrag()
    {
        base.OnMouseDrag();

        if (sceneName == "ArtemisExercise")
        {
            fairyAnimator.runtimeAnimatorController = null;
            SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
        }
    }

    protected override void OnMouseUp()
    {
        pressed = false;

        // with instantiate copies
        if (sceneName == "SecretaryExercise")
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f && Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[0] = "x";
                Transform newX = Instantiate(letterX.transform) as Transform;
                newX.transform.parent = parent.transform;
                newX.transform.localPosition = new Vector2(-4.368f, -0.624f);
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[1] = "x";
                Transform newX = Instantiate(letterX.transform) as Transform;
                newX.transform.parent = parent.transform;
                newX.transform.localPosition = new Vector2(-4.368f, -0.624f);
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
              Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[2].position.x, targetBlock[2].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[2] = "x";
                Transform newX = Instantiate(letterX.transform) as Transform;
                newX.transform.parent = parent.transform;
                newX.transform.localPosition = new Vector2(-4.368f, -0.624f);
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[3].position.x) <= 0.5f &&
              Mathf.Abs(transform.position.y - targetBlock[3].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[3].position.x, targetBlock[3].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[3] = "x";
                Transform newX = Instantiate(letterX.transform) as Transform;
                newX.transform.parent = parent.transform;
                newX.transform.localPosition = new Vector2(-4.368f, -0.624f);
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[4].position.x) <= 0.5f &&
            Mathf.Abs(transform.position.y - targetBlock[4].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[4].position.x, targetBlock[4].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[4] = "x";
                Transform newX = Instantiate(letterX.transform) as Transform;
                newX.transform.parent = parent.transform;
                newX.transform.localPosition = new Vector2(-4.368f, -0.624f);
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
            }
        }
        else if (sceneName == "ArtemisExercise")
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                                  Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f ||
                                                  Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                                                  Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f ||
                                                  Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                                                  Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f ||
                                                   Mathf.Abs(transform.position.x - targetBlock[3].position.x) <= 0.5f &&
                                                  Mathf.Abs(transform.position.y - targetBlock[3].position.y) <= 0.5f)
            {
                this.gameObject.SetActive(false);
                destroyed = true;
                SoundManagerScript.playErrorSound();
                fairyAnimator.runtimeAnimatorController = Resources.Load("fairy disappointed 1") as RuntimeAnimatorController;
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
            }
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
        // doubleclick
        if (Input.GetMouseButtonUp(0))
            clickCounter += 1;

        if (clickCounter == 1 && coroutineAllowed)
        {
            firstClickTime = Time.time;
            StartCoroutine(DoubleClickDetection());
        }
    }

    // doubleclick
    protected IEnumerator DoubleClickDetection()
    {
        coroutineAllowed = false;

        while (Time.time < firstClickTime + timeBetweenClicks)
        {
            if (clickCounter == 2)
            {
                SoundManagerScript.playXLetterSound();
                _targetRot *= Quaternion.Euler(RotateStep);
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        clickCounter = 0;
        firstClickTime = 0f;
        coroutineAllowed = true;
    }
}
