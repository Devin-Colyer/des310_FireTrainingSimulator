using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Wining : MonoBehaviour {

    [SerializeField]
    private GameObject ChickenDinner;
    [SerializeField]
    private GameObject NextBtn;
    [SerializeField]
    private GameObject RetryBtn;

    public float a = 0.1f;

    Animator anim;

    public void Win()
    {
        ChickenDinner.SetActive(true);
        Time.timeScale = a;
        anim = GetComponent<Animator>();

    }

    public void Next(string NextScene)
    {
        SceneManager.LoadScene(NextScene);
        Time.timeScale = 1;
    }


    public void Retry(string NextScene)
    {
        SceneManager.LoadScene(NextScene);
        Time.timeScale = 1;
    }


}
